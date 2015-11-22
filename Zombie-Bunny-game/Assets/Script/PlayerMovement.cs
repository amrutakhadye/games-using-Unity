using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public float forwardSpeed = 5.0f;
	public float backwardSpeed = 2.0f;
	public float turnSpeed = 30.0f;
	Animator anim;

	public Rect timerRect;
	public float startTime;
	private string currentTime;

	public GUISkin skin;

	void Awake(){
		anim = GetComponent<Animator> ();
	}
	
	void Update(){

		startTime -= Time.deltaTime;
		currentTime = string.Format ("{0:0.0}", startTime);
		int intTime =(int)startTime;

		if( intTime <= 0){
			Application.LoadLevel(2);
			
		}

		float h = Input.GetAxisRaw("Horizontal");
		float v = Input.GetAxisRaw("Vertical");
	
		if (Input.GetKey (KeyCode.W)) {
			transform.position +=transform.forward * forwardSpeed *Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.S)) {
			transform.position -=transform.forward * backwardSpeed *Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.Rotate(0.0f,-turnSpeed,0.0f);
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.Rotate(0.0f,turnSpeed,0.0f);
		}

		if(Input.GetKey(KeyCode.Escape))
		{
			Application.Quit();
		}
		Animating (h, v);
		
	}

	
	void Animating(float h,float v){
		bool walking = h != 0f || v != 0f;
		anim.SetBool ("IsWalking", walking);
	}

	void OnGUI()
	{
		GUI.skin = skin;
		GUI.Label (timerRect,"You have : "+ currentTime +" seconds....Hurry Up !");
		
	}

}
