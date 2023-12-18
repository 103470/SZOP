<?php 

require '../db.php';
include '../check.php';

error_reporting(0);
header('Access-Control-Allow-Origin:*');
header('Content-Type: application/json');
header('Access-Contro-Allow-Method: GET, POST, PUT, DELETE');
header('Access-Control-Allow-Headers: Content-Type, Access-Control-Allow-Headers, Authorization, X-Request-With');

$requestMethod = $_SERVER["REQUEST_METHOD"];

if($requestMethod == "GET"){
    
    if(isset($_GET['id'])){
        $user = getUser($_GET);
        echo json_encode($user, JSON_NUMERIC_CHECK);
    }
    else{
        $userList = getUserList();
        echo json_encode($userList, JSON_NUMERIC_CHECK);
    }
    

}
elseif($requestMethod == 'POST'){
    $inputData = json_decode(file_get_contents("php://input"), true);
    $user = checkLoggedIn($inputData["username"], $inputData["password"]);
	$admin = checkAdmIn($inputData["username"], $inputData["password"]);
	if(!$user or !$admin){
		return error422('You need to log in');
	}
    if(empty($inputData)){
        
        $storeUser = storeUser($_POST);
    }
    else{
        $storeUser = storeUser($inputData);
    }
    echo $storeUser;


}
elseif($requestMethod == 'PUT'){
    $inputData = json_decode(file_get_contents("php://input"), true);
    $user = checkLoggedIn($inputData["username"], $inputData["password"]);
	$admin = checkAdmIn($inputData["username"], $inputData["password"]);
	if(!$user or !$admin){
	    return error422('You need to log in');
	}
    $updateUser = updateUser($inputData, $_GET);
    echo $updateUser;
}
elseif($requestMethod == "DELETE"){
    $inputData = json_decode(file_get_contents("php://input"), true);
    $user = checkLoggedIn($inputData["username"], $inputData["password"]);
	$admin = checkAdmIn($inputData["username"], $inputData["password"]);
	if(!$user or !$admin){
		return error422('You need to log in');
	}
    $deleteUser = deleteUser($_GET);
    echo $deleteUser;
}
else{
    $data = [
        'status' => 405,
        'message' => $requestMethod. 'Method Not Allowed',        

    ];
    header("HTTP/1.0 405 Method Not Allowed");
    echo json_encode($data);
}

function error422($message){
    $data = [
        'status' => 422,
        'message' => $message,        

    ];
    header("HTTP/1.0 422 Unprocessable Entity");
    echo json_encode($data);
    exit();
}


function getUserList(){
    global $con;

    $query = "SELECT * FROM users";
    $query_run = mysqli_query($con, $query);

    if($query_run){
        $array = [];
        while ($row = mysqli_fetch_assoc($query_run)) {
            $array[] = $row;
        }
    
        return $array;

        /*if(mysqli_num_rows($query_run) > 0){
            $res = mysqli_fetch_all($query_run, MYSQLI_ASSOC);
            $data = [
                'status' => 200,
                'message' => 'User List Fetched Successfully',
                'data' => $res        
        
            ];
            header("HTTP/1.0 200 User List Fetched Successfully");
            return json_encode($data);
        }
        else{
            $data = [
                'status' => 404,
                'message' => 'No User Found',        
        
            ];
            header("HTTP/1.0 404 No User Found");
            return json_encode($data);

        }*/

    }
    else{
        $data = [
            'status' => 500,
            'message' => 'Internal Server Error',        
    
        ];
        header("HTTP/1.0 500 Internal Server Error");
        return json_encode($data);
    }
}

function getUser($userParams){

    global $con;

    if($userParams['id'] == null){
        return error422('Enter your user id');
    }

    $userId = mysqli_real_escape_string($con, $userParams['id']);

    $query = "SELECT * FROM users WHERE id='$userId' LIMIT 1";
    $result = mysqli_query($con, $query);

    if($result){
        $array = [];
        while ($row = mysqli_fetch_assoc($result)) {
            $array[] = $row;
        }
    
        return json_encode($array);

        /*if(mysqli_num_rows($result) == 1){
            $res = mysqli_fetch_assoc($result);
            $data = [
                'status' => 200,
                'message' => 'User Fetched Successfully',    
                'data' => $res    
        
            ];
            header("HTTP/1.0 404 OK");
            return json_encode($data);
        }
        else{
            $data = [
                'status' => 404,
                'message' => 'No User Found',        
        
            ];
            header("HTTP/1.0 404 No User Found");
            return json_encode($data);
        }*/

    }
    else{
        $data = [
            'status' => 500,
            'message' => 'Internal Server Error',        
    
        ];
        header("HTTP/1.0 500 Internal Server Error");
        return json_encode($data);
    }
}

