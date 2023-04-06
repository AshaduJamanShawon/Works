<?php


session_start();

require_once '../model/db_connect.php';
$conn = db_conn();

$sql = "SELECT * FROM user where Email= :email AND Password= :password";
$statement =$conn->prepare($sql);
$statement->execute(
array(
'email' => $_POST['email'],
'password'=> $_POST['password']
)
);

$count =$statement->rowCount();

if($count>0)
{ 
 

  $stmt = $conn->prepare("SELECT *  FROM user");
   $stmt->execute();

    // set the resulting array to associative
    $result = $stmt->setFetchMode(PDO::FETCH_ASSOC);

foreach($stmt as list("Name"=>$name,"Email"=>$mail,"Address"=>$add,"PN"=>$pn,"Gender"=>$gn,"Dob"=>$dob,"Password"=>$pass))  
                          {  

                          if($_POST["email"] == $mail && $_POST["password"] == $pass)

                         {
                            
                     
                         $_SESSION['uname']=  $name; 
                         $_SESSION['uemail']=  $mail; 
                         $_SESSION['uadd']=  $add; 
                         $_SESSION['upn']=  $pn; 
                         $_SESSION['upass']=  $pass; 
                         $_SESSION['udob']=  $dob;   
                         $_SESSION['ugn']=  $gn;                           
                      }
                      else{
                        echo "error";
                      }
                    }


$_SESSION['uemail']=$_POST['email']; 

                       
  header( 'Location:../homepage.php');
}
    
else
{
 

echo '<div class="col-lg-12 m-5 text-danger text-uppercase" style="text-align:center;"> " Incorrect Password or Email Address" </div>';
  
}

?>

<html>
<head>
  <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
  </head>
  <body>
 <div class="col-lg-12 m-5" style="text-align:center;">   


 <a href="../UserLogin.php"><button class="btn btn-outline-primary" >Try Again</button></a>


 </div>
</body>

</html>
