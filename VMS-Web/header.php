<?php
// Initialize the session
session_start();

// Check if the user is logged in, if not then redirect him to login page
if (!isset($_SESSION["loggedin"]) || $_SESSION["loggedin"] !== true) {
    header("location: login.php");
    exit;
}

?>

<!DOCTYPE html>
<html lang="hu">

<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0, shrink-to-fit=no">
    <title>VMS - Lethal Devs</title>
    <link rel="apple-touch-icon" type="image/png" sizes="180x180" href="assets/img/favicon-180x180.png">
    <link rel="icon" type="image/png" sizes="16x16" href="assets/img/favicon-16x16.png">
    <link rel="icon" type="image/png" sizes="32x32" href="assets/img/favicon-32x32.png">
    <link rel="icon" type="image/png" sizes="180x180" href="assets/img/favicon-180x180.png">
    <link rel="icon" type="image/png" sizes="192x192" href="assets/img/favicon-192x192.png">
    <link rel="icon" type="image/png" sizes="512x512" href="assets/img/favicon-512x512.png">
    <link rel="stylesheet" href="assets/bootstrap/css/bootstrap.min.css">
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i">
    <link rel="stylesheet" href="assets/fonts/fontawesome-all.min.css">
    <link rel="stylesheet" href="assets/fonts/font-awesome.min.css">
    <link rel="stylesheet" href="assets/fonts/simple-line-icons.min.css">
    <link rel="stylesheet" href="assets/fonts/fontawesome5-overrides.min.css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/animate.css/3.5.2/animate.min.css">
    <script src="assets/js/jquery.min.js"></script>
    <script src="assets/bootstrap/js/bootstrap.min.js"></script>
    <script src="https://cdn.jsdelivr.net/npm/chart.js@3.7.1/dist/chart.min.js"></script>
    <!-- DataTables dependencies -->
    <link rel="stylesheet" type="text/css" href="https://cdn.datatables.net/v/bs5/jqc-1.12.4/moment-2.18.1/dt-1.11.5/b-2.2.2/date-1.1.2/r-2.2.9/sc-2.0.5/sl-1.3.4/datatables.min.css">
    <link rel="stylesheet" type="text/css" href="css/generator-base.css">
    <link rel="stylesheet" type="text/css" href="css/editor.bootstrap5.min.css">

    <script type="text/javascript" charset="utf-8" src="https://cdn.datatables.net/v/bs5/jqc-1.12.4/moment-2.18.1/dt-1.11.5/b-2.2.2/date-1.1.2/r-2.2.9/sc-2.0.5/sl-1.3.4/datatables.min.js"></script>
    <script type="text/javascript" charset="utf-8" src="js/dataTables.editor.min.js"></script>
    <script type="text/javascript" charset="utf-8" src="js/editor.bootstrap5.min.js"></script>
    <script type="text/javascript" charset="utf-8" src="js/table.vehicles.js"></script>
</head>
<body id="page-top">
    <div id="wrapper">
        <nav class="navbar navbar-dark align-items-start sidebar sidebar-dark accordion bg-gradient-primary p-0">
            <div class="container-fluid d-flex flex-column p-0"><a class="navbar-brand d-flex justify-content-center align-items-center sidebar-brand m-0" href="#">
                    <div class="sidebar-brand-icon"><i class="fas fa-car wobble animated" style="font-size: 3em;"></i></div>
                    <div class="sidebar-brand-text mx-3"><span>Jármű<br>adatbázis<br></span></div>
                </a>
                <hr class="sidebar-divider my-0">
                <ul class="navbar-nav text-light" id="accordionSidebar">
                    <li class="nav-item"> <a <?php if($_SERVER['SCRIPT_NAME']=="/index.php") { ?>  class="nav-link active" <?php } else { ?>  class="nav-link" <?php } ?> " href="index.php"><i class="fa fa-home"></i><span>Főoldal</span></a></li>
                    <li class="nav-item"> <a <?php if($_SERVER['SCRIPT_NAME']=="/profile.php") { ?>  class="nav-link active" <?php } else { ?>  class="nav-link" <?php } ?> " href="profile.php"><i class="fas fa-user"></i><span>Profil</span></a></li>
                    <li class="nav-item"> <a <?php if($_SERVER['SCRIPT_NAME']=="/table.php") { ?>  class="nav-link active" <?php } else { ?>  class="nav-link" <?php } ?> " href="table.php"><i class="fas fa-table"></i><span>Járműveim</span></a></li>
                </ul>
                <div class="text-center d-none d-md-inline"><button class="btn rounded-circle border-0" data-bss-hover-animate="tada" id="sidebarToggle" type="button"></button></div>
            </div>
        </nav>
        <div class="d-flex flex-column" id="content-wrapper">
            <div id="content">
                <nav class="navbar navbar-light navbar-expand bg-white shadow mb-4 topbar static-top">
                    <div class="container-fluid"><button class="btn btn-link d-md-none rounded-circle me-3" id="sidebarToggleTop" type="button"><i class="fas fa-bars"></i></button>
                        <form class="d-none d-sm-inline-block me-auto ms-md-3 my-2 my-md-0 mw-100 navbar-search">
                            <div class="input-group">
                                <input class="bg-light form-control border-0 small" type="text" placeholder="Keresés...">
                                <button class="btn btn-primary py-0" type="button"><i class="fas fa-search"></i></button>
                            </div>
                        </form>
                        <ul class="navbar-nav flex-nowrap ms-auto">
                            <li class="nav-item dropdown d-sm-none no-arrow"><a class="dropdown-toggle nav-link" aria-expanded="false" data-bs-toggle="dropdown" href="#"><i class="fas fa-search"></i></a>
                            </li>
                            <li class="nav-item dropdown no-arrow mx-1"></li>
                            <li class="nav-item dropdown no-arrow mx-1">
                                <div class="shadow dropdown-list dropdown-menu dropdown-menu-end" aria-labelledby="alertsDropdown"></div>
                            </li>
                            <div class="d-none d-sm-block topbar-divider"></div>
                            <li class="nav-item dropdown no-arrow">
                                <div class="nav-item dropdown no-arrow"><a class="dropdown-toggle nav-link" aria-expanded="false" data-bs-toggle="dropdown" href="#"><span class="d-none d-lg-inline me-2 text-gray-600 small"><?php echo htmlspecialchars($_SESSION["username"]); ?></span><img class="border rounded-circle img-profile" src="assets/img/avatars/avatar5.jpeg"></a>
                                    <div class="dropdown-menu shadow dropdown-menu-end animated--grow-in">
                                        <a class="dropdown-item" href="profile.php"><i class="fas fa-user fa-sm fa-fw me-2 text-gray-400"></i>Profil</a>
                                        <div class="dropdown-divider"></div>
                                        <a class="dropdown-item" href="logout.php"><i class="fas fa-sign-out-alt fa-sm fa-fw me-2 text-gray-400"></i>Kijelentkezés</a>
                                    </div>
                                </div>
                            </li>
                        </ul>
                    </div>
                </nav>