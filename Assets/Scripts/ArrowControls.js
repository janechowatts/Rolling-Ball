#pragma strict

static var speed : int = 15;

function Update () {
if (Input.GetKey (KeyCode.UpArrow)){ transform.Translate(Vector3.forward * Time.deltaTime * speed);}
if (Input.GetKey (KeyCode.DownArrow)){ transform.Translate(Vector3.forward * Time.deltaTime * -1 * speed);}
if (Input.GetKey (KeyCode.LeftArrow)){ transform.Translate(Vector3.left * Time.deltaTime* speed);}
if (Input.GetKey (KeyCode.RightArrow)){ transform.Translate(Vector3.right * Time.deltaTime*speed);}
     }