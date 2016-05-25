using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class ResetWall : MonoBehaviour {
	public Vector3 INITIALcoord;
	public GameObject Player;
	public static int hit;

	void Start () {
		hit = 0;
	}

	void OnCollisionEnter () {
		hit = 1;
		Player.transform.position = INITIALcoord;
	}
		
}
