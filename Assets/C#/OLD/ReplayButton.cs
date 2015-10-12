using UnityEngine;
using System.Collections;

public class ReplayButton : MonoBehaviour {
	public GameObject player1;
	public GameObject player2;
	public GameObject player1won;
	public GameObject player2won;
	public GameObject ReplayCam;
	public GameObject GameCamera;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void replayButton(){
		player1.transform.position = new Vector3 (201.73f, 0.166f, 496.43f);
		player2.transform.position = new Vector3 (203.85f, 0.166f, 496.43f);
		ReplayCam.SetActive (false);
		GameCamera.SetActive (true);
		player1.SetActive (true);
		player2.SetActive (true);
		CombatScript.healthAmount = 100;
		CombatScript1.healthAmount = 100;
		CombatScript.isAlive = true;
		CombatScript1.isAlive = true;

		player1won.SetActive (false);
		player2won.SetActive (false);

	}
	public void mainMenu(){
		player1.transform.position = new Vector3 (201.73f, 0.166f, 496.43f);
		player2.transform.position = new Vector3 (203.85f, 0.166f, 496.43f);
		CombatScript.healthAmount = 100;
		CombatScript1.healthAmount = 100;
		ReplayCam.SetActive (false);
		GameCamera.SetActive (false);
		CombatScript.isAlive = true;
		CombatScript1.isAlive = true;
		player1.SetActive (false);
		player1.SetActive (false);
		player1won.SetActive (false);
		player2won.SetActive (false);
		Application.LoadLevel ("main");
	}
	IEnumerator playButton(){
		yield return new  WaitForSeconds (3f);
		MainMenu.PlayButton ();
	}
}
