using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MessageText : MonoBehaviour {

	private Text text;
	public GameObject player;

	void Start () {
		text = GetComponent<Text>();
	}

	void Update () {
		if (OrangeCube.hitcount == LV1manager.LV1Cubecount) {
			LevelUP ();
		}
		if (LivesText.dead == 1) {
			GameOver ();
		}
	}

	void LevelUP(){
		text.text = "Level 2";
		player.transform.position = LV2manager.LV2Position;
		OrangeCube.hitcount = 0;
	}

	void GameOver(){
		text.text = "GAME OVER";
		player.SetActive (false);
	}


}
