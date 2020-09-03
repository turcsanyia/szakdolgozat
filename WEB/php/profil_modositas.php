<?php

require_once '../config/connect.php';
require_once '../config/init.php';

$tajszam = $_SESSION['taj'];
$veznev = $_POST['veznev'];
$kernev = $_POST['kernev'];
$jelszo = $_POST['jelszo'];
$irszam = (int) $_POST['irszam'];
$telepules = $_POST['telepules'];
$lakcim = $_POST['lakcim'];
$telszam = $_POST['telszam'];
$email = $_POST['email'];

$errorMessage = "";

if (empty($jelszo) || empty($veznev) || empty($kernev) ||
        empty($telepules) || empty($lakcim) || empty($email) || empty($telszam)) {
    $errorMessage = "Üres mezők!";
}

if (strlen($veznev) > 50 && strlen($kernev) > 50) {
    $errorMessage .= "<br>Vezetéknév vagy keresztnév nem lehet 50 karakternél hosszabb!";
}

if (ctype_lower(substr($veznev, 0, 1)) || ctype_lower(substr($kernev, 0, 1))) {
    $errorMessage .= "<br>Vezetéknév vagy keresztnév nem lehet kisbetűs!";
}

if (strlen($jelszo) > 11) {
    $errorMessage .= "<br>Jelszó hossza nem 11 karakter!";
}

if (strlen($irszam) != 4) {
    $errorMessage .= "<br>Irányítószám nem 4 karakter!";
}

if (ctype_lower(substr($telepules, 0, 1))) {
    $errorMessage .= "<br>Település nem lehet kisbetűs!";
}

if (ctype_lower(substr($lakcim, 0, 1))) {
    $errorMessage .= "<br>Lakcím nem lehet kisbetűs!";
}

if (!strpos($email, '@')) {
    $errorMessage .= "<br>E-mail nem tartalmaz @ karaktert!";
}

if (strlen($telszam) > 11) {
    $errorMessage .= "<br>Telefonszám 11 karakter lehet és csak számokat tartalmazaht!";
}

if ($errorMessage !== "") {
    echo $errorMessage;
    die();
} else {
    echo "Sikeres módosítás!";

    $sql = 'UPDATE patient SET Jelszo = ?, Vezeteknev = ?, Keresztnev = ?, '
            . 'Iranyitoszam = ?, Telepules = ?, Lakcim = ?, Email = ?, '
            . 'Telefon = ? '
            . 'WHERE Taj = ?;';
    $stmt = $connection->prepare($sql);
    $stmt->bind_param('sssisssss', $jelszo, $veznev, $kernev, $irszam, $telepules, $lakcim, $email, $telszam, $tajszam);
    $stmt->execute();
    $stmt->close();
    $connection->close();
}
