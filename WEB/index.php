<?php

require_once 'config/init.php';

require_once 'html/header.html';
printMenu();

if (isset($_SESSION['error'])) {
    echo $_SESSION['error'];
}

require_once './html/index_content.html';
require_once 'html/footer.html';
