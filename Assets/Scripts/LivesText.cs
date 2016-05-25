using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class LivesText : MonoBehaviour {

	public int lifecount; 
	private string livesString;
	private Text text;
	public static int dead;

	void Start () {
		text = GetComponent<Text>();
		displayText ();
		dead = 0;

	}

	void displayText () {
		livesString = "Lives: ";
		for (int i = 1; i <= lifecount; i++)
		{
			livesString = livesString + "X ";
		}
		text.text = livesString;
	}
	void Update(){
		if(ResetWall.hit == 1){
			detractLife ();
			ResetWall.hit = 0;
	}

	}

	void detractLife(){
		lifecount = lifecount - 1;
		displayText ();
		if (lifecount == 0) {
			dead = 1;
		}
	}


}
