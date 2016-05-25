using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class ScoreText : MonoBehaviour {

	private int score;
	private Text text;


	void Start () {
		text = GetComponent<Text>();
		score = 0;
		displayText ();
	
	}
	
	void Update () {
		if (OrangeCube.hit == 1) {
			score = score + 30;
			OrangeCube.hit = 0;
			displayText ();
		}
	}

	void displayText (){
		text.text = "Score: " + score;
	}
}
