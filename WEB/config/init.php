<?php

session_start();

function printMenu() {
    if (isset($_SESSION['taj'])) {
        echo file_get_contents('html/navbar_in.html');
    } else {
        echo file_get_contents('html/navbar_out.html');
    }
}

function printUser() {
    echo "<p>Bejelentkezve mint: {$_SESSION['vezeteknev']} "
    . "{$_SESSION['keresztnev']} "
    . "({$_SESSION['taj']})</p>";
}
