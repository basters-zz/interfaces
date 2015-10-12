using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {
	public GameObject cameraMainMenu;
	public GameObject cameraGame;
	public GameObject player1;
	public GameObject player2;
	public GameObject cameraArcade;
	public static GameObject cameraMainMenuS;
	public static GameObject cameraArcadeS;
	public static GameObject cameraGameS;
	public static GameObject player1S;
	public static GameObject player2S;
	public GameObject canvasReplay;

	// Use this for initialization
	void Start () {
		cameraMainMenuS = cameraMainMenu;
		cameraGameS = cameraGame;
		player1S = player1;
		player2S = player2;
		cameraArcadeS = cameraArcade;
		canvasReplay.SetActive (false);



	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public static void PlayButton(){
		cameraGameS.SetActive (true);
		cameraMainMenuS.SetActive (false);
		player1S.SetActive (true);
		player2S.SetActive (true);
	}
	public void PlayButton1(){
		cameraGameS.SetActive (true);
		cameraMainMenuS.SetActive (false);
		player1S.SetActive (true);
		player2S.SetActive (true);
	}
	public void PlayButton1Arcade(){
		//cameraArcadeS.SetActive (true);
		cameraMainMenuS.SetActive (false);
		//player1S.SetActive (true);
		//player2S.SetActive (true);
	}
	public static void PlayButtonArcade(){
		cameraArcadeS.SetActive (true);
		cameraMainMenuS.SetActive (false);
		//player1S.SetActive (true);
		//player2S.SetActive (true);
	}
}
