using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ReplayPartyMode : MonoBehaviour {
	public Text highScore;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//Show HighScore
		if (PlayerPrefs.GetInt ("lastScoreP1") > PlayerPrefs.GetInt ("lastScoreP2")) {
			highScore.text = ("HighScore:" + PlayerPrefs.GetString ("bestPlayerP1") + " : " + PlayerPrefs.GetInt ("lastScoreP1")).ToString ();
		} else {
			highScore.text = ("HighScore:" + PlayerPrefs.GetString ("bestPlayerP2") + " : " + PlayerPrefs.GetInt ("lastScoreP2")).ToString ();
		}



	
	}
	//Replay Button
	public void clickReplay(){
		Application.LoadLevel ("partyMode");
	}
	//Main Menu button
	public void clickMainMenu(){
		Application.LoadLevel ("mainmenu");
	}
}
