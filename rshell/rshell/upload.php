<?php
$file = $_FILES[0]; 

if (!isset($file)) {
   print("No file specified.");
   exit();
} 

move_uploaded_file($file->tmp_name, "uploads/".$file->name);
?>