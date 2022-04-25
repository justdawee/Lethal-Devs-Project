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
            <div class="row">
                <div class="col-md-6 text-nowrap">
                    <div id="dataTable_length" class="dataTables_length" aria-controls="dataTable"><label class="form-label">Sorok&nbsp;<select class="d-inline-block form-select form-select-sm">
                                <option value="10" selected="">10</option>
                                <option value="25">25</option>
                                <option value="50">50</option>
                                <option value="100">100</option>
                            </select>&nbsp;</label></div>
                </div>
                <div class="col-md-6">
                    <div class="text-md-end dataTables_filter" id="dataTable_filter"><label class="form-label"><input type="search" class="form-control form-control-sm" aria-controls="dataTable" placeholder="Search"></label></div>
                </div>
            </div>
            <div class="table-responsive table mt-2" id="dataTable" role="grid" aria-describedby="dataTable_info">
                <table class="table my-0" id="dataTable">
                    <thead>
                        <tr>
                            <th>Típus</th>
                            <th>Motor</th>
                            <th>Köbcenti</th>
                            <th>Futás</th>
                            <th>Rendszám</th>
                            <th>Szín</th>
                            <th>Üzemanyag</th>
                            <th>Alvázszám</th>
                            <th>Hozzáadva</th>
                            <th>Aktív</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td style="text-align: left;">2006 Audi A6</td>
                            <td>V6</td>
                            <td>3174</td>
                            <td>337.000km</td>
                            <td>2008/11/28</td>
                            <td>Fekete</td>
                            <td>Dízel</td>
                            <td>WVWBA7AJXCWXXXXXX</td>
                            <td>2022-04-17 09:20:07</td>
                            <td>Igen</td>
                        </tr>
                        <tr>
                            <td>2004 Ford Focus</td>
                            <td>I4</td>
                            <td>1587</td>
                            <td>152.300km</td>
                            <td>2009/10/09<br></td>
                            <td>Ezüst</td>
                            <td>Benzin</td>
                            <td>WVWBA7AJXCWXXXXXX</td>
                            <td>2022-04-14 23:06:34</td>
                            <td>Nem</td>
                        </tr>
                        <tr></tr>
                    </tbody>
                    <tfoot>
                        <tr></tr>
                    </tfoot>
                </table>
            </div>
            <div class="row">
                <div class="col-md-6 align-self-center">
                    <p id="dataTable_info" class="dataTables_info" role="status" aria-live="polite">Megjelenítve 10 a 27-ből.</p>
                </div>
                <div class="col-md-6">
                    <nav class="d-lg-flex justify-content-lg-end dataTables_paginate paging_simple_numbers">
                        <ul class="pagination">
                            <li class="page-item disabled"><a class="page-link" href="#" aria-label="Previous"><span aria-hidden="true">«</span></a></li>
                            <li class="page-item active"><a class="page-link" href="#">1</a></li>
                            <li class="page-item"><a class="page-link" href="#">2</a></li>
                            <li class="page-item"><a class="page-link" href="#">3</a></li>
                            <li class="page-item"><a class="page-link" href="#" aria-label="Next"><span aria-hidden="true">»</span></a></li>
                        </ul>
                    </nav>
                </div>
            </div>
        </div>
    </div>
</div>

<?php include 'footer.php'; ?>