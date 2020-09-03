<?php

require_once '../config/connect.php';

if (isset($_POST['taj']) && isset($_POST['password'])) {
    $taj = $_POST['taj'];
    $password = $_POST['password'];

    $sql = "SELECT Taj, Vezeteknev, Keresztnev FROM patient "
            . "WHERE Taj = ? AND Jelszo = ?;";

    $stmt = $connection->prepare($sql);
    $stmt->bind_param('ss', $taj, $password);
    $stmt->execute();
    $stmt->store_result();

    if ($stmt->num_rows == 1) {
        $stmt->bind_result($taj, $vezeteknev, $keresztnev);
        $stmt->fetch();

        session_start();
        $_SESSION['taj'] = $taj;
        $_SESSION['vezeteknev'] = $vezeteknev;
        $_SESSION['keresztnev'] = $keresztnev;

        $stmt->close();
        $connection->close();

        http_response_code(200);
    } else {
        $stmt->close();
        $connection->close();

        http_response_code(401);
    }
}
