<?php

require_once 'config/init.php';

if (isset($_SESSION['taj'])) {
    header('Location: index.php');
}

require_once 'html/header.html';
printMenu();
require_once 'html/reg_form.html';
require_once 'html/footer.html';
