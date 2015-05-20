<?php
 
function getCategories(){
    $servername = "localhost";
    $username = "root";
    $password = "";
    $db_name = "tos_proj1";
    
    $conn = new mysqli($servername, $username, $password, $db_name);
    // array for json response
    $response = array();
    $response["tos_posts"] = array();
     
    // Mysql select query
    $result = mysqli_query($conn, "SELECT * FROM tos_posts WHERE post_status='publish'");
     
    while($row = mysqli_fetch_array($result)){
        // temporary array to create single category
        $tmp = array();
        $tmp["ID"] = $row["ID"];
        $tmp["post_title"] = $row["post_title"];
         
        // push category to final json array
        array_push($response["tos_posts"], $tmp);
    }
     
    // keeping response header to json
    header('Content-Type: application/json');
     
    // echoing json result
    echo json_encode($response);
    
    mysqli_close($conn);
}
 
getCategories();

?>