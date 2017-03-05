<html> 
<body> 
<?php
$to="priyankachoudhary88888@gmail.com";
$subject="Movie Request";
$email=$_REQUEST['email'];
$message=$_REQUEST['message'];
$headers="From:$email";
$sent=mail($to, $subject, $message, $headers); 
if($sent) 
{print ('<a href="#" > Thank you for your feedback! 
Click here to return to homepage </a>');} 
else  
{ print"We encountered an error!"; 
	} 
	?>
	
</body>
</body>