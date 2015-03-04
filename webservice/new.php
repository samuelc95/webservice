<?php
include 'connect.php';
?>
<!DOCTYPE html>
<html>
  
  <head>
    <meta charset="utf-8">
    <title>Project Raul and Luís</title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="description" content="">
    <meta name="author" content="">
    <link href="http://netdna.bootstrapcdn.com/bootstrap/3.2.0/css/bootstrap.min.css"
    rel="stylesheet">
    <script type="text/javascript" src="http://cdnjs.cloudflare.com/ajax/libs/jquery/2.0.3/jquery.min.js"></script>
    <script type="text/javascript" src="http://netdna.bootstrapcdn.com/bootstrap/3.2.0/js/bootstrap.min.js"></script>
  </head>
  
	<body>

  	 	<br />
		<?php 
		
		$user = $_GET['user'];
		$pass = $_GET['pass'];
		$email = $_GET['email'];
		
		?>
		
		<form action="inserir.php" method="post" enctype="multipart/form-data">
  	 	<label>
            	<h5>Username</h5>
                <input class="input-large" type="text" placeholder="Username" name="username" maxlength="59" value="<?php echo $user; ?>" rows="5" required/>
            </label>
              
            <label>
            	<h5>Email</h5>
                <input class="input-large" type="text" placeholder="Email" name="email" maxlength="59" value="<?php echo $pass; ?>" rows="5" required />
            </label>
              
            <label>
            	<h5>Password</h5>
                <input class="input-large" type="password" placeholder="Password" name="password" maxlength="59" value="<?php echo $email; ?>" rows="5" required />
            </label>
          <br />  
            <input type="hidden" name="acao" value="enviar"/>
            <button class="btn btn-large" type="submit">Registar</button> 
  	 	
  	 	 </form>
		</br>
	</br>

<hr>
	<h1>Listar Utilizadores</h1>
</br>
</br>
		<?php
			include 'listar.php';
		?>
		
	</body>

</html>