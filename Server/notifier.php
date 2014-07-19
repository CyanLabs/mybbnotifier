<?php
/*--------------------------------------------------------------------------------------------------------------------------

MyBB Notifier - V1.0 (Server Side).
Created By CyanLabs. (http://cyanlabs.net)
Credit to ShrinkOnce @ http://community.mybb.com/thread-123744.html for the idea.

I based it on the post above but have included security such as API key as in the old version.
ANY ONE COULD GET THE SALT AND MD5 OF THE OWNERS (UID 1) ACCOUNT. DO NOT USE THE OLD VERSION BY ShrinkOnce.
The old version was also based on a chrome extension where as mine will be a windows application and possible other OS's
My version also uses JSON to parse not only the count but also the subject, poster and message.

Feel free to improve or break this code and re-distribute it. Leave the credit for both Fma965/Cyanlabs and ShrinkOnce.

Please edit the 2 lines below to set your API Key to something secure. 

--------------------------------------------------------------------------------------------------------------------------*/

define('APIKEY', 'YOURKEY'); // Set this to something secret and set the client to the same. Prevent unauthorized access.

define('SHOWALL', False); // Shows all posts rather than just new posts. (Not recommended unless testing)

//--------------------------------------------------------------------------------------------------------------------------

// Validates API Key and UID and Checks whether to show all posts or only new.
if ("YOURKEY" == APIKEY) die("Please change your API key at the top of this script before use");
if (isset($_GET["apikey"])) { $key = $_GET["apikey"]; }else{ die("No API Key"); }
if (isset($_GET["uid"])) { $uid = $_GET["uid"]; }else{ $uid = 1; }
if (!is_numeric($uid)) die("Invalid UID");
if ($key != APIKEY) die("Invalid API Key");

// Loads MyBB Core and sets some defines
define("IN_MYBB", 1);
define("NO_ONLINE", 1);
define('THIS_SCRIPT', 'notifier.php');
require_once dirname(__FILE__)."/inc/init.php";

// Get last active timestamp for chosen UID (if not set defaults to 1)
$query = $db->simple_select('users', 'lastactive', 'uid = '.$uid);
$last_active = $db->fetch_field($query,"lastactive");

// If SHOWALL = false gets only new posts. If SHOWALL = true gets all posts
if (SHOWALL == True) {
$query = $db->simple_select('posts', 'subject,message,username', 'dateline');
} else {
$query = $db->simple_select('posts', 'subject,message,username', 'dateline > '. $last_active .' ORDER BY dateline DESC');
}
$json = array();
while($result=$db->fetch_array($query))
{
	$row_array['subject'] = $result['subject'];
	$row_array['message'] = strip_tags($result['message']);
	$row_array['username'] = $result['username'];
	array_push($json,$row_array);
}
echo json_encode($json);
?>