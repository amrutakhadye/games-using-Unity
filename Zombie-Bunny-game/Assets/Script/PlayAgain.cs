using UnityEngine;
using System.Collections;

public class PlayAgain : MonoBehaviour {
	public GUISkin skin;
	public Rect timerRect,timerRect1;

	void OnGUI(){
		
		GUI.skin = skin;
		
		if (GUI.Button (new Rect (350,200,200,100), "Play Again"))
		{
			Application.LoadLevel(1);	
		}
		
		if (GUI.Button (new Rect (350,400,200,100), "Quit"))
		{
			Application.Quit();
		}
		if(Input.GetKey(KeyCode.Escape))
		{
			Application.Quit();
		}
		int score = ScoreManager.score;
		if (score > 60) {
			GUI.Label (timerRect, "Congrats !!! You won ");
			GUI.Label (timerRect1, "Your Score is "+ score);
		} else {
			GUI.Label (timerRect, "Time is Up !!! You Lost...Please try again ");
			GUI.Label (timerRect1, "Your Score is "+score);
		}
	}
}
