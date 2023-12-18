<?php 

require '../db.php';

error_reporting(0);
header('Access-Control-Allow-Origin:*');
header('Content-Type: application/json');
header('Access-Contro-Allow-Method: GET, POST, PUT, DELETE');
header('Access-Control-Allow-Headers: Content-Type, Access-Control-Allow-Headers, Authorization, X-Request-With');

$requestMethod = $_SERVER["REQUEST_METHOD"];

if($requestMethod == "GET"){
    
    if(isset($_GET['id'])){
        $car = getCar($_GET);
        echo json_encode($car);
    }
    else{
        $carList = getCarList();
        echo json_encode($carList, JSON_NUMERIC_CHECK);
    }
    

}
elseif($requestMethod == 'POST'){
    $inputData = json_decode(file_get_contents("php://input"), true);
    /*$user = checkLoggedIn($inputData["username"], $inputData["password"]);
	$admin = checkAdmIn($inputData["username"], $inputData["password"]);
	if(!$user or !$admin){
		return error422('You need to log in');
	}*/
    if(empty($inputData)){
        
        $storeCar = storeCar($_POST);
    }
    else{
        $storeCar = storeCar($inputData);
    }
    echo $storeCar;


}
elseif($requestMethod == 'PUT'){
    $inputData = json_decode(file_get_contents("php://input"), true);
    /*$user = checkLoggedIn($inputData["username"], $inputData["password"]);
	$admin = checkAdmIn($inputData["username"], $inputData["password"]);
	if(!$user or !$admin){
		return error422('You need to log in');
	}
    */
    $updateCar = updateCar($inputData, $_GET);
    echo $updateCar;
}
elseif($requestMethod == "DELETE"){
    $inputData = json_decode(file_get_contents("php://input"), true);
    /*$user = checkLoggedIn($inputData["username"], $inputData["password"]);
	$admin = checkAdmIn($inputData["username"], $inputData["password"]);
	if(!$user or !$admin){
		return error422('You need to log in');
	}*/
    $deleteCar = deleteCar($_GET);
    echo $deleteCar;
}
else{
    $data = [
        'status' => 405,
        'message' => $requestMethod. 'Method Not Allowed',        

    ];
    header("HTTP/1.0 405 Method Not Allowed");
    echo json_encode($data);
}

function getCarList(){
    global $con;

    $query = "SELECT * FROM cars";
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
                'message' => 'Car List Fetched Successfully',
                'data' => $res        
        
            ];
            header("HTTP/1.0 200 Car List Fetched Successfully");
            return json_encode($data, );
        }
        else{
            $data = [
                'status' => 404,
                'message' => 'No Car Found',        
        
            ];
            header("HTTP/1.0 404 No Car Found");
            return json_encode($data, JSON_NUMERIC_CHECK);

        }
        */
        

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

