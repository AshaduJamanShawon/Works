<?php 
function db_conn()
{
    $dbhost ="localhost";
    $username = "root";
    $password = "";
    $dbname="final_project";
    

    try {
        $dsn= "mysql:host=".$dbhost.";dbname=".$dbname;

        $conn = new PDO($dsn, $username, $password);
             $conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
      
       
    } catch (PDOException $e) {
        echo $e->getMessage();
    }
    return $conn;
}
