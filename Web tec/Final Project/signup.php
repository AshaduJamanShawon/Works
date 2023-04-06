<?php
$error=$_REQUEST['err'];
?>

 <!DOCTYPE html>  
 <html>  
 <head>  

           <title>Registration</title> 


  <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
           
     </head>  
      <body class="bg-warning col-lg-11.5 m-4">  
        

   
           <br />  
           
                <h3 class="text-center col-lg-11.5  bg-success">Registration</h3>    

                 
                    <form name="signup" action="controller/createUser.php" method="POST" enctype="multipart/form-data">
                   

                    <div class="container" style="width:400px;"> 
                    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css" /> 
                     <?php     
                     if(isset($error))  
                     {  
                          echo $error;  
                     }  
                     ?> 

                     <br /> 

                     <label>Name</label>  
                     <input type="text" name="fname" class="form-control" placeholder="Enter your Name,only letter"  /><br />  

                    

                     <label>E-mail</label>
                     <input type="text" name = "email" class="form-control" placeholder="Enter your Email"  /><br />

                     <label>Address</label>
                     <input type="text" name = "add" class="form-control" placeholder="Enter your Address"  /><br />


                     <label>Phone Number</label>
                     <input type="Number" name = "pnumber" class="form-control" placeholder="Enter your Phone number" /><br />

                    <legend>Date of Birth:</legend>
                     <input type="date" name="dob" > <br><br>
                   
                    
                <fieldset>
                    <legend>Gender</legend>
                    <input type="radio" id="male" name="gender" value="male" >
                     <label for="male">Male</label>                     
                     <input type="radio" id="female" name="gender" value="female">
                     <label for="female">Female</label>
                     <input type="radio" id="other" name="gender" value="other">
                     <label for="other">Other</label><br>
                        </fieldset>
                     
                     <label>Password</label>
                     <input type="password" name = "np1" class="form-control" placeholder="Must be 8 digit"  /><br />
                   
                     <label>Confirm Password</label>
                     <input type="password" name = "rp1" class="form-control" placeholder="Enter same Password" /><br />

                     <input type="submit" name="createUser" value="creat" class="btn btn-info" /><br />                      
                   
                

                </form>  
           </div>  
           <br />  
      </body>  
 </html>  
