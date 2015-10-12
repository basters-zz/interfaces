using UnityEngine;
//using UnityEngine.transform.position;
using System.Collections;

	public class CombatScriptArcade1 : MonoBehaviour {
	public Animation fight;
//	public Animation rightStrike;
	//public Animation headStrike;
	//public Animation idle;
	//public Animation leftHit;
	//public Animation rightHit;
	//public Animation headHit;
	public static bool strikeleft = false;
	public static bool strikeright = false;
	public static bool strikeleftSide = false;
	public static bool strikerightSide = false;
	public static bool strikehead = false;
	public float position = 201.17f;
	public Transform knight;
	public static bool isAlive = true;
	public float timer = 0.1f;
	public float bloodTimer = 0.1f;
	public static float healthAmount = 100f;
	public Rigidbody rb;
	public GameObject bloodSpawnHead;
	public GameObject bloodSplatHead;
	public Transform bloodSpawnHeadTransform;
	public GameObject bloodSpawnArm1;
	public GameObject bloodSplatArm1;
	public Transform bloodSpawnArm1Transform;
	public GameObject bloodSpawnArm2;
	public GameObject bloodSplatArm2;
	public Transform bloodSpawnArm2Transform;
	public GameObject ReplayCam;
	public GameObject GameCamera;
	public GameObject player2;
	public GameObject canvasReplay;
	
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		//leftStrike = GetComponent.<Animation>();


	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		bloodTimer -= Time.deltaTime;	
		Debug.Log (healthAmount + "     player1");
		if (isAlive == true) {
			if (Input.GetButton ("righthit")) {
				fight.Play ("mixamo.com 6");
				strikeleft = true;
				timer = 0.1f;

			} 
			if (Input.GetButton ("Submit")) {
				fight.Play ("mixamo.com 2");
				strikeright = true;
				timer = 0.1f;

			}
			if (Input.GetButton ("rechtszij1")) {
				fight.Play ("mixamo.com 6");
				strikeleftSide = true;
				timer = 0.1f;
				
			} 
			if (Input.GetButton ("leftzij1")) {
				fight.Play ("mixamo.com 2");
				strikerightSide = true;
				timer = 0.1f;
				
			}
			if (Input.GetButton ("kut")) {
				fight.Play ("mixamo.com 4");
				StartCoroutine ("Dead");
				strikehead = true;
				timer = 0.1f;
			}

			if (timer <= 0.0f) {
				strikeleft = false;
				strikeright = false;
				strikeleftSide = false;
				strikerightSide = false;
				strikehead = false;
			}

			if (CombatScript.strikeleft == true) {
				StartCoroutine ("weakHit");
				//Debug.Log("hello");
				//leftHit.Play ("lefthit1");
				StartCoroutine ("getHit2");	
			}
			if (CombatScript.strikerightSide == true) {
				//Instantiate(blood1, bloedplek.x,0);
				StartCoroutine ("strongHit");
				StartCoroutine ("getHit1");	
			}
			if (CombatScript.strikeleftSide == true) {
				StartCoroutine ("strongHit");
				//Debug.Log("hello");
				//leftHit.Play ("lefthit1");
				StartCoroutine ("getHit2");	
			}
			if (CombatScript.strikeright == true) {
				//Instantiate(blood1, bloedplek.x,0);
				StartCoroutine ("weakHit");
				StartCoroutine ("getHit1");	
			}
				//	Debug.Log("hello");
				//rightHit.Play ("righthit1");
				
			
			if (CombatScript.strikehead == true) {
				StartCoroutine ("dieNow");
				StartCoroutine ("deadlyHit");
				//Debug.Log("hello");
				//headHit.Play ("headhit1");
				//rb.isKinematic = false;
				isAlive = false;
			}
			if(healthAmount <= 0 && isAlive == true){
				fight.Play("mixamo.com 7");
				isAlive = false;
				YouLost.YouLostp1();
			}
			else if (!fight.isPlaying){
				fight.Play ("mixamo.com 3");
			}

		} else {


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

		StopCoroutine ("deadlyHit");
	}
	IEnumerator dieNow(){
		//StartCoroutine ("Dead");
		yield return new WaitForSeconds (1.3f);
		fight.Play ("mixamo.com 5");
		(bloodSpawnHead = Instantiate (bloodSplatHead) as GameObject).transform.parent = bloodSpawnHeadTransform;
		YouLost.YouLostp1();

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
	IEnumerator stopTime(){
		//StartCoroutine ("Dead");
		yield return new WaitForSeconds (2f);
		ReplayCam.SetActive (true);
		GameCamera.SetActive (false);
		this.gameObject.SetActive (false);
		player2.SetActive (false);
		canvasReplay.SetActive (true);
		//StopCoroutine ("stopTime");
	}
	IEnumerator Dead(){
		yield return new WaitForSeconds (2.4f);
		//Vector3 temp = transform.position;
		//temp.x = 201.17f;
		//Debug.Log ("mixamo.com 3");
		fight.Stop ();
		knight.transform.position = new Vector3 (202.825f, transform.position.y, transform.position.z);
		fight.Play("mixamo.com 3");
		//bloedRight();
	}
}
