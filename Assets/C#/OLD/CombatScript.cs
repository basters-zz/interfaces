using UnityEngine;
using System.Collections;
using System.Collections.Generic;

	public class CombatScript : MonoBehaviour {
	public Animation fight;
	public static bool strikeleft = false;
	public static bool strikeright = false;
	public static bool strikeleftSide = false;
	public static bool strikerightSide = false;
	public static bool strikehead = false;
	public static float healthAmount = 100;
	public static bool isAlive = true;
	public float timer = 0.1f;
	public GameObject bloodSpawnHead;
	public GameObject bloodSplatHead;
	public Transform bloodSpawnHeadTransform;
	public GameObject bloodSpawnArm1;
	public GameObject bloodSplatArm1;
	public Transform bloodSpawnArm1Transform;
	public GameObject bloodSpawnArm2;
	public GameObject bloodSplatArm2;
	public Transform bloodSpawnArm2Transform;
	public float hitTimer;
	public Rigidbody rb;
	public GameObject ReplayCam;
	public GameObject GameCamera;
	public GameObject player1;
	public GameObject canvasReplay;
	

	// Use this for initialization
	void Start () {
		//leftStrike = GetComponent.<Animation>();
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		hitTimer -= Time.deltaTime;
		timer -= Time.deltaTime;
		//bloodSpawn -= Time.deltaTime;
		Debug.Log (healthAmount + "     player2");
		if (isAlive == true) {
			if (Input.GetButton ("Fire1")) {
				fight.Play ("mixamo.com 6");
				strikeleft = true;
				timer = 0.1f;
				//StartCoroutine("waitForBloodLeftAttack");

			} 
			if (Input.GetButton ("Fire2")) {
				//bloodSpawn = 10f;
				fight.Play ("mixamo.com 2");
				strikeright = true;
				//StartCoroutine("waitForBloodRightAttack");
				timer = 0.1f;
			}
			if (Input.GetButton ("Fire3")) {
				fight.Play ("mixamo.com 4");
				StartCoroutine ("Dead");
				strikehead = true;
				timer = 0.1f;
			}
			if (Input.GetButton ("rechtzij2")) {
				fight.Play ("mixamo.com 6");
				strikeleftSide = true;
				timer = 0.1f;
				
			} 
			if (Input.GetButton ("leftzij2")) {
				fight.Play ("mixamo.com 2");
				strikerightSide = true;
				timer = 0.1f;
				
			}
			if (!fight.isPlaying) {
				fight.Play ("mixamo.com 3");
			}
			if (timer <= 0.0f) {
				strikeleft = false;
				strikeright = false;
				strikehead = false;
				strikeleftSide = false;
				strikerightSide = false;
			}
			if (CombatScript1.strikeleft == true) {
				StartCoroutine ("weakHit");
				//Debug.Log("hello");
				//leftHit.Play ("lefthit1");
				StartCoroutine ("getHit2");	
			}
			if (CombatScript1.strikerightSide == true) {
				//Instantiate(blood1, bloedplek.x,0);
				StartCoroutine ("strongHit");
				StartCoroutine ("getHit1");	
			}
			if (CombatScript1.strikeleftSide == true) {
				StartCoroutine ("strongHit");
				//Debug.Log("hello");
				//leftHit.Play ("lefthit1");
				StartCoroutine ("getHit2");	
			}
			if (CombatScript1.strikeright == true) {
				//Instantiate(blood1, bloedplek.x,0);
				StartCoroutine ("weakHit");
				StartCoroutine ("getHit1");	
			}
			//	Debug.Log("hello");
			//rightHit.Play ("righthit1");
			
			
			if (CombatScript1.strikehead == true) {
				StartCoroutine ("dieNow");
				StartCoroutine ("deadlyHit");
				//Debug.Log("hello");
				//headHit.Play ("headhit1");
				//rb.isKinematic = false;

				isAlive = false;
			}
				if (healthAmount <= 0 && isAlive == true) {
					fight.Play ("mixamo.com 7");
					isAlive = false;
					YouLost.YouLostp2 ();
				}

			} 
		if (healthAmount <= 0) {
			StartCoroutine ("stopTime");
		}
		
		} 



	IEnumerator weakHit(){
		//StartCoroutine ("Dead");
		yield return new WaitForSeconds (1.3f);
		healthAmount = healthAmount - 15;
		StopCoroutine ("weakHit");
	}
	IEnumerator strongHit(){
		//StartCoroutine ("Dead");
		yield return new WaitForSeconds (1.3f);
		healthAmount = healthAmount - 25;
		StopCoroutine ("strongHit");
	}
	IEnumerator deadlyHit(){
		//StartCoroutine ("Dead");
		yield return new WaitForSeconds (1.3f);
		healthAmount = healthAmount - 100;
		(bloodSpawnHead = Instantiate (bloodSplatHead) as GameObject).transform.parent = bloodSpawnHeadTransform;
		StopCoroutine ("deadlyHit");
	}
	IEnumerator stopTime(){
		//StartCoroutine ("Dead");
		yield return new WaitForSeconds (2f);
		ReplayCam.SetActive (true);
		GameCamera.SetActive (false);
		this.gameObject.SetActive (false);
		player1.SetActive (false);
		canvasReplay.SetActive (true);

	}
	IEnumerator dieNow(){
		yield return new WaitForSeconds (1.3f);
		fight.Play ("mixamo.com 5");

		YouLost.YouLostp2();
		//bloedRight();
	}
	IEnumerator Dead(){
		yield return new WaitForSeconds (2.4f);
		//Vector3 temp = transform.position;
		//temp.x = 201.17f;
		//Debug.Log ("mixamo.com 3");
		fight.Stop ();
		this.transform.position = new Vector3 (202.755f, transform.position.y, transform.position.z);
		fight.Play("mixamo.com 3");
		//bloedRight();
	}
	IEnumerator getHit1(){
		//StartCoroutine ("Dead");
		yield return new WaitForSeconds (0.8f);
		
		(bloodSpawnArm1 = Instantiate (bloodSplatArm1) as GameObject).transform.parent = bloodSpawnArm1Transform;
		yield return new WaitForSeconds (0.02f);
		StopCoroutine  ("getHit1");	
		
		
	}
	IEnumerator getHit2(){
		//StartCoroutine ("Dead");
		yield return new WaitForSeconds (1.3f);
		
		(bloodSpawnArm2 = Instantiate (bloodSplatArm2) as GameObject).transform.parent = bloodSpawnArm2Transform;
		yield return new WaitForSeconds (0.02f);
		StopCoroutine  ("getHit2");	
		
		
	}
	/*
	IEnumerator waitForBloodLeftAttack(){
		yield return new WaitForSeconds (0.4f);
		
		bloedLeft();
	}*/
	/*public void bloedRight(){
		(bloedplek = Instantiate (blood1) as GameObject).transform.parent = bloedplace;
	}
	public void bloedLeft(){
		(bloedplek1 = Instantiate (blood2) as GameObject).transform.parent = bloedplace1;
	}*/
}