function storeUser($userInput){
    global $con;

    $username = mysqli_real_escape_string($con, $userInput['username']);
    $password = mysqli_real_escape_string($con, md5($userInput['password']));
    $name = mysqli_real_escape_string($con, $userInput['name']);
    $isAdmin = 0;
    
    if(empty(trim($username))){
        return error422('Enter your username');
    }
    elseif(empty(trim($password))){
        return error422('Enter your password');
    }
    elseif(empty(trim($name))){
        return error422('Enter your name');
    }
    else{
        $queryInsert = "INSERT INTO users (username, password, name, isAdmin) VALUES ('$username', '$password', '$name', '$isAdmin')";
        $resultInsert = mysqli_query($con, $queryInsert);

        if($resultInsert){
            $data = [
                'status' => 201,
                'message' => 'User Inserted Successfully',        
        
            ];
            header("HTTP/1.0 201 Created");
            return json_encode($data);
        }
        else{
            $data = [
                'status' => 500,
                'message' => 'Internal Server Error',        
        
            ];
            header("HTTP/1.0 500 Internal Server Error");
            return json_encode($data);
        }
    }

}

function updateUser($userInput, $userParams){
    global $con;

    if(!isset($userParams['id'])){
        return error422("User id not found in URL");
    }
    elseif($userParams['id'] == null){
        return error422("Enter the user id");
    }

    $userId = mysqli_real_escape_string($con, $userParams['id']);

    $username = mysqli_real_escape_string($con, $userInput['username']);
    $password = mysqli_real_escape_string($con, md5($userInput['password']));
    $name = mysqli_real_escape_string($con, $userInput['name']);
    $isAdmin = mysqli_real_escape_string($con, $userInput['isAdmin']);
   
    if(empty(trim($username))){
        return error422('Enter your username');
    }
    elseif(empty(trim($password))){
        return error422('Enter your password');
    }
    elseif(empty(trim($name))){
        return error422('Enter your name');
    }
    elseif($isAdmin == null){
        return error422('Give us the permmission');
    }
    elseif($isAdmin != 0 or $isAdmin != 1){
        return error422('isAdmin can only be 0 or 1');
    }
    else{
        $queryUpdate = "UPDATE users SET username='$username', password='$password', name='$name', isAdmin='$isAdmin' WHERE id='$userId' LIMIT 1";
        $resultUpdate = mysqli_query($con, $queryUpdate);

        if($resultUpdate){
            $data = [
                'status' => 200,
                'message' => 'User Updated Successfully',        
        
            ];
            header("HTTP/1.0 200 OK");
            return json_encode($data);
        }
        else{
            $data = [
                'status' => 500,
                'message' => 'Internal Server Error',        
        
            ];
            header("HTTP/1.0 500 Internal Server Error");
            return json_encode($data);
        }
    }
}

function deleteUser($userParams){
    global $con;

    if(!isset($userParams['id'])){
        return error422("User id not found in URL");
    }
    elseif($userParams['id'] == null){
        return error422("Enter the user id");
    }

    $userId = mysqli_real_escape_string($con, $userParams['id']);

    $queryDelete = "DELETE FROM users WHERE id='$userId' LIMIT 1";
    $resultDelete = mysqli_query($con, $queryDelete);

    if($resultDelete){
        $data = [
            'status' => 200,
            'message' => 'User Deleted Successfully',        
    
        ];
        header("HTTP/1.0 200 OK");
        return json_encode($data);
    }
    else{
        $data = [
            'status' => 404,
            'message' => 'User Not Found',        
    
        ];
        header("HTTP/1.0 404 User Not Found");
        return json_encode($data);
    }



}
?>