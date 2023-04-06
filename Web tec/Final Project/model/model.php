<?php 

require_once 'db_connect.php';


function signup($data){
	$conn = db_conn();


    $sql = "INSERT INTO user(Name, Email, Address, PN,Dob, Gender ,Password)
VALUES (:Name, :Email, :Address, :PN,:Dob,:Gender, :Password)";
    try{
        $stmt = $conn->prepare($sql);
        $stmt->execute([

  ':Name' => $data['Name'],
  ':Email' => $data['Email'],
  ':Address' => $data['Address'],
   ':PN' =>$data['PN'],
    ':Dob' => $data['Dob'],
  ':Gender' => $data['Gender'],
':Password' => $data['Password'],

        ]);
    }catch(PDOException $e){
        echo $e->getMessage();
    }
    
    $conn = null;
    return true;
}









function UpdateUser($name,$email,$address,$phonenumber,$pass){
$conn = db_conn();

$sql = "update user SET Name=?, Address=?,PN=?,Password=? where Email= ? ";

    try{
        $stmt = $conn->prepare($sql);
        $stmt->execute([
           $name,$address ,$phonenumber, $pass , $email
        ]);
    }catch(PDOException $e){
        echo $e->getMessage();
    }
    
    $conn = null;
    return true;
}




function delete($email){
$conn = db_conn();
$sql = "delete from user where Email =?";
 try{
        $stmt = $conn->prepare($sql);
        $stmt->execute([
           $email
        ]);
    }catch(PDOException $e){
        echo $e->getMessage();
    }
    
    $conn = null;
    return true;
}