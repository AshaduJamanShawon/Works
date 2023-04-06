<?php
                           
/*
 $message = '';  
 $error = '';  
 if(isset($_POST["submit"]))  
 {  
      if (!filter_var(($_POST["email"]), FILTER_VALIDATE_EMAIL)) 
      {  
           $error = "<label class='text-danger'>Enter an valid E-mail</label>";  
      } 
      
        else if(empty($_POST["password"]))  
      {  
           $error = "<label class='text-danger'>Enter a Password</label>";  
      }  

      else  
      {

echo "";


      }
    }
    */

?>



<html>
<head>
<script>
function validateForm() {
  let x = document.forms["login"]["email"].value;
  if (x == "") {
    alert("Email must be filled out");
    return false;
  }
}

function validateForm1() {
  let y = document.forms["login"]["password"].value;
  if (y == "") {
    alert("Password must be filled out");
    return false;
  }
}


</script>

  <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">

</head>
<body class="bg-warning col-lg-12 m-4">

  
<h2 class="text-center col-lg-11.5 bg-success" style="text-align:center;">User LoGin</h2></br>


<form name="login" action="controller/login.php"  method="POST" enctype="multipart/form-data" onsubmit="return validateForm(),validateForm1()">
 
 

 <div class="container" style="width:400px;"> 
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css" />  

    Email: <input type="text" name="email" class="form-control" placeholder="Enter your Email">
  <br><br>
  
  Password: <input type="password" name="password" class="form-control"placeholder="Enter your Password"> 
  <br><br>
 <div style="text-align:center;">

 <input  type="submit" name="submit" value="Submit" class="btn btn-info" >    <a href="UserPassForget.php">forget password</a>
</div>
 <div style="text-align:center;">
 <a href="signup.php">create an account</a>
</div>

<?php  
                     if(isset($message))  
                     {  
                          echo $message;  
                     }  
                     ?>  

                     <?php   
                     if(isset($error))  
                     {  
                          echo $error;  
                     }  
                     ?>
  

</form>



</div>
</body>
</html>

