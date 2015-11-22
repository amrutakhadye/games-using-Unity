using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BallMovement : MonoBehaviour {
	
	public float speed;
	public int count;

	public Text countText;
	public GUISkin skin;

	public Rect timerRect;
	public float startTime;
	private string currentTime;
	
	void Start()
	{ count = 0;
		SetCountText ();
	}
	
	void Update()
	{
		startTime += Time.deltaTime;
		currentTime = string.Format ("{0:0.0}", startTime);
		int intTime =(int)startTime;

		if (intTime >= 30) {
		//Displays the Lose scene
		Application.LoadLevel(2);
		}
	}
	
	void OnGUI()
	{// display the text
		GUI.skin = skin;
		GUI.Label (timerRect, currentTime);
	}
	
	void FixedUpdate(){
		//Movement of the Ball
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		rigidbody.AddForce (movement * speed * Time.deltaTime);
	}
	
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "PickUp")
		{
			other.gameObject.SetActive(false);
			count = count +1;
			SetCountText();
		}
		if(other.gameObject.tag == "Respawn")
		{//display game over scene
			Application.LoadLevel(2);
		}

	}
	
	void SetCountText(){
		
		countText.text = "Count: " + count; 
		if(count > 4 )
		{// display game won scence
			countText.text = "You Win !!!!!!";
			Application.LoadLevel(1);

		}
		
	}
	



}

