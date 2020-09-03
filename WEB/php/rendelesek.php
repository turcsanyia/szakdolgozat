<?php

require_once '../config/connect.php';
require_once '../config/init.php';

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
    AND visit.BetegTaj = ?";
$stmt = $connection->prepare($sql);
$stmt->bind_param('s', $taj);
$stmt->execute();
$stmt->store_result();
$stmt->bind_result($visitId, $visitIdopont, $doctorVezeteknev, $doctorKeresztnev, $szakteruletNev, $szolgalatasNev);

$html = '<table class="table table-hover text-center">'
        . '<thead>'
        . '<tr>'
        . '<td>Időpont</td>'
        . '<td>Kezelő orvos</td>'
        . '<td>Szolgáltatás</td>'
        . '</tr>'
        . '</thead>'
        . '<tbody>';
while ($row = $stmt->fetch()) {
    $html .= "<tr data-id='$visitId'>"
            . "<td>$visitIdopont</td>"
            . "<td>$doctorVezeteknev $doctorKeresztnev ($szakteruletNev)</td>"
            . "<td>$szolgalatasNev</td>"
            . "</tr>";
}
$html .= '</tbody>'
        . '</table>';

echo $html;
