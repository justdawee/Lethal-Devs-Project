<?php
/* Database credentials. Assuming you are running MySQL
server with default setting (user 'root' with no password) */
define('DB_SERVER', 'localhost');
define('DB_USERNAME', 'root');
define('DB_PASSWORD', '');
define('DB_NAME', 'vms_lethaldevs');
 
/* Attempt to connect to MySQL database */
$mysqli = new mysqli(DB_SERVER, DB_USERNAME, DB_PASSWORD, DB_NAME);
 
// Check connection
if($mysqli === false){
    die("ERROR: Could not connect. " . $mysqli->connect_error);
}

//password hash methods
function encrypt($password)
{
	$salt = 's3cr3t';
	$method = 'aes-256-cbc';
	$salt = substr(hash('sha256', $salt, true), 0, 32);
	$iv = chr(0x0) . chr(0x0) . chr(0x0) . chr(0x0) . chr(0x0) . chr(0x0) . chr(0x0) . chr(0x0) . chr(0x0) . chr(0x0) . chr(0x0) . chr(0x0) . chr(0x0) . chr(0x0) . chr(0x0) . chr(0x0);
	$encrypted = base64_encode(openssl_encrypt($password, $method, $salt, OPENSSL_RAW_DATA, $iv));
	return $encrypted;
}

function decrypt($password)
{
	$salt = 's3cr3t';
	$method = 'aes-256-cbc';
	$salt = substr(hash('sha256', $salt, true), 0, 32);
	$iv = chr(0x0) . chr(0x0) . chr(0x0) . chr(0x0) . chr(0x0) . chr(0x0) . chr(0x0) . chr(0x0) . chr(0x0) . chr(0x0) . chr(0x0) . chr(0x0) . chr(0x0) . chr(0x0) . chr(0x0) . chr(0x0);
	$decrypted = openssl_decrypt(base64_decode($password), $method, $salt, OPENSSL_RAW_DATA, $iv);
	return $decrypted;
}

?>