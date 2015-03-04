<?php
include 'connect.php';

$hausers = false;
			 
			 $pag = (isset($_GET['pag'])) ? strip_tags((int)$_GET['pag']) : '1';
					$maximo = '5';
					$inicio = ($pag * $maximo) - $maximo;
											
								$query_listar_users = mysql_query("SELECT * FROM utilizadores ORDER BY id_user DESC LIMIT $inicio, $maximo ") or die (mysql_error());
										
								if(mysql_num_rows($query_listar_users) > 0){
									$hausers = true;
								}
			 

				
				?>

<table border="1">
<tr>
<th>User</th>
<th>Email</th>
<th>Password</th>
	<?php 
			  if (!$hausers) {
				  echo 'Não foram encontrados utilizadores na base de dados!';
			  }
			else{
			while($listarUsers = mysql_fetch_array($query_listar_users)){
		?>
<tr>
<td><?php echo substr($listarUsers['user'],0,50);?></td>
<td><?php echo substr($listarUsers['email'],0,50);?></td>
<td><?php echo substr($listarUsers['password'],0,50);?></td>
</tr>
	<?php } }?>

</table>