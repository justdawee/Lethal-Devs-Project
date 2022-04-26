<?php 
include 'header.php';
require_once 'config.php';

//For vehicles and users statistics
$targetuser = 10;
$totalusers = "";
$totalvehs = "";
$avgmileage = "";

$sql = "SELECT \n"
    . "(SELECT COUNT(*) FROM users) AS usercount, \n"
    . "(SELECT COUNT(*) FROM vehicles) AS vehcount, \n"
    . "(SELECT AVG(mileage) FROM vehicles) AS avgmileage;";

$result = $mysqli->query($sql);

if ($result->num_rows > 0) {
    while($row = $result->fetch_assoc()) {
        $totalusers = $row["usercount"];
        $totalvehs = $row["vehcount"];
        $avgmileage = $row["avgmileage"];
    }
}
$result->close();

$sql = "SELECT engine,COUNT(*) AS pcs FROM vehicles GROUP BY engine";
$result = $mysqli->query($sql);

foreach($result as $data)
{
  $engines[] = $data['engine'];
  $pcs[] = $data['pcs'];
}
$result->close();

?>

<div class="container-fluid">
    <div class="d-sm-flex justify-content-between align-items-center mb-4">
        <h3 class="text-dark mb-0">Főoldal</h3>
    </div>
    <div class="row">
        <div class="col-md-6 col-xl-3 mb-4">
            <div class="card shadow border-start-primary py-2">
                <div class="card-body">
                    <div class="row align-items-center no-gutters">
                        <div class="col me-2">
                            <div class="text-uppercase text-primary fw-bold text-xs mb-1"><span>Átlagos futás</span></div>
                            <div class="text-dark fw-bold h5 mb-0"><span><?php echo number_format(round($avgmileage), 0, '.', ' ') . " km" ?></span></div>
                        </div>
                        <div class="col-auto"><i class="icon-speedometer fa-2x text-gray-300"></i></div>
                    </div>
                </div>
            </div>
        </div>
        <div class="col-md-6 col-xl-3 mb-4">
            <div class="card shadow border-start-success py-2">
                <div class="card-body">
                    <div class="row align-items-center no-gutters">
                        <div class="col me-2">
                            <div class="text-uppercase text-success fw-bold text-xs mb-1"><span>Járművek</span></div>
                            <div class="text-dark fw-bold h5 mb-0"><span><?php echo $totalvehs . " db" ?></span></div>
                        </div>
                        <div class="col-auto"><i class="fas fa-car-side fa-2x text-gray-300"></i></div>
                    </div>
                </div>
            </div>
        </div>
        <div class="col-md-6 col-xl-3 mb-4">
            <div class="card shadow border-start-info py-2">
                <div class="card-body">
                    <div class="row align-items-center no-gutters">
                        <div class="col me-2">
                            <div class="text-uppercase text-info fw-bold text-xs mb-1"><span>Cél felhasználó</span></div>
                            <div class="row g-0 align-items-center">
                                <div class="col-auto">
                                    <div class="text-dark fw-bold h5 mb-0 me-3"><span><?php echo $totalusers / $targetuser * 100 . "%" ?></span></div>
                                </div>
                                <div class="col">
                                    <div class="progress progress-sm">
                                        <div class="progress-bar bg-info" aria-valuenow="<?php echo $totalusers ?>" aria-valuemin="0" aria-valuemax="<?php echo $targetuser ?>" style="width: <?php echo $totalusers / $targetuser * 100 . "%" ?>;"><span class="visually-hidden"><?php echo $totalusers / $targetuser * 100 . "%" ?></span></div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-auto"><i class="fas fa-users fa-2x text-gray-300"></i></div>
                    </div>
                </div>
            </div>
        </div>
        <div class="col-md-6 col-xl-3 mb-4">
            <div class="card shadow border-start-warning py-2">
                <div class="card-body">
                    <div class="row align-items-center no-gutters">
                        <div class="col me-2">
                            <div class="text-uppercase text-warning fw-bold text-xs mb-1"><span>Felhasználók</span></div>
                            <div class="text-dark fw-bold h5 mb-0"><span><?php echo $totalusers . " db" ?></span></div>
                        </div>
                        <div class="col-auto"><i class="fas fa-user fa-2x text-gray-300"></i></div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-lg-7 col-xl-8">
            <div class="card shadow mb-4">
                <div class="card-header d-flex justify-content-between align-items-center">
                    <h6 class="text-primary fw-bold m-0">Legnagyobb járművek cm<sup>3</sup> alapján</h6>
                    <div class="dropdown no-arrow"><button class="btn btn-link btn-sm dropdown-toggle" aria-expanded="false" data-bs-toggle="dropdown" type="button"><i class="fas fa-ellipsis-v text-gray-400"></i></button>
                    </div>
                </div>
                <div class="card-body text-break text-uppercase">
                    <div class="table-responsive">
                    <?php
                    $rowcount = 1;
                    $conn = $mysqli;
                        $result = mysqli_query($conn,"SELECT prodyear, type, engine, ccm, owner FROM vehicles ORDER BY ccm DESC");

                        echo "<table class='table'>
                        <thead>
                        <tr>
                        <th>#</th>
                        <th>Típus</th>
                        <th>Motor</th>
                        <th>cm<sup>3</sup></th>
                        <th>Tulaj</th>
                        </tr>
                        </thead>";
                        
                        while($row = mysqli_fetch_array($result))
                        {
                        echo "<tr>";
                        echo "<td>" . $rowcount . "</td>";
                        echo "<td>" . $row['prodyear'] . " " . $row['type'] . "</td>";
                        echo "<td>" . $row['engine'] . "</td>";
                        echo "<td>" . $row['ccm'] . "</td>";
                        echo "<td>" . $row['owner'] . "</td>";
                        echo "</tr>";
                        $rowcount++;
                        }
                        echo "</table>";
                    ?>
                    </div>
                </div>
            </div>
        </div>
        <div class="col-lg-5 col-xl-4">
            <div class="card shadow mb-4">
                <div class="card-header d-flex justify-content-between align-items-center">
                    <h6 class="text-primary fw-bold m-0">Motor típusok</h6>
                    <div class="dropdown no-arrow"><button class="btn btn-link btn-sm dropdown-toggle" aria-expanded="false" data-bs-toggle="dropdown" type="button"><i class="fas fa-ellipsis-v text-gray-400"></i></button>
                    </div>
                </div>
                <div class="card-body">
                    <div class="chart-area">
                        <canvas id="enginechart" height="320" style="display: block; width: 257px; height: 320px;" width="257"></canvas>
                        <script>
                        const labels = <?php echo json_encode($engines) ?>;
                        const data = {
                            labels: labels,
                            datasets: [{
                            label: '',
                            data: <?php echo json_encode($pcs) ?>,
                            backgroundColor: ['#1ABC9C', '#F1C40F', '#3498DB', '#E74C3C', '#9B59B6', '#34495E', '#95A5A6', '#D35400', '#F39C12'],
                            hoverBackgroundColor: ['#17a98c', '#d9b00e', '#2f89c5', '#b93d30', '#8c50a4', '#2f4255', '#869595', '#be4c00', '#db8c10'],
                            hoverBorderColor: "rgba(234, 236, 244, 1)"
                            }]
                        };

                        const config = {
                            type: 'doughnut',
                            data: data,
                            options: {
                                maintainAspectRatio: false,
                                legend: {
                                    display: true,
                                    position: 'bottom'
                                },
                                tooltips: {
                                    backgroundColor: "rgb(255,255,255)",
                                    bodyFontColor: "#858796",
                                    borderColor: '#dddfeb',
                                    borderWidth: 1,
                                    xPadding: 15,
                                    yPadding: 15,
                                    displayColors: false,
                                    caretPadding: 10
                                },
                                cutoutPercentage: 80,
                                responsive: true
                            },
                        };

                        var myChart = new Chart(
                            document.getElementById('enginechart'),
                            config
                        );
                    </script>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<?php include 'footer.php'; ?>