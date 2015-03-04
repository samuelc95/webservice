<?php

$dbname = 'webservice';
//conex�o com o servidor
$connect = mysql_connect('localhost', 'root', '');

// Caso a conex�o seja reprovada, exibe na tela uma mensagem de erro
if (!$connect) die ('<h1>Falha na conexão com o Banco de Dados!</h1>');

// Caso a conex�o seja aprovada, ent�o conecta o Banco de Dados.	
$db = mysql_select_db($dbname, $connect) or die('Could not select databasename');
?>