<?php
// Include config file
require_once "config.php";
 
// Define variables and initialize with empty values
$username = $password = $confirm_password = $firstname = $lastname = $email = $phone = $borndate = $postalcode = $city = $street = "";
$username_err = $password_err = $confirm_password_err = $firstname_err = $lastname_err = $email_err = $phone_err = $borndate_err = $postalcode_err = $city_err = $street_err = "";
 
// Processing form data when form is submitted
if($_SERVER["REQUEST_METHOD"] == "POST"){
 
    // Validate username
    if(empty(trim($_POST["username"]))){
        $username_err = "Please enter a username.";
    } elseif(!preg_match('/^[a-zA-Z0-9_]+$/', trim($_POST["username"]))){
        $username_err = "Username can only contain letters, numbers, and underscores.";
    } else{
        // Prepare a select statement
        $sql = "SELECT id FROM users WHERE username = ?";
        
        if($stmt = $mysqli->prepare($sql)){
            // Bind variables to the prepared statement as parameters
            $stmt->bind_param("s", $param_username);
            
            // Set parameters
            $param_username = trim($_POST["username"]);
            
            // Attempt to execute the prepared statement
            if($stmt->execute()){
                // store result
                $stmt->store_result();
                
                if($stmt->num_rows == 1){
                    $username_err = "This username is already taken.";
                } else{
                    $username = trim($_POST["username"]); //if not taken set username
                }
            } else{
                echo "Oops! Something went wrong. Please try again later.";
            }

            // Close statement
            $stmt->close();
        }
    }
    
    // Validate password
    if(empty(trim($_POST["password"]))){
        $password_err = "Please enter a password.";     
    } elseif(strlen(trim($_POST["password"])) < 6){
        $password_err = "Password must have atleast 6 characters.";
    } else{
        $password = trim($_POST["password"]);
    }
    
    // Validate confirm password
    if(empty(trim($_POST["confirm_password"]))){
        $confirm_password_err = "Please confirm password.";     
    } else{
        $confirm_password = trim($_POST["confirm_password"]);
        if(empty($password_err) && ($password != $confirm_password)){
            $confirm_password_err = "Password did not match.";
        }
    }

    // Validate first name
    if(empty(trim($_POST["firstname"]))){
        $firstname_err = "Please enter Firstname.";
    } elseif(!preg_match('/^\\pL+$/u', trim($_POST["firstname"]))){
        $firstname_err = "Name can only contain letters.";
    } else{
        $firstname = trim($_POST["firstname"]);
    }

    // Validate second name
    if(empty(trim($_POST["lastname"]))){
        $lastname_err = "Please enter Lastname.";     
    } elseif(!preg_match('/^\\pL+$/u', trim($_POST["lastname"]))){
        $lastname_err = "Name can only contain letters.";
    } else{
        $lastname = trim($_POST["lastname"]);
    }

    // Validate phone number
    if(empty(trim($_POST["phone"]))){
        $phone_err = "Please enter Phonenumber.";     
    } elseif(!preg_match('/^[0-9_]+$/', trim($_POST["phone"]))){
        $phone_err = "Phone number can only contain numbers.";
    } else{
        $phone = trim($_POST["phone"]);
    }

    // Validate email
    if(empty(trim($_POST["email"]))){
        $email_err = "Please enter Email.";     
    } else{
        $email = trim($_POST["email"]);
    }

    // Validate borndate
    if(empty(trim($_POST["borndate"]))){
        $borndate_err = "Please enter Borndate.";     
    } else{
        $borndate = trim($_POST["borndate"]);
    }

    // Validate postal code
    if(empty(trim($_POST["postalcode"]))){
        $postalcode_err = "Please enter Postal code.";     
    } elseif(!preg_match('/^[0-9]+$/', trim($_POST["postalcode"]))){
        $postalcode_err = "Postal code can only contain numbers.";
    } else{
        $postalcode = trim($_POST["postalcode"]);
    }

    // Validate city
    if(empty(trim($_POST["city"]))){
        $city_err = "Please enter City.";     
    } else{
        $city = trim($_POST["city"]);
    }

    // Validate street
    if(empty(trim($_POST["street"]))){
        $street_err = "Please enter Street.";     
    } elseif(!preg_match('/([a-zA-Z0-9])/', trim($_POST["street"]))){
        $street_err = "Street can only contain letters and numbers.";
    } else{
        $street = trim($_POST["street"]);
    }
    
    // Check input errors before inserting in database
    if(empty($username_err) && empty($password_err) && empty($confirm_password_err)){
        
        // Prepare an insert statement
        $sql = "INSERT INTO users (username, password, email, phonenumber, name, birthdate, address) VALUES (?, ?, ?, ?, ?, ?, ?)";
         
        if($stmt = $mysqli->prepare($sql)){
            // Bind variables to the prepared statement as parameters
            $stmt->bind_param("sssssss", $param_username, $param_password, $param_email, $param_phone, $param_fullname, $param_borndate, $param_address);
            
            // Set parameters
            $param_username = $username;
            $param_password = encrypt($password);
            $param_email = $email;
            $param_phone = $phone;
            $param_fullname = $firstname . ' ' . $lastname;
            $param_borndate = $borndate;

            $streetlastchar = substr(trim($street), -1);

            if ($streetlastchar == '.') {
                $param_address = $postalcode . ' ' . $city . ', ' . $street;
            }
            else {
                $param_address = $postalcode . ' ' . $city . ', ' . $street . '.';
            }
            
            
            // Attempt to execute the prepared statement
            if($stmt->execute()){
                // Redirect to login page
                header("location: login.php");
            } else{
                echo "Oops! Something went wrong. Please try again later.";
            }

            // Close statement
            $stmt->close();
        }
    }
    
    // Close connection
    $mysqli->close();
}
?>
 
