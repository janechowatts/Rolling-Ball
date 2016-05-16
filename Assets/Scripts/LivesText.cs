using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class LivesText : MonoBehaviour {

	public int lifecount; 
	public Text livesText;
	private string livesString;

	// Use this for initialization
	void Start () {

		lifecount = 3;
		displayText ();
	}

	void displayText (){
		livesString = "Lives: ";
		for (int i = 1; i <= lifecount; i++)
		{
			livesString = livesString + "X ";
		}
		livesText.text = livesString;
	}
		
	void detractLife (){
		lifecount = lifecount - 1;
		displayText ();
	}


}
