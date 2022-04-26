<?php
include 'header.php';

?>
<div class="container-fluid">
    <h3 class="text-dark mb-4">Profil</h3>
    <div class="row mb-3">
        <div class="col-lg-4">
            <div class="card mb-3">
                <div class="card-body text-center shadow"><img class="rounded-circle mb-3 mt-4" src="assets/img/dogs/image2.jpeg" width="160" height="160">
                    <div class="mb-3"><button class="btn btn-primary btn-sm" type="button">Profilkép megváltoztatása</button></div>
                </div>
            </div>
        </div>
        <div class="col-lg-8">
            <div class="row mb-3 d-none">
                <div class="col">
                    <div class="card textwhite bg-primary text-white shadow">
                        <div class="card-body">
                            <div class="row mb-2">
                                <div class="col">
                                    <p class="m-0">Peformance</p>
                                    <p class="m-0"><strong>65.2%</strong></p>
                                </div>
                                <div class="col-auto"><i class="fas fa-rocket fa-2x"></i></div>
                            </div>
                            <p class="text-white-50 small m-0"><i class="fas fa-arrow-up"></i>&nbsp;5% since last month</p>
                        </div>
                    </div>
                </div>
                <div class="col">
                    <div class="card textwhite bg-success text-white shadow">
                        <div class="card-body">
                            <div class="row mb-2">
                                <div class="col">
                                    <p class="m-0">Peformance</p>
                                    <p class="m-0"><strong>65.2%</strong></p>
                                </div>
                                <div class="col-auto"><i class="fas fa-rocket fa-2x"></i></div>
                            </div>
                            <p class="text-white-50 small m-0"><i class="fas fa-arrow-up"></i>&nbsp;5% since last month</p>
                        </div>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col">
                    <div class="card shadow mb-3">
                        <div class="card-header py-3">
                            <p class="text-primary m-0 fw-bold">Felhasználó beállítások</p>
                        </div>
                        <div class="card-body">
                            <form>
                                <div class="row">
                                    <div class="col">
                                        <div class="mb-3"><label class="form-label" for="username"><strong>Felhasználónév</strong></label><input class="form-control" type="text" id="username" placeholder="Felhasznalo.Nev" name="username"></div>
                                    </div>
                                    <div class="col">
                                        <div class="mb-3"><label class="form-label" for="email"><strong>Email cím</strong></label><input class="form-control" type="email" id="email" placeholder="minta@gmail.com" name="email"></div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col">
                                        <div class="mb-3"><label class="form-label" for="first_name"><strong>Vezetéknév</strong></label><input class="form-control" type="text" id="first_name" placeholder="Minta" name="first_name"></div>
                                    </div>
                                    <div class="col">
                                        <div class="mb-3"><label class="form-label" for="last_name"><strong>Keresztnév</strong></label><input class="form-control" type="text" id="last_name" placeholder="István" name="last_name"></div>
                                    </div>
                                </div>
                                <div class="mb-3"><button class="btn btn-primary btn-sm" id="saveuser" type="submit">Mentés</button></div>
                            </form>
                        </div>
                    </div>
                    <div class="card shadow">
                        <div class="card-header py-3">
                            <p class="text-primary m-0 fw-bold">Kapcsolat</p>
                        </div>
                        <div class="card-body">
                            <form>
                                <div class="row">
                                    <div class="col">
                                        <div class="mb-3"><label class="form-label" for="city"><strong>Város</strong></label><input class="form-control" type="text" id="city" placeholder="Budapest" name="city"></div>
                                    </div>
                                    <div class="col"><label class="form-label" for="address"><strong>Cím</strong></label><input class="form-control" type="text" id="address" placeholder="Minta utca 15." name="address">
                                        <div class="mb-3"></div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col">
                                        <div class="mb-3"><label class="form-label" for="country"><strong>Ország</strong></label><input class="form-control" type="text" id="country" placeholder="Magyarország" name="country"></div>
                                    </div>
                                    <div class="col"><label class="form-label" for="phonenumber"><strong>Telefonszám</strong></label><input class="form-control" type="text" id="phonenumber" placeholder="06201234567" name="phonenumber">
                                        <div class="mb-3"></div>
                                    </div>
                                </div>
                            </form><button class="btn btn-primary btn-sm" id="saveaddress" type="submit">Mentés</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<?php include 'footer.php'; ?>