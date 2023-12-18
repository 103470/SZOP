<?php

function checkLoggedIn($username, $password) {
	global $con;
	
	$result = $con -> query("SELECT id, username, password, name, isAdmin FROM users WHERE username = '$username' AND password = '$password'");
	
	return $result->fetch_all(MYSQLI_ASSOC);
}
function checkAdmIn($username, $password) {
	global $con;
	
	$result = $con -> query("SELECT id, username, password, name, isAdmin FROM users WHERE username = '$username' AND password = '$password' AND isAdmin=1");
	
	return $result->fetch_all(MYSQLI_ASSOC);
}
?>