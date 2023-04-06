
<?php
session_start();
  require_once '../model/model.php';

if (isset($_SESSION['uemail'])) {

	$email= $_SESSION['uemail'];
	
	
  if ( delete($email)) {

  	echo 'Successfully Delete!!';
  	
} else {
	echo 'You are not allowed to access this page.';
}
}


 
 ?> 

 <!DOCTYPE html>  
 <html>  
      <head>  
  <title>Edit Profile</title> 
  <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
           
     </head>  
      <body class="bg-warning col-lg-11.5 m-4">  
        

   
           <br />  
           

                <button class="btn-block  btn-outline-primary"action="UserLogin.php" > done</button>
 
               

      </body>  
 </html>  

 
                    

















 
