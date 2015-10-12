using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Combat : MonoBehaviour {
	//P1
	//P1BodyParts
	public GameObject leftShoulderP1;
	public GameObject rightShoulderP1;
	public GameObject leftUpperArmP1;
	public GameObject rightUpperArmP1;
	public GameObject leftSideP1;
	public GameObject rightSideP1;

	//P1Won
	public GameObject wonP1;

	//P1Booleans
	public bool isAliveP1 = true;
	public bool leftArmIsAliveP1 = true;
	public bool rightArmIsAliveP1 = true;
	public bool bothArmsDeadP1 = false;

	//P1HealthAndDamage
	public Text healthTextP1;
	public float bloodAmountP1 = 100;
	float sideDamageP1 = 35;
	float headDamageP1 = 60;
	float armDamageP1 = 40;

	//P1Floats
	public float fightTimerP1;


	//////////////////
	//////////////////
	//////////////////


	 
	//P2BodyParts
	public GameObject leftShoulderP2;
	public GameObject rightShoulderP2;
	public GameObject leftUpperArmP2;
	public GameObject rightUpperArmP2;
	public GameObject leftSideP2;
	public GameObject rightSideP2;

	//P1Won
	public GameObject wonP2;
	
	//P2Booleans
	public bool isAliveP2 = true;
	public bool leftArmIsAliveP2 = true;
	public bool rightArmIsAliveP2 = true;
	public bool bothArmsDeadP2 = false;


	//P2HealthAndDamage
	public Text healthTextP2;
	public float bloodAmountP2 = 100;
	float sideDamageP2 = 35;
	float headDamageP2 = 60;
	float armDamageP2 = 40;
	 
	//P2Floats
	public float fightTimerP2;


	////////////
	////////////
	////////////


	//Everyones floats
	bool stopFight = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		fightTimerP1 -= Time.deltaTime;
		fightTimerP2 -= Time.deltaTime;



		//if health P1 is below 0 then make it 0 and dont update it
		if (bloodAmountP1 <= 0) {
			healthTextP1.text = ("Death").ToString ();
		} else {
			healthTextP1.text = (bloodAmountP1).ToString ();
		}
		//if health P2 is below 0 then make it 0 and dont update it
		if (bloodAmountP2 <= 0) {
			healthTextP2.text = ("Death").ToString ();
		} else {
			healthTextP2.text = (bloodAmountP2).ToString ();
		}





		//Check if the P2 is able to fight if so, he can else he can not
		//P2 Does Damage in this section

		if (isAliveP2 == true) {
			if (stopFight == false){
				if(fightTimerP2 <= 0){
					if (leftArmIsAliveP2 == true) {
						if (Input.GetButton ("LeftShoulderP2Hit") && Input.GetButton ("LeftArmP2")) {
							fightTimerP2 = 1f;
							StartCoroutine (HeadDamageLeftShoulderP1 ());
							StartCoroutine (headDamageDealerP1 ());
						}
						if (Input.GetButton ("RightShoulderP2Hit") && Input.GetButton ("LeftArmP2")) {
							fightTimerP2 = 1f;
							StartCoroutine (HeadDamageRightShoulderP1 ());
							StartCoroutine (headDamageDealerP1 ());
						}
						if (Input.GetButton ("LeftUpperArmP2Hit") && Input.GetButton ("LeftArmP2")) {
							fightTimerP2 = 1f;
							leftUpperArmP1.SetActive (true);
							StartCoroutine (armDamageDealerP1 ());
							leftArmIsAliveP1 = false;
						}
						if (Input.GetButton ("RightUpperArmP2Hit") && Input.GetButton ("LeftArmP2")) {
							fightTimerP2 = 1f;
							rightUpperArmP1.SetActive (true);
							StartCoroutine (armDamageDealerP1 ());
							rightArmIsAliveP1 = false;
						}
						if (Input.GetButton ("LeftSideP2Hit") && Input.GetButton ("LeftArmP2")) {
							fightTimerP2 = 1f;
							StartCoroutine (LeftSideDamageP1 ());
							StartCoroutine (sideDamageDealerP1 ());
						}
						if (Input.GetButton ("RightSideP2Hit") && Input.GetButton ("LeftArmP2")) {
							fightTimerP2 = 1f;
							StartCoroutine (RightSideDamageP1 ());
							StartCoroutine (sideDamageDealerP1 ());
						} 
						else{//do nothing
						}
					}
					if (rightArmIsAliveP2 == true) {
						if (Input.GetButton ("LeftShoulderP2Hit") && Input.GetButton ("RightArmP2")) {
							fightTimerP2 = 1f;
							StartCoroutine (HeadDamageLeftShoulderP1 ());
							StartCoroutine (headDamageDealerP1 ());
						}
						if (Input.GetButton ("RightShoulderP2Hit") && Input.GetButton ("RightArmP2")) {
							fightTimerP2 = 1f;
							StartCoroutine (HeadDamageRightShoulderP1 ());
							StartCoroutine (headDamageDealerP1 ());
						}
						if (Input.GetButton ("LeftUpperArmP2Hit") && Input.GetButton ("RightArmP2")) {
							fightTimerP2 = 1f;
							leftUpperArmP1.SetActive (true);
							StartCoroutine (armDamageDealerP1 ());
							leftArmIsAliveP1 = false;
						}
						if (Input.GetButton ("RightUpperArmP2Hit") && Input.GetButton ("RightArmP2")) {
							fightTimerP2 = 1f;
							rightUpperArmP1.SetActive (true);
							StartCoroutine (armDamageDealerP1 ());
							rightArmIsAliveP1 = false;
						}
						if (Input.GetButton ("LeftSideP2Hit") && Input.GetButton ("RightArmP2")) {
							fightTimerP2 = 1f;
							StartCoroutine (LeftSideDamageP1 ());
							StartCoroutine (sideDamageDealerP1 ());
						}
						if (Input.GetButton ("RightSideP2Hit") && Input.GetButton ("RightArmP2")) {
							fightTimerP2 = 1f;
							StartCoroutine (RightSideDamageP1 ());
							StartCoroutine (sideDamageDealerP1 ());
						} 
						else{//do nothing
						}
					}
				}
			}
		} else {
			StartCoroutine(deathDealerP1());
		}
		//Check if the P1 is able to fight if so, he can else he can not
		//P1 Does Damage in this section
		if (isAliveP1 == true) {
			if(stopFight == false){
				if(fightTimerP1 <= 0){
					if (leftArmIsAliveP1 == true) {
						if (Input.GetButton ("LeftShoulderP1Hit") && Input.GetButton ("LeftArmP1")) {
							fightTimerP1 = 1f;
							StartCoroutine (HeadDamageLeftShoulderP2 ());
							StartCoroutine (headDamageDealerP2 ());
						}
						if (Input.GetButton ("RightShoulderP1Hit") && Input.GetButton ("LeftArmP1")) {
							fightTimerP1 = 1f;
							StartCoroutine (HeadDamageRightShoulderP2 ());
							StartCoroutine (headDamageDealerP2 ());
						}
						if (Input.GetButton ("LeftUpperArmP1Hit") && Input.GetButton ("LeftArmP1")) {
							fightTimerP1 = 1f;
							leftUpperArmP2.SetActive (true);
							StartCoroutine (armDamageDealerP2 ());
							leftArmIsAliveP2 = false;
						}
						if (Input.GetButton ("RightUpperArmP1Hit") && Input.GetButton ("LeftArmP1")) {
							fightTimerP1 = 1f;
							rightUpperArmP2.SetActive (true);
							StartCoroutine (armDamageDealerP2 ());
							rightArmIsAliveP2 = false;
						}
						if (Input.GetButton ("LeftSideP1Hit") && Input.GetButton ("LeftArmP1")) {
							fightTimerP1 = 1f;
							StartCoroutine (LeftSideDamageP2 ());
							StartCoroutine (sideDamageDealerP2 ());
							Debug.Log("RightSideP1Hit");
						}
						if (Input.GetButton ("RightSideP1Hit") && Input.GetButton ("LeftArmP1")) {
							fightTimerP1 = 1f;
							StartCoroutine (RightSideDamageP2 ());
							StartCoroutine (sideDamageDealerP2 ());
							Debug.Log("RightSideP1Hit");
						} 
						else{//do nothing
						}
					}
					if (rightArmIsAliveP1 == true) {
						if (Input.GetButton ("LeftShoulderP1Hit") && Input.GetButton ("RightArmP1")) {
							fightTimerP1 = 1f;
							StartCoroutine (HeadDamageLeftShoulderP2 ());
							StartCoroutine (headDamageDealerP2 ());
						}
						if (Input.GetButton ("RightShoulderP1Hit") && Input.GetButton ("RightArmP1")) {
							fightTimerP1 = 1f;
							StartCoroutine (HeadDamageRightShoulderP2 ());
							StartCoroutine (headDamageDealerP2 ());
						}
						if (Input.GetButton ("LeftUpperArmP1Hit") && Input.GetButton ("RightArmP1")) {
							fightTimerP1 = 1f;
							leftUpperArmP2.SetActive (true);
							StartCoroutine (armDamageDealerP2 ());
							leftArmIsAliveP2 = false;
						}
						if (Input.GetButton ("RightUpperArmP1Hit") && Input.GetButton ("RightArmP1")) {
							fightTimerP1 = 1f;
							rightUpperArmP2.SetActive (true);
							StartCoroutine (armDamageDealerP2 ());
							rightArmIsAliveP2 = false;
						}
						if (Input.GetButton ("LeftSideP1Hit") && Input.GetButton ("RightArmP1")) {
							fightTimerP1 = 1f;
							StartCoroutine (LeftSideDamageP2 ());
							StartCoroutine (armDamageDealerP2 ());
						}
						if (Input.GetButton ("RightSideP1Hit") && Input.GetButton ("RightArmP1")) {
							fightTimerP1 = 1f;
							StartCoroutine (RightSideDamageP2 ());
							StartCoroutine (armDamageDealerP2 ());
						} 
						else{
							//do nothing
						}
					}
				}
			}
		} else {
			StartCoroutine(deathDealerP2());
		}
		//check if both arms are dead for P2
		if(rightArmIsAliveP2 == false && leftArmIsAliveP2 == false){
			bothArmsDeadP2 = true;
		} 
		//check if P2 is dead
		if (bloodAmountP2 <= 0 || bothArmsDeadP2 == true) {
			isAliveP2 = false;
			stopFight = true;
		}
		//check if both arms are dead for P2
		if(rightArmIsAliveP1 == false && leftArmIsAliveP1 == false){
			bothArmsDeadP1 = true;
		}
		//check if P2 is dead
		if (bloodAmountP1 <= 0 || bothArmsDeadP1 == true) {
			isAliveP1 = false;
			stopFight = true;
		}

	}
	//P1IEnumerators
	//These IEnumerators show the point of impact on the human body of P1
	public IEnumerator HeadDamageLeftShoulderP1 (){
		leftShoulderP1.SetActive (true);
		yield return new WaitForSeconds (0.75f);
		leftShoulderP1.SetActive (false);
	}
	public IEnumerator HeadDamageRightShoulderP1 (){
		rightShoulderP1.SetActive (true);
		yield return new WaitForSeconds (0.75f);
		rightShoulderP1.SetActive (false);
	}
	public IEnumerator LeftSideDamageP1 (){
		leftSideP1.SetActive (true);
		yield return new WaitForSeconds (0.75f);
		leftSideP1.SetActive (false);
	}
	public IEnumerator RightSideDamageP1 (){
		rightSideP1.SetActive (true);
		yield return new WaitForSeconds (0.75f);
		rightSideP1.SetActive (false);
	}

	//These IEnumerators deal the damage to P1
	public IEnumerator headDamageDealerP1(){
		yield return new WaitForSeconds (0.02f);
		bloodAmountP1 = bloodAmountP1 - headDamageP1;
		StopCoroutine (headDamageDealerP1());
	}
	public IEnumerator sideDamageDealerP1(){
		yield return new WaitForSeconds (0.02f);
		bloodAmountP1 = bloodAmountP1 - sideDamageP1;
		StopCoroutine (sideDamageDealerP1());
	}
	public IEnumerator armDamageDealerP1(){
		yield return new WaitForSeconds (0.02f);
		bloodAmountP1 = bloodAmountP1 - armDamageP1;
		StopCoroutine (armDamageDealerP1());
	}
	public IEnumerator deathDealerP1(){
		wonP1.SetActive(true);
		yield return new WaitForSeconds (3f);
		Application.LoadLevel("replayHardcore");
	}

	////////////
	////////////
	////////////


	//P2IEnumerators
	//These IEnumerators show the point of impact on the human body of P2
	public IEnumerator HeadDamageLeftShoulderP2 (){
		leftShoulderP2.SetActive (true);
		yield return new WaitForSeconds (0.75f);
		leftShoulderP2.SetActive (false);
	}
	public IEnumerator HeadDamageRightShoulderP2 (){
		rightShoulderP2.SetActive (true);
		yield return new WaitForSeconds (0.75f);
		rightShoulderP2.SetActive (false);
	}
	public IEnumerator LeftSideDamageP2 (){
		leftSideP2.SetActive (true);
		yield return new WaitForSeconds (0.75f);
		leftSideP2.SetActive (false);
	}
	public IEnumerator RightSideDamageP2 (){
		rightSideP2.SetActive (true);
		yield return new WaitForSeconds (0.75f);
		rightSideP2.SetActive (false);
	}

	
	//These IEnumerators deal the damage to P2
	public IEnumerator headDamageDealerP2(){
		yield return new WaitForSeconds (0.02f);
		bloodAmountP2 = bloodAmountP2 - headDamageP2;
		StopCoroutine (headDamageDealerP2());
		Debug.Log ("test");
	}
	public IEnumerator sideDamageDealerP2(){
		yield return new WaitForSeconds (0.02f);
		bloodAmountP2 = bloodAmountP2 - sideDamageP2;
		StopCoroutine (sideDamageDealerP2());
		Debug.Log ("test");
	}
	public IEnumerator armDamageDealerP2(){
		yield return new WaitForSeconds (0.02f);
		bloodAmountP2 = bloodAmountP2 - armDamageP2;
		StopCoroutine (armDamageDealerP2());
		Debug.Log ("test");
	}
	public IEnumerator deathDealerP2(){
		wonP2.SetActive(true);
		yield return new WaitForSeconds (3f);
		Application.LoadLevel("replayHardcore");
	}
}
