using UnityEngine;
using System.Collections;

public class EnemyDeath : MonoBehaviour {
	public float sinkSpeed = 2.5f;              
	public AudioClip deathClip;                 
	
	
	Animator anim;                              
	AudioSource enemyAudio;                     
	ParticleSystem hitParticles;                
	CapsuleCollider capsuleCollider;            
	bool isDead;                                
	bool isSinking;                             

	Ray shootRay;  
	RaycastHit shootHit;                        
	public float range = 100f;      
	public int scoreValue = 10;

	void Awake ()
	{
		anim = GetComponent <Animator> ();
		enemyAudio = GetComponent <AudioSource> ();
		hitParticles = GetComponentInChildren <ParticleSystem> ();
		capsuleCollider = GetComponent <CapsuleCollider> ();
	}

	public void TakeDamage (int amount, Vector3 hitPoint)
	{
		hitParticles.transform.position = hitPoint;
		hitParticles.Play();
		Death ();
	}
	
	
	void Death ()
	{
		isDead = true;
		capsuleCollider.isTrigger = true;
		anim.SetTrigger ("Dead");
		enemyAudio.clip = deathClip;
		enemyAudio.Play ();

	}
	public void StartSinking ()
	{
		GetComponent <NavMeshAgent> ().enabled = false;
		GetComponent <Rigidbody> ().isKinematic = true;
		isSinking = true;
		ScoreManager.score += scoreValue;
		Destroy (gameObject, 2f);
	}
	
	
}
