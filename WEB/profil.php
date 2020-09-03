<?php

require_once 'config/init.php';

if (isset($_SESSION['error'])) {
    unset($_SESSION['error']);
}

if (!isset($_SESSION['taj'])) {
    header('Location: index.php');
}

require_once 'html/header.html';
printMenu();
printUser();

require_once 'html/profil_adatok.html';
require_once 'html/footer.html';
