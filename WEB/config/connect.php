<?php

$connection = new mysqli('127.0.0.1:3306', 'root', '', 'medi_2020');

if ($connection->errno) {
    die("Hiba az adatbázis csatlakozásban!");
}

if (!$connection->set_charset('utf8')) {
    die("Hiba a karakter kódolás beállításban!");
}
