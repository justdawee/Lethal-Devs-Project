<?php 
include 'header.php'; 

?>

<div class="container-fluid">
    <h3 class="text-dark mb-4">Járműveim</h3>
    <div class="card shadow">
        <div class="card-header py-3">
            <p class="text-primary m-0 fw-bold">Jármű információk</p>
        </div>
        <div class="card-body">
            <div class="table-responsive table mt-2" id="dataTable" role="grid" aria-describedby="dataTable_info">
            <table cellpadding="0" cellspacing="0" border="0" class="table table-striped" id="vehicles" width="100%">
                <thead>
                    <tr>
                        <th>Évjárat</th>
                        <th>Típus</th>
                        <th>Motor</th>
                        <th>Köbcenti</th>
                        <th>Üzemanyag</th>
                        <th>Szín</th>
                        <th>Futásadat</th>
                        <th>Rendszám</th>
                        <th>Alvázszám</th>
                    </tr>
                </thead>
            </table>
            </div>
        </div>
    </div>
</div>

<?php include 'footer.php'; ?>