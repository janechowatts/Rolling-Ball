#pragma strict

var Ball : GameObject;


function Update () {

transform.position = new Vector3(Ball.transform.position.x +1, Ball.transform.position.y + 3, Ball.transform.position.z+1);
}

