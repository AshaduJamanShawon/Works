
<?php

      	require_once '../model/model.php';

if (isset($_POST['UpdateUser'])) {

	$email= $_POST['email'];
	$name = $_POST['name'];
	$address = $_POST['add'];
	$phonenumber = $_POST['pn'];
	
	$pass = $_POST['password'];
	
	
  if (UpdateUser($name,$email,$address,$phonenumber,$pass)) {

  	 header( 'Location:../UserLogin.php');
  	//echo 'Successfully updated!!';
  	
} else {
	echo 'You are not allowed to access this page.';
}
}


 
 ?> 


 
                    

















 