function getCar($carParams){

    global $con;

    if($carParams['id'] == null){
        return error422('Enter your car id');
    }

    $carId = mysqli_real_escape_string($con, $carParams['id']);

    $query = "SELECT * FROM cars WHERE id='$carId' LIMIT 1";
    $result = mysqli_query($con, $query);

    if($result){
        $array = [];
        while($row = mysqli_fetch_assoc($result)){
            $array[]= $row;
        }

        /*if(mysqli_num_rows($result) == 1){
            $res = mysqli_fetch_assoc($result);
            $data [
                'status' => 200,
                'message' => 'Car Fetched Successfully',    
                'data' => $res    
        
            ];
            header("HTTP/1.0 404 OK");
            return json_encode($data);
        }
        else{
            $data = [
                'status' => 404,
                'message' => 'No Car Found',        
        
            ];
            header("HTTP/1.0 404 No Car Found");
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

function error422($message){
    $data = [
        'status' => 422,
        'message' => $message,        

    ];
    header("HTTP/1.0 422 Unprocessable Entity");
    echo json_encode($data);
    exit();
}

function storeCar($carInput){
    global $con;

    $marka = mysqli_real_escape_string($con, $carInput['marka']);
    $tipus = mysqli_real_escape_string($con, $carInput['tipus']);
    $evjarat = mysqli_real_escape_string($con, $carInput['evjarat']);
    $kivitel = mysqli_real_escape_string($con, $carInput['kivitel']);
    $uzemanyag = mysqli_real_escape_string($con, $carInput['uzemanyag']);
    $ar = mysqli_real_escape_string($con, $carInput['ar']);

    if(empty(trim($marka))){
        return error422('Enter a brand name');
    }
    elseif(empty(trim($tipus))){
        return error422('Enter a type');
    }
    elseif(empty(trim($evjarat))){
        return error422('Enter the vintage');
    }
    elseif(empty(trim($kivitel))){
        return error422('Enter the design ');
    }
    elseif(empty(trim($uzemanyag))){
        return error422('Enter the fuel type');
    }
    elseif(empty(trim($ar))){
        return error422('Enter the price');
    }
    else{
        $queryInsert = "INSERT INTO cars (marka, tipus, evjarat, kivitel, uzemanyag, ar) VALUES ('$marka', '$tipus', '$evjarat', '$kivitel', '$uzemanyag', '$ar')";
        $resultInsert = mysqli_query($con, $queryInsert);

        if($resultInsert){
            $data = [
                'status' => 201,
                'message' => 'Car Inserted Successfully',        
        
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

function updateCar($carInput, $carParams){
    global $con;

    if(!isset($carParams['id'])){
        return error422("Car id not found in URL");
    }
    elseif($carParams['id'] == null){
        return error422("Enter the car id");
    }

    $carId = mysqli_real_escape_string($con, $carParams['id']);

    $marka = mysqli_real_escape_string($con, $carInput['marka']);
    $tipus = mysqli_real_escape_string($con, $carInput['tipus']);
    $evjarat = mysqli_real_escape_string($con, $carInput['evjarat']);
    $kivitel = mysqli_real_escape_string($con, $carInput['kivitel']);
    $uzemanyag = mysqli_real_escape_string($con, $carInput['uzemanyag']);
    $ar = mysqli_real_escape_string($con, $carInput['ar']);

    if(empty(trim($marka))){
        return error422('Enter a brand name');
    }
    elseif(empty(trim($tipus))){
        return error422('Enter a type');
    }
    elseif(empty(trim($evjarat))){
        return error422('Enter the vintage');
    }
    elseif(empty(trim($kivitel))){
        return error422('Enter the design ');
    }
    elseif(empty(trim($uzemanyag))){
        return error422('Enter the fuel type');
    }
    elseif(empty(trim($ar))){
        return error422('Enter the price');
    }
    else{
        $queryUpdate = "UPDATE cars SET marka='$marka', tipus='$tipus', evjarat='$evjarat', kivitel='$kivitel', uzemanyag='$uzemanyag', ar='$ar' WHERE id='$carId' LIMIT 1";
        $resultUpdate = mysqli_query($con, $queryUpdate);

        if($resultUpdate){
            $data = [
                'status' => 200,
                'message' => 'Car Updated Successfully',        
        
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

function deleteCar($carParams){
    global $con;

    if(!isset($carParams['id'])){
        return error422("Car id not found in URL");
    }
    elseif($carParams['id'] == null){
        return error422("Enter the car id");
    }

    $carId = mysqli_real_escape_string($con, $carParams['id']);

    $queryDelete = "DELETE FROM cars WHERE id='$carId' LIMIT 1";
    $resultDelete = mysqli_query($con, $queryDelete);

    if($resultDelete){
        $data = [
            'status' => 200,
            'message' => 'Car Deleted Successfully',        
    
        ];
        header("HTTP/1.0 200 OK");
        return json_encode($data);
    }
    else{
        $data = [
            'status' => 404,
            'message' => 'Car Not Found',        
    
        ];
        header("HTTP/1.0 404 Car Not Found");
        return json_encode($data);
    }



}

?>