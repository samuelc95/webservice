<?php
include 'connect.php';

		if(isset($_POST['acao']) && $_POST['acao']=='enviar' && isset($_POST['email']) && $_POST['email']!="" && isset($_POST['username']) && $_POST['username']!="" && isset($_POST['password']) && $_POST['password']!="" ){
			
$email=$_POST['email'];
$username=$_POST['username'];
$password=$_POST['password'];
 
#//retirando espaços
   $username=trim($username);
   $email=trim($email);
   $password=trim($password);
 
  $erro=0;
  

 
#//verificar se há email cadastrado no BD
   $s=mysql_query("SELECT * FROM utilizadores WHERE email='$email'")or die(mysql_error());
   $mnr=mysql_num_rows($s);
 
if($mnr!=0){ 
					echo "<div class='alert'>";
					echo "Email já registado!";
					echo "</div>"; 
					$erro++; }
 
#//se não encontrar @
   function validaEmail($email){
	if(preg_match("/^([[:alnum:]_.-]){3,}@([[:lower:][:digit:]_.-]{3,})(\.[[:lower:]]{2,3})(\.[[:lower:]]{2})?$/", $email)) {
		return true;
	}else{
		echo "<div class='alert'>";
		echo "Email inválido!";
		echo "</div>";
   $erro++; }
}
   
 
 
#//verificar se campo nome foi inserido
  
 
 
if($erro==0){
#//inserir no banco de dados se tudo for OK
   $i=mysql_query("INSERT INTO utilizadores (user, email, password) VALUES ('$username','$email','$password')")or die(mysql_error());
		echo "<div class='success'>";
		echo "Registo Efectuado com Sucesso!";
		echo "</div>";
		echo "<a href='index.php'><h5>Cliqeu aqui para ver a lista de utilizadores já inseridos</h5></a>";
		
	
}
}
?>