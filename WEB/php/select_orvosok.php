<?php

require_once '../config/connect.php';

$sql = 'SELECT doctor.Id, doctor.Vezeteknev, doctor.Keresztnev, specialization.Nev '
        . 'FROM doctor, specialization '
        . 'WHERE doctor.SzakteruletId = specialization.Id '
        . 'ORDER BY doctor.Vezeteknev ASC;';
$res = $connection->query($sql);

if (!$res) {
    http_response_code(500);
}

$html = '<select class="orvos-szures form-control">'
        . '<option data-id="0">Kérem válasszon...</option>';
while ($row = $res->fetch_row()) {
    $html .= "<option data-id='$row[0]'>$row[1] $row[2] ($row[3])</option>";
}
$html .= '</select>';

echo $html;
