using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Leaderboard : MonoBehaviour {
	//highscores
	public Text highScore;
	public Text highScore1;
	public Text highScore2;
	public Text highScore3;
	public Text highScore4;
	public Text highScore5;
	public Text highScore6;
	public Text highScore7;
	public Text highScore8;
	public Text highScore9;
	//names
	public Text name0;
	public Text name1;
	public Text name2;
	public Text name3;
	public Text name4;
	public Text name5;
	public Text name6;
	public Text name7;
	public Text name8;
	public Text name9;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (PlayerPrefs.GetInt ("lastScoreP1") > PlayerPrefs.GetInt ("lastScoreP29") &&) {

			highScore.text = (PlayerPrefs.GetInt ("lastScoreP1")).ToString;
			name0.text = (PlayerPrefs.GetInt ("lastScoreP1")).ToString;
		}
\
	}
}
