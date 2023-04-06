
<?php  

 $message = '';  
 $error = '';  
 require('../model/model.php');
 if(isset($_REQUEST['createUser']))  
 {  
      if (!preg_match("/^[a-zA-Z-' ]*$/",($_POST["fname"])))  
      {  
           $error = "<label class='text-danger'>Name,Only use letter.</label>";  
      }
      

      else if (!filter_var(($_POST["email"]), FILTER_VALIDATE_EMAIL)) 
      {  
           $error = "<label class='text-danger'>Enter an valide e-mail</label>";  
      } 
      else if(empty($_POST["add"]))  
      {  
           $error = "<label class='text-danger'>Enter Your address</label>";  
      }

      else if(empty($_POST["pnumber"]))  
      {  
           $error = "<label class='text-danger'>Enter Phone Number</label>";  
      }


     else if(empty($_POST["np1"]))  
      {  
           $error = "<label class='text-danger'>Enter a Password</label>";  
      }  

      elseif((strlen($_POST["np1"]))<8){

       $error="<label class='text-danger'>Password,Must enter 8 digit</label>";
     }


      else if(empty($_POST["rp1"]))  
      {  
           $error = "<label class='text-danger'>password is required</label>";  
      }  

      else if(($_POST["rp1"])!=($_POST["np1"]))
     {
          $error = "<label class='text-danger'>Same password is required</label>"; 

      }
      else if (empty($_REQUEST["dob"]) ) 
       {
          $error = "<label class='text-danger'>Date Of Birt is required</label>";  
       } 
      else if(empty($_POST["gender"]))  
      {  
           $error = "<label class='text-danger'>Gender cannot be empty</label>";  
      } 
       
      else  
      {


   $data['Name']=$_POST["fname"];
   $data['Email']=$_POST["email"];
   $data['Address']=$_POST["add"];
   $data['PN']=$_POST["pnumber"];
   $data['Dob']=$_POST["dob"];
   $data['Gender']=$_POST["gender"];
   $data['Password']=$_POST["np1"];

      
  if (signup($data)) {

    header( 'Location:../UserLogin.php');
  }
   else {
   echo 'e1';
  }
} 
}
else{
   echo "e2";

} 
 

 
 ?> 


 <?php  
                     if(isset($message))  
                     {  
                          echo $message;  
                     }  
                     ?>  

                     <?php   
                     if(isset($error))  
                     {  
                         // echo $error; 
                            header( 'Location:../signup.php?err='.$error);
                     }  
                     ?>



















                 