<?php
include 'header.php';
include_once 'config.php';

// Define variables and initialize with stored values
$username = $email = $phone = $postalcode = $city = $street = "";
$username_err = $email_err = $phone_err = $postalcode_err = $city_err = $street_err = "";
$fulladdress = "";

$userid = $_SESSION['id'];

$sql = "SELECT * from users WHERE id = $userid";
$result = $mysqli->query($sql);

foreach($result as $data)
{
    $username = $data["username"];
    $email = $data["email"];
    $phone = $data["phonenumber"];
    $fulladdress = $data["address"];
}
$result->close();

$addressArr = explode(" ", $fulladdress);
$postalcode = $addressArr[0];

$streetArr = explode(",", $fulladdress); //this separates the postalcode and street name
$city = explode(" ", $streetArr[0])[1]; //after that we choose the second value of this array
$street = substr($streetArr[1], 1); //remove the space from the street name

// Processing form data when form is submitted
if($_SERVER["REQUEST_METHOD"] == "POST"){
 
    // Validate username
    if(empty(trim($_POST["username"]))){
        $username_err = "Kérem adjon meg egy felhasználónevet.";
    } elseif(!preg_match('/^[a-zA-Z0-9_]+$/', trim($_POST["username"]))){
        $username_err = "A felhasználónév csak betűket és számokat tartalmazhat.";
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
                    $username_err = "Ez a felhasználónév már foglalt.";
                } else{
                    $username = trim($_POST["username"]); //if not taken set username
                }
            } else{
                echo "Váratlan hiba történt! Próbálkozzon később.";
            }

            // Close statement
            $stmt->close();
        }
    }
    
    // Validate phone number
    if(empty(trim($_POST["phone"]))){
        $phone_err = "Kérem adjon meg egy telefonszámot.";     
    } elseif(!preg_match('/^[0-9_]+$/', trim($_POST["phone"]))){
        $phone_err = "A telefonszám csak számokból állhat.";
    } else{
        $phone = trim($_POST["phone"]);
    }

    // Validate email
    if(empty(trim($_POST["email"]))){
        $email_err = "Kérem adja meg az email címét.";     
    } else{
        $email = trim($_POST["email"]);
    }

    // Validate postal code
    if(empty(trim($_POST["postalcode"]))){
        $postalcode_err = "Kérem adjon meg egy irányítószámot.";     
    } elseif(!preg_match('/^[0-9]+$/', trim($_POST["postalcode"]))){
        $postalcode_err = "Az irányítószám csak szám lehet.";
    } else{
        $postalcode = trim($_POST["postalcode"]);
    }

    // Validate city
    if(empty(trim($_POST["city"]))){
        $city_err = "Kérem adja meg a Várost.";     
    } else{
        $city = trim($_POST["city"]);
    }

    // Validate street
    if(empty(trim($_POST["street"]))){
        $street_err = "Kérem adjon meg egy címet.";     
    } elseif(!preg_match('/([a-zA-Z0-9])/', trim($_POST["street"]))){
        $street_err = "Az utcanév csak betűket és számokat tartalmazhat.";
    } else{
        $street = trim($_POST["street"]);
    }
    
    // Check input errors before inserting in database
    if(empty($username_err)){
        
        // Prepare an insert statement
        $sql = "UPDATE users SET username = ?, email = ?, address = ?, phonenumber = ? WHERE id = ?";
         
        if($stmt = $mysqli->prepare($sql)){
            // Bind variables to the prepared statement as parameters
            $stmt->bind_param("ssssd", $param_username, $param_email, $param_address, $param_phone, $param_id);
            
            // Set parameters
            $param_id = $_SESSION['id'];
            $param_username = $username;
            $param_email = $email;
            $param_phone = $phone;

            $streetlastchar = substr(trim($street), -1);

            if ($streetlastchar == '.') {
                $param_address = $postalcode . ' ' . $city . ', ' . $street;
            }
            else {
                $param_address = $postalcode . ' ' . $city . ', ' . $street . '.';
            }
            
            // Attempt to execute the prepared statement
            if($stmt->execute()){
                echo '<div class="alert alert-success">' . "Sikeresen megváltoztattad az adataid" . '</div>';
            } else{
                echo "Váratlan hiba történt!";
            }

            // Close statement
            $stmt->close();
        }
    }
    
    // Close connection
    $mysqli->close();
}
?>
<div class="container-fluid">
    <h3 class="text-dark mb-4">Profil</h3>
    <div class="row mb-3">
        <div class="col-lg-4">
            <div class="card shadow mb-3">
                <div class="card-header py-3">
                    <p class="text-primary m-0 fw-bold">Profilkép</p>
                </div>
                <div class="card-body text-center"><img class="rounded-circle mb-3 mt-4" src="assets/img/avatars/avatar5.jpeg" width="160" height="160">
                    <div class="mb-3"><button class="btn btn-primary btn-sm" type="button">Profilkép megváltoztatása</button></div>
                </div>
            </div>
        </div>
        <div class="col-lg-8">
            <div class="row mb-3 d-none">
                <div class="col"> </div>
                <div class="col"> </div>
            </div>
            <div class="row">
                <div class="col">
                    <div class="card shadow mb-3">
                        <div class="card-header py-3">
                            <p class="text-primary m-0 fw-bold">Felhasználó beállítások</p>
                        </div>
                        <div class="card-body">
                            <form action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]); ?>" method="post">
                                <div class="row">
                                    <div class="col">
                                        <div class="mb-3">
                                            <label class="form-label" for="username"><strong>Felhasználónév</strong></label>
                                            <input type="text" name="username" class="form-control form-control-user <?php echo (!empty($username_err)) ? 'is-invalid' : ''; ?>" value="<?php echo $username; ?>" placeholder="Felhasználónév">
                                            <span class="invalid-feedback"><?php echo $username_err; ?></span>
                                        </div>
                                    </div>
                                    <div class="col">
                                        <div class="mb-3">
                                            <label class="form-label" for="email"><strong>Email cím</strong></label>
                                            <input type="email" name="email" class="form-control form-control-user <?php echo (!empty($email_err)) ? 'is-invalid' : ''; ?>" value="<?php echo $email; ?>" placeholder="Email cím">
                                            <span class="invalid-feedback"><?php echo $email_err; ?></span>
                                        </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col">
                                        <div class="mb-3">
                                            <label class="form-label" for="postalcode"><strong>Irányítószám</strong></label>
                                            <input type="number" name="postalcode" class="form-control form-control-user <?php echo (!empty($postalcode_err)) ? 'is-invalid' : ''; ?>" value="<?php echo $postalcode; ?>" placeholder="Irányítószám">
                                            <span class="invalid-feedback"><?php echo $postalcode_err; ?></span>
                                        </div>
                                    </div>
                                    <div class="col">
                                        <div class="mb-3">
                                            <label class="form-label" for="city"><strong>Város</strong></label>
                                            <input type="text" name="city" class="form-control form-control-user <?php echo (!empty($city_err)) ? 'is-invalid' : ''; ?>" value="<?php echo $city; ?>" placeholder="Város">
                                            <span class="invalid-feedback"><?php echo $city_err; ?></span>
                                       </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col">
                                        <div class="mb-3">
                                            <label class="form-label" for="address"><strong>Cím</strong></label>
                                            <input type="text" name="street" class="form-control form-control-user <?php echo (!empty($street_err)) ? 'is-invalid' : ''; ?>" value="<?php echo $street; ?>" placeholder="Utca">
                                            <span class="invalid-feedback"><?php echo $street_err; ?></span>
                                        </div>
                                    </div>
                                    <div class="col">
                                        <div class="mb-3">
                                            <label class="form-label" for="phonenumber"><strong>Telefonszám</strong></label>
                                            <input type="tel" name="phone" class="form-control form-control-user <?php echo (!empty($phone_err)) ? 'is-invalid' : ''; ?>" value="<?php echo $phone; ?>" placeholder="Telefonszám">
                                            <span class="invalid-feedback"><?php echo $phone_err; ?></span>
                                        </div>
                                    </div>
                                </div>
                                <div class="mb-3">
                                    <button class="btn btn-primary btn-sm" id="saveuser" type="submit">Mentés</button>
                                </div>
                            </form>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<?php include 'footer.php'; ?>