#pragma strict
import UnityEngine.UI; 

var Player : GameObject;
var INITIALxCoord : int;
var INITIALyCoord : int;
var INITIALzCoord : int;

var livesText : Text;


 function OnCollisionEnter () { 
 Player.transform.position = new Vector3(INITIALxCoord,INITIALyCoord,INITIALzCoord);

 }