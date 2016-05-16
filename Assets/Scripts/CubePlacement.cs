using UnityEngine;
using System.Collections;

public class CubePlacement : MonoBehaviour {

	public GameObject Terrain;
	private int offset = 5;

	// Use this for initialization
	void Start () {
		//Color.red;
		transform.position = new Vector3(Terrain.transform.position.x + Terrain.transform.localScale.x /2 - transform.localScale.x / 2 - offset,Terrain.transform.position.y + transform.localScale.y / 2,Terrain.transform.position.z + Terrain.transform.localScale.z /2 - transform.localScale.z / 2 - offset);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
