<?php

require_once '../config/connect.php';
require_once '../config/init.php';

if (isset($_POST['orvosId']) && isset($_POST['szolgaltatasId'])) {
    $orvosId = (int) $_POST['orvosId'];
    $szolgalatasId = (int) $_POST['szolgaltatasId'];
    $taj = $_SESSION['taj'];

    $sql = "SELECT 
    visit.Id, 
    visit.Idopont, 
    doctor.Vezeteknev, 
    doctor.Keresztnev,
    specialization.Nev,
    service.Nev 
    FROM visit, doctor, service, specialization 
    WHERE visit.OrvosId = doctor.Id 
    AND service.Id = visit.SzolgaltatasId 
    AND specialization.Id = doctor.SzakteruletId 
    AND visit.Betegtaj = '$taj' ";

    if ($orvosId !== 0) {
        $sql .= "AND visit.OrvosId = $orvosId ";
    }

    if ($szolgalatasId !== 0) {
        $sql .= "AND visit.SzolgaltatasId = $szolgalatasId ";
    }

    $sql .= ";";

    $res = $connection->query($sql);
    if (!$res) {
        http_response_code(500);
    }

    $html = '<table class="table table-hover text-center">'
            . '<thead>'
            . '<tr>'
            . '<td>Időpont</td>'
            . '<td>Kezelő orvos</td>'
            . '<td>Szolgáltatás</td>'
            . '</tr>'
            . '</thead>'
            . '<tbody>';
    while ($row = $res->fetch_row()) {
        $html .= "<tr data-id = '$row[0]'>"
                . "<td>$row[1]</td>"
                . "<td>$row[2] $row[3] ($row[4])</td>"
                . "<td>$row[5]</td>"
                . "</tr>";
    }
    $html .= '</tbody>'
            . '</table>';

    echo $html;
}
