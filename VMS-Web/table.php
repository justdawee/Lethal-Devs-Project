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
            <script>
                var table = $('#vehicles').DataTable();
                table.rows( { search: '<?php echo $_SESSION['realname'] ?>' } ).select()
            </script>
            <table cellpadding="0" cellspacing="0" border="0" class="table table-striped" id="vehicles" width="100%">
                <thead>
                    <tr>
                        <th>&Eacute;vj&aacute;rat</th>
                        <th>T&iacute;pus</th>
                        <th>Motor</th>
                        <th>K&ouml;bcenti</th>
                        <th>&Uuml;zemanyag</th>
                        <th>Sz&iacute;n</th>
                        <th>Fut&aacute;sadat</th>
                        <th>Rendsz&aacute;m</th>
                        <th>Alv&aacute;zsz&aacute;m</th>
                    </tr>
                </thead>
            </table>
            </div>
        </div>
    </div>
</div>

<?php include 'footer.php'; ?>