using UnityEngine;
using System.Collections;

public class LV2manager : MonoBehaviour {

	public static Vector3 LV2Position;
	public static int LV2Cubecount;

	public Vector3 EnterPosition;
	public  int EnterCubeCount;


	void Start(){
		LV2Position = EnterPosition;
		LV2Cubecount = EnterCubeCount;

	}

}
