<?php 

$port = $_SERVER['WEBSITE_MYSQL_PORT'];
$server = "localhost:$port";
$user = "azure";
$password = "6#vWHD_$";
$db = "localdb";

$mysql = new mysqli($server ,$user, $password, $db);

if($mysqli -> connect_error){
    echo "Error en la Conexion MYSQL:" .$mysqli -> connect_error;
    exit();
}

if ($result = $mysqli -> query("SELECT * FROM SOPORTE_PERSONA")){

    echo "Las Columnas:" .$result-> num_rows();
    $result -> free_result();
}
$mysqli -> close();
?>