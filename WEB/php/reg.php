<?php

require_once '../config/connect.php';

$veznev = $_POST['veznev'];
$kernev = $_POST['kernev'];
$tajszam = $_POST['tajszam'];
$jelszo = $_POST['jelszo'];
$irszam = (int) $_POST['irszam'];
$telepules = $_POST['telepules'];
$lakcim = $_POST['lakcim'];
$telszam = $_POST['telszam'];
$email = $_POST['email'];

$errorMessage = "";

if (empty($tajszam) || empty($jelszo) || empty($veznev) || empty($kernev) ||
        empty($telepules) || empty($lakcim) || empty($email) || empty($telszam)) {
    $errorMessage = "Üres mezők!";
}

if (strlen($tajszam) != 11 && !strpos($tajszam, '-')) {
    $errorMessage .= "<br>Tajszám nem 11 karakter vagy nem tartalmaz kötőjelet!";
}

$sql = 'SELECT Taj FROM patient;';
$res = $connection->query($sql);

while ($row = $res->fetch_row()) {
    if ($row[0] === $tajszam) {
        die("Létező tajszám!");
    }
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
    echo "Helyes kitöltés!";

    $sql = 'INSERT INTO patient '
            . '(Taj, Jelszo, Vezeteknev, Keresztnev, Iranyitoszam, Telepules, Lakcim, Email, Telefon) '
            . 'VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?);';
    $stmt = $connection->prepare($sql);
    $stmt->bind_param('ssssissss', $tajszam, $jelszo, $veznev, $kernev, $irszam, $telepules, $lakcim, $email, $telszam);
    $stmt->execute();
    $stmt->close();
    $connection->close();
}
