using UnityEngine;
//using UnityEngine.transform.position;
using System.Collections;

	public class CombatScript1 : MonoBehaviour {
	public Animation fight;
//	public Animation rightStrike;
	//public Animation headStrike;
	//public Animation idle;
	//public Animation leftHit;
	//public Animation rightHit;
	//public Animation headHit;
	public static bool strikeleft = false;
	public static bool strikeright = false;
	public static bool strikehead = false;
	public float position = 201.17f;
	public Transform knight;
	public bool isAlive = true;
	public float timer = 0.1f;
	public float bloodTimer = 0.1f;
	public Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		//leftStrike = GetComponent.<Animation>();

	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		bloodTimer -= Time.deltaTime;	
		if (isAlive == true) {
			if (Input.GetButton ("righthit")) {
				fight.Play ("mixamo.com 1");
				strikeleft = true;
				timer = 0.1f;
			} 
			if (Input.GetButton ("Submit")) {
				fight.Play ("mixamo.com 2");
				strikeright = true;
				timer = 0.1f;
			}
			if (Input.GetButton ("Cancel")) {
				fight.Play ("mixamo.com 4");
				StartCoroutine ("Dead");
				strikehead = true;
				timer = 0.1f;
			}

			if (timer <= 0.0f) {
				strikeleft = false;
				strikeright = false;
				strikehead = false;
			}

		/*	if (CombatScript.strikeleft == true) {
				
				//Debug.Log("hello");
				leftHit.Play ("lefthit1");
				
			}
			if (CombatScript.strikeright == true) {
				//Instantiate(blood1, bloedplek.x,0);

					
				
				//	Debug.Log("hello");
				rightHit.Play ("righthit1");
				
			}*/
			if (CombatScript.strikehead == true) {
				StartCoroutine ("dieNow");
				//Debug.Log("hello");
				//headHit.Play ("headhit1");
				//rb.isKinematic = false;
				isAlive = false;
			}
			else if (!fight.isPlaying){
				fight.Play ("mixamo.com 3");
			}
		} else {

			//YouLost.YouLostp2();
		}
	}
	IEnumerator dieNow(){
		//StartCoroutine ("Dead");
		yield return new WaitForSeconds (1.3f);
		fight.Play ("mixamo.com 5");

		YouLost.YouLostp2();

	}
	IEnumerator Dead(){
		yield return new WaitForSeconds (2.4f);
		//Vector3 temp = transform.position;
		//temp.x = 201.17f;
		//Debug.Log ("mixamo.com 3");
		fight.Stop ();
		knight.transform.position = new Vector3 (201.68f, transform.position.y, transform.position.z);
		fight.Play("mixamo.com 3");
		//bloedRight();
	}
}
