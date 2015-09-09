using UnityEngine;
using System.Collections;
using System.Collections.Generic;

	public class CombatScript : MonoBehaviour {
	public Animation fight;
	//public Animation leftHit;
	//public Animation rightHit;
	//public Animation headHit;
	public static bool strikeleft = false;
	public static bool strikeright = false;
	public static bool strikehead = false;
	public bool isAlive = true;
	public float timer = 0.1f;

	//public float bloodSpawn;
	public float hitTimer;
	public Rigidbody rb;
	//public GameObject blood1;
	//public GameObject blood2;
	//public GameObject bloedplek;
	//public Transform bloedplace;
	//public GameObject bloedplek1;
	//public Transform bloedplace1;
	

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
		if (isAlive == true) {
			if (Input.GetButton ("Fire1")) {
				fight.Play ("mixamo.com 1");
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
				StartCoroutine("Dead");
				strikehead = true;
				timer = 0.1f;
			}
			if (timer <= 0.0f) {
				strikeleft = false;
				strikeright = false;
				strikehead = false;
			}
			/*if (CombatScript1.strikeleft == true) {

				//Debug.Log("hello");
				leftHit.Play ("lefthit");
				
			}
			if (CombatScript1.strikeright == true) {

				//Debug.Log("hello");
				rightHit.Play ("righthit");
				
			}*/
			if (CombatScript1.strikehead == true) {

				//Debug.Log("hello");
				//StartCoroutine("dieNow");
				StartCoroutine("dieNow");
				//rb.isKinematic = false;
				isAlive = false;
		}else if (!fight.isPlaying){
			fight.Play ("mixamo.com 3");
			}
		} else {

		}

	}
	/*IEnumerator waitForBloodRightAttack(){
		yield return new WaitForSeconds (0.4f);
		
		bloedRight();
	}//1.585
	*/
	IEnumerator dieNow(){
		yield return new WaitForSeconds (1.3f);
		fight.Play ("mixamo.com 5");

		YouLost.YouLostp1();
		//bloedRight();
	}
	IEnumerator Dead(){
		yield return new WaitForSeconds (2.4f);
		//Vector3 temp = transform.position;
		//temp.x = 201.17f;
		//Debug.Log ("mixamo.com 3");
		fight.Stop ();
		this.transform.position = new Vector3 (200.942f, transform.position.y, transform.position.z);
		fight.Play("mixamo.com 3");
		//bloedRight();
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
