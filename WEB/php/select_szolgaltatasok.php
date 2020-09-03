<?php

require_once '../config/connect.php';

$sql = 'SELECT Id, Nev '
        . 'FROM service '
        . 'ORDER BY Nev ASC;';
$res = $connection->query($sql);

if (!$res) {
    http_response_code(500);
}

$html = '<select class="szolgaltatas-szures form-control">'
        . '<option data-id="0">Kérem válasszon...</option>';
while ($row = $res->fetch_row()) {
    $html .= "<option data-id='$row[0]'>$row[1]</option>";
}
$html .= '</select>';

echo $html;