<!DOCTYPE html>
<html lang="hu">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="">
    <meta name="author" content="">

    <title>Sign Up</title>
    
    <!-- Custom fonts for this template-->
    <link href="vendor/fontawesome-free/css/all.min.css" rel="stylesheet" type="text/css">
    <link
        href="https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i"
        rel="stylesheet">

    <!-- Custom styles for this template-->
    <link href="css/sb-admin-2.min.css" rel="stylesheet">
</head>
<body class="bg-gradient-primary">
    <div class="container">
    <div class="card o-hidden border-0 shadow-lg my-5">
        <div class="card-body p-0">
            <!-- Nested Row within Card Body -->
            <div class="row">
                <div class="col-lg-5 d-none d-lg-block bg-register-image"></div>
                <div class="col-lg-7">
                    <div class="p-5">
                        <div class="text-center">
                            <h1 class="h4 text-gray-900 mb-4">Create an Account!</h1>
                            <form class="user" action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]); ?>" method="post">
                                <div class="form-group row">
                                    <div class="col-sm-6 mb-3 mb-sm-0">
                                        <input type="text" name="firstname" class="form-control form-control-user <?php echo (!empty($firstname_err)) ? 'is-invalid' : ''; ?>" value="<?php echo $firstname; ?>" placeholder="First Name">
                                        <span class="invalid-feedback"><?php echo $firstname_err; ?></span>
                                    </div>
                                    <div class="col-sm-6">
                                        <input type="text" name="lastname" class="form-control form-control-user <?php echo (!empty($lastname_err)) ? 'is-invalid' : ''; ?>" value="<?php echo $lastname; ?>" placeholder="Last Name">
                                        <span class="invalid-feedback"><?php echo $lastname_err; ?></span>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <input type="text" name="username" class="form-control form-control-user <?php echo (!empty($username_err)) ? 'is-invalid' : ''; ?>" value="<?php echo $username; ?>" placeholder="Felhasználónév">
                                    <span class="invalid-feedback"><?php echo $username_err; ?></span>
                                </div>    
                                <div class="form-group row">
                                    <div class="col-sm-6 mb-3 mb-sm-0">
                                        <input type="password" name="password" class="form-control form-control-user <?php echo (!empty($password_err)) ? 'is-invalid' : ''; ?>" value="<?php echo $password; ?>" placeholder="Jelszó">
                                        <span class="invalid-feedback"><?php echo $password_err; ?></span>
                                    </div>
                                    <div class="col-sm-6">
                                        <input type="password" name="confirm_password" class="form-control form-control-user <?php echo (!empty($confirm_password_err)) ? 'is-invalid' : ''; ?>" value="<?php echo $confirm_password; ?>" placeholder="Jelszó újra">
                                        <span class="invalid-feedback"><?php echo $confirm_password_err; ?></span>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <input type="email" name="email" class="form-control form-control-user <?php echo (!empty($email_err)) ? 'is-invalid' : ''; ?>" value="<?php echo $email; ?>" placeholder="Email Address">
                                    <span class="invalid-feedback"><?php echo $email_err; ?></span>
                                </div>
                                <div class="form-group row">
                                    <div class="col-sm-6 mb-3 mb-sm-0">
                                        <input type="date" name="borndate" class="form-control form-control-user <?php echo (!empty($borndate_err)) ? 'is-invalid' : ''; ?>" value="<?php echo $borndate; ?>" placeholder="Születési dátum">
                                        <span class="invalid-feedback"><?php echo $borndate_err; ?></span>
                                    </div>
                                    <div class="col-sm-6">
                                        <input type="tel" name="phone" class="form-control form-control-user <?php echo (!empty($phone_err)) ? 'is-invalid' : ''; ?>" value="<?php echo $phone; ?>" placeholder="Telefonszám">
                                        <span class="invalid-feedback"><?php echo $phone_err; ?></span>
                                    </div>
                                </div>
                                <div class="form-group row">
                                    <div class="col-sm-6 mb-3 mb-sm-0">
                                        <input type="number" name="postalcode" class="form-control form-control-user <?php echo (!empty($postalcode_err)) ? 'is-invalid' : ''; ?>" value="<?php echo $postalcode; ?>" placeholder="Irányítószám">
                                        <span class="invalid-feedback"><?php echo $postalcode_err; ?></span>
                                    </div>
                                    <div class="col-sm-6">
                                        <input type="text" name="city" class="form-control form-control-user <?php echo (!empty($city_err)) ? 'is-invalid' : ''; ?>" value="<?php echo $city; ?>" placeholder="Város">
                                        <span class="invalid-feedback"><?php echo $city_err; ?></span>
                                    </div>
                                </div>
                                <div class="form-group">
                                    <input type="text" name="street" class="form-control form-control-user <?php echo (!empty($street_err)) ? 'is-invalid' : ''; ?>" value="<?php echo $street; ?>" placeholder="Utca">
                                    <span class="invalid-feedback"><?php echo $street_err; ?></span>
                                </div>
                                <div class="form-group">
                                    <input type="submit" class="btn btn-primary btn-user btn-block" value="Submit">
                                </div>
                                <p>Already have an account? <a href="login.php">Login here</a>.</p>
                            </form>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    </div>
</body>
</html>