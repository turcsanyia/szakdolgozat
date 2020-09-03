<?php

require_once '../config/connect.php';
require_once '../config/init.php';

$taj = $_SESSION['taj'];

$sql = "SELECT * FROM patient WHERE Taj = '$taj'";
$res = $connection->query($sql);

if (!$res) {
    http_response_code(404);
}

$html = "<input name='tajszam' class='form-control' type='text' value='$taj' disabled>";
while ($row = $res->fetch_row()) {
    $html .= ''
            . "<input name='jelszo' placeholder='Jelszó' class='form-control mt-3' type='password' value='$row[1]'>"
            . "<input name='veznev' placeholder='Vezetéknév' class='form-control mt-3' type='text' value='$row[2]'>"
            . "<input name='kernev' placeholder='Keresztnév' class='form-control mt-3' type='text' value='$row[3]'>"
            . "<input name='irszam' placeholder='Irányítószám' class='form-control mt-3' type='text' value='$row[4]'>"
            . "<input name='telepules' placeholder='Település' class='form-control mt-3' type='text' value='$row[5]'>"
            . "<input name='lakcim' placeholder='Lakcím' class='form-control mt-3' type='text' value='$row[6]'>"
            . "<input name='email' placeholder='E-mail cím' class='form-control mt-3' type='text' value='$row[7]'>"
            . "<input name='telszam' placeholder='Telefonszám' class='form-control mt-3' type='text' value='$row[8]'>";
}
echo $html;
