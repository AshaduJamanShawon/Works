
 <!DOCTYPE html>  
 <html>  
      <head>  
  <title>Edit Profile</title> 
  <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
  <script>       
function validate1() {
  let x = document.forms["update"]["email"].value;
  if (x == "") {
    alert("Email must be filled out");
    return false;
  }
}

function validate2() {
  let y = document.forms["update"]["pn"].value;
  if (y == "") {
    alert("Password must be filled out");
    return false;
  }
}

function validate3() {
  let x = document.forms["update"]["name"].value;
  if (x == "") {
    alert("Name must be filled out");
    return false;
  }
}

function validate4() {
  let y = document.forms["update"]["add"].value;
  if (y == "") {
    alert("Address must be filled out");
    return false;
  }
}
function validate5() {
  let y = document.forms["update"]["pass"].value;
  if (y == "") {
    alert("Phone Number must be filled out");
    return false;
  }
}
</script>


     </head>  
      <body class="bg-warning col-lg-11.5 m-4">  
        

   
           <br />  
           
                <h3 class="text-center col-lg-11.5  bg-success">Update Information</h3>


                 
                   <form name="update" action="controller/UpdateUser.php" method="POST" enctype="multipart/form-data"onsubmit="return validate1(),validate2(),validate3(),validate4(),validate5()">
                    <div class="container" style="width:400px;"> 
                    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css" />
 <?php     
                     if(isset($error))  
                     {  
                          echo $error;  
                     }  
                     ?> 

                     <br /> 

<label for="email">Email:</label><br>
  <input  type="email"  name="email" placeholder="Enter your Current Email"><br>

  <label for="name">Name:</label><br>
  <input  type="text"  name="name" placeholder="Enter your New Name"><br>

  <label for="add">Address:</label><br>
  <input type="text" name="add" placeholder="Enter your New Address"><br>


  <label for="pn">Phone Number:</label><br>
  <input type="text" name="pn" placeholder="Enter your New Phone Number"><br>
  
  <label for="pass">Password:</label><br>
  <input type="text" name="password" placeholder="Enter your New Password"><br>
  <input type="submit" name = "UpdateUser" value="Update">
  <input type="reset"> 
       

                    

                </form>  
             
           </div>  
           <br />  
      </body>  
 </html>  
