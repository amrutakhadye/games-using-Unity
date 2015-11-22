using UnityEngine;
using System.Collections;

public class MainScript : MonoBehaviour {
	public GUISkin skin;
	
	void OnGUI(){
		
		GUI.skin = skin;

		GUI.Label(new Rect(600, 10, 1000,100), "Story");
		GUI.Label(new Rect(450, 60, 1200, 30), "The Little girl wakes from the sleep to find out all her bunnies are turned into zombies.");
		GUI.Label(new Rect(450, 90, 1000, 30), "Help her kill the bunnies !!!! ");

		GUI.Label(new Rect(600, 120, 1000,100), "Rules");
		GUI.Label(new Rect(450, 170, 1000, 30), "* Player need to Kill atleast 7 bunnies inorder to win the Game");
		GUI.Label(new Rect(450, 200, 1000,45), "* In Total there are 10 buddies...you will have to search for it !!! ");
		GUI.Label(new Rect(450, 230, 1000,45), "* The total Time of the game is 1 min. The game time outs after that.");

		GUI.Label(new Rect(600, 260, 1000,100), "Game Instructions");
		GUI.Label(new Rect(450, 310, 1000,45), "* Press W to move forward");
		GUI.Label(new Rect(450, 340, 1000,45), "* Press S to move backward");
		GUI.Label(new Rect(450, 370, 1000,45), "* Press A to move left");
		GUI.Label(new Rect(450, 400, 1000,45), "* Press D to move right");
		GUI.Label(new Rect(450, 430, 1000,45), "* Left Click to fire gun shots...To kill the bunnies ");

		if (GUI.Button (new Rect (500, 500, 100, 45), "Play"))
		{
			Application.LoadLevel(1);	
			
		}
		
		if (GUI.Button (new Rect (500, 580, 100, 45), "Quit"))
		{
			Application.Quit();	
			
		}
		
	}
}
