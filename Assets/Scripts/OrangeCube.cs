using UnityEngine;
using System.Collections;

public class OrangeCube: MonoBehaviour {

	public static int hit;
	public static int hitcount;

	void Start () {
		hit = 0;
		hitcount = 0;
	}
	
	void OnCollisionEnter () {
		hit = 1;
		hitcount++;
		Destroy (gameObject);
	}
}
