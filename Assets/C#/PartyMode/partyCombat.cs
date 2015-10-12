using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class partyCombat : MonoBehaviour {



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

	
	//P1PointsAndScore
	public Text playerNameP1;
	public Text scoreTextP1;
	public static int totalScoreP1 = 0;
	int headScoreP1 = 100;
	int armScoreP1 = 25;
	int sideScoreP1 = 50;
	public int lastHighScoreP1;
	public Text wonP1Text;
	
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

	
	
	//P2PointsAndScore
	public Text playerNameP2;
	public Text scoreTextP2;
	public static int totalScoreP2 = 0;
	int headScoreP2 = 100;
	int armScoreP2 = 25;
	int sideScoreP2 = 50;
	int lastHighScoreP2;
	public Text wonP2Text;


	
	//P2Floats
	public float fightTimerP2;
	
	
	////////////
	////////////
	////////////
	
	//Highscores
	public Text highScore;

	//Everyones floats
	public float timerMinutes = 1;
	public float timerSeconds = 60f;

	//Timer
	public Text timeInMinutesText;


	//Everyones booleans
	bool stopFight = false;


	// Use this for initialization
	void Start () {
		StartCoroutine (timerParty());
		//StartCoroutine (timeInMinutes());
		StartCoroutine (timeInSeconds());
		PlayerPrefs.GetInt ("lastScoreP1");
		PlayerPrefs.GetInt("lastScoreP1");
	}
	
	// Update is called once per frame
	void Update () {

		fightTimerP1 -= Time.deltaTime;
		fightTimerP2 -= Time.deltaTime;

		scoreTextP1.text = ("Score:" + totalScoreP1).ToString ();
		scoreTextP2.text = ("Score:" + totalScoreP2).ToString ();

		//Scores from P1 and P2 converted to text on screen
		wonP1Text.text = (NamePick.nameP2 + " is KO" + NamePick.nameP1 + " won!" ).ToString ();
		wonP2Text.text = (NamePick.nameP1 + " is KO" + NamePick.nameP2 + " won!" ).ToString ();


		//Name Config
		playerNameP1.text = (NamePick.nameP1).ToString ();
		playerNameP2.text = (NamePick.nameP2).ToString ();



		//Save score and playername if the score is the newest high score
		if (totalScoreP1 > PlayerPrefs.GetInt("lastScoreP1")) {
			//lower all previous highscores
			PlayerPrefs.SetInt("lastScoreP110", PlayerPrefs.GetInt("lastScoreP19"));
			PlayerPrefs.SetInt("lastScoreP19", PlayerPrefs.GetInt("lastScoreP18"));
			PlayerPrefs.SetInt("lastScoreP18", PlayerPrefs.GetInt("lastScoreP17"));
			PlayerPrefs.SetInt("lastScoreP17", PlayerPrefs.GetInt("lastScoreP16"));
			PlayerPrefs.SetInt("lastScoreP16", PlayerPrefs.GetInt("lastScoreP15"));
			PlayerPrefs.SetInt("lastScoreP15", PlayerPrefs.GetInt("lastScoreP14"));
			PlayerPrefs.SetInt("lastScoreP14", PlayerPrefs.GetInt("lastScoreP13"));
			PlayerPrefs.SetInt("lastScoreP13", PlayerPrefs.GetInt("lastScoreP12"));
			PlayerPrefs.SetInt("lastScoreP12", PlayerPrefs.GetInt("lastScoreP11"));
			PlayerPrefs.SetInt("lastScoreP11", PlayerPrefs.GetInt("lastScoreP1"));
			//lower all score names
			PlayerPrefs.SetInt("bestPlayerP110", PlayerPrefs.GetInt("bestPlayerP19"));
			PlayerPrefs.SetInt("bestPlayerP19", PlayerPrefs.GetInt("bestPlayerP18"));
			PlayerPrefs.SetInt("bestPlayerP18", PlayerPrefs.GetInt("bestPlayerP17"));
			PlayerPrefs.SetInt("bestPlayerP17", PlayerPrefs.GetInt("bestPlayerP16"));
			PlayerPrefs.SetInt("bestPlayerP16", PlayerPrefs.GetInt("bestPlayerP15"));
			PlayerPrefs.SetInt("bestPlayerP15", PlayerPrefs.GetInt("bestPlayerP14"));
			PlayerPrefs.SetInt("bestPlayerP14", PlayerPrefs.GetInt("bestPlayerP13"));
			PlayerPrefs.SetInt("bestPlayerP13", PlayerPrefs.GetInt("bestPlayerP12"));
			PlayerPrefs.SetInt("bestPlayerP12", PlayerPrefs.GetInt("bestPlayerP11"));
			PlayerPrefs.SetInt("bestPlayerP11", PlayerPrefs.GetInt("bestPlayerP1"));
			
			
			PlayerPrefs.SetString("bestPlayerP1", NamePick.nameP1);
			PlayerPrefs.SetInt ("lastScoreP1", totalScoreP1);


		}
		if (totalScoreP1 < PlayerPrefs.GetInt("lastScoreP1") && totalScoreP1 > PlayerPrefs.GetInt("lastScoreP11")) {
			//lower all previous highscores
			PlayerPrefs.SetInt("lastScoreP110", PlayerPrefs.GetInt("lastScoreP19"));
			PlayerPrefs.SetInt("lastScoreP19", PlayerPrefs.GetInt("lastScoreP18"));
			PlayerPrefs.SetInt("lastScoreP18", PlayerPrefs.GetInt("lastScoreP17"));
			PlayerPrefs.SetInt("lastScoreP17", PlayerPrefs.GetInt("lastScoreP16"));
			PlayerPrefs.SetInt("lastScoreP16", PlayerPrefs.GetInt("lastScoreP15"));
			PlayerPrefs.SetInt("lastScoreP15", PlayerPrefs.GetInt("lastScoreP14"));
			PlayerPrefs.SetInt("lastScoreP14", PlayerPrefs.GetInt("lastScoreP13"));
			PlayerPrefs.SetInt("lastScoreP13", PlayerPrefs.GetInt("lastScoreP12"));
			PlayerPrefs.SetInt("lastScoreP12", PlayerPrefs.GetInt("lastScoreP11"));
			//lower all score names
			PlayerPrefs.SetInt("bestPlayerP110", PlayerPrefs.GetInt("bestPlayerP19"));
			PlayerPrefs.SetInt("bestPlayerP19", PlayerPrefs.GetInt("bestPlayerP18"));
			PlayerPrefs.SetInt("bestPlayerP18", PlayerPrefs.GetInt("bestPlayerP17"));
			PlayerPrefs.SetInt("bestPlayerP17", PlayerPrefs.GetInt("bestPlayerP16"));
			PlayerPrefs.SetInt("bestPlayerP16", PlayerPrefs.GetInt("bestPlayerP15"));
			PlayerPrefs.SetInt("bestPlayerP15", PlayerPrefs.GetInt("bestPlayerP14"));
			PlayerPrefs.SetInt("bestPlayerP14", PlayerPrefs.GetInt("bestPlayerP13"));
			PlayerPrefs.SetInt("bestPlayerP13", PlayerPrefs.GetInt("bestPlayerP12"));
			PlayerPrefs.SetInt("bestPlayerP12", PlayerPrefs.GetInt("bestPlayerP11"));

			
			
			PlayerPrefs.SetString("bestPlayerP11", NamePick.nameP1);
			PlayerPrefs.SetInt ("lastScoreP11", totalScoreP1);
		}
		if (totalScoreP1 < PlayerPrefs.GetInt("lastScoreP11") && totalScoreP1 > PlayerPrefs.GetInt("lastScoreP12")) {
			//lower all previous highscores
			PlayerPrefs.SetInt("lastScoreP110", PlayerPrefs.GetInt("lastScoreP19"));
			PlayerPrefs.SetInt("lastScoreP19", PlayerPrefs.GetInt("lastScoreP18"));
			PlayerPrefs.SetInt("lastScoreP18", PlayerPrefs.GetInt("lastScoreP17"));
			PlayerPrefs.SetInt("lastScoreP17", PlayerPrefs.GetInt("lastScoreP16"));
			PlayerPrefs.SetInt("lastScoreP16", PlayerPrefs.GetInt("lastScoreP15"));
			PlayerPrefs.SetInt("lastScoreP15", PlayerPrefs.GetInt("lastScoreP14"));
			PlayerPrefs.SetInt("lastScoreP14", PlayerPrefs.GetInt("lastScoreP13"));
			PlayerPrefs.SetInt("lastScoreP13", PlayerPrefs.GetInt("lastScoreP12"));
			//lower all score names
			PlayerPrefs.SetInt("bestPlayerP110", PlayerPrefs.GetInt("bestPlayerP19"));
			PlayerPrefs.SetInt("bestPlayerP19", PlayerPrefs.GetInt("bestPlayerP18"));
			PlayerPrefs.SetInt("bestPlayerP18", PlayerPrefs.GetInt("bestPlayerP17"));
			PlayerPrefs.SetInt("bestPlayerP17", PlayerPrefs.GetInt("bestPlayerP16"));
			PlayerPrefs.SetInt("bestPlayerP16", PlayerPrefs.GetInt("bestPlayerP15"));
			PlayerPrefs.SetInt("bestPlayerP15", PlayerPrefs.GetInt("bestPlayerP14"));
			PlayerPrefs.SetInt("bestPlayerP14", PlayerPrefs.GetInt("bestPlayerP13"));
			PlayerPrefs.SetInt("bestPlayerP13", PlayerPrefs.GetInt("bestPlayerP12"));

			
			
			PlayerPrefs.SetString("bestPlayerP12", NamePick.nameP1);
			PlayerPrefs.SetInt ("lastScoreP12", totalScoreP1);
		}
		if (totalScoreP1 < PlayerPrefs.GetInt("lastScoreP12") && totalScoreP1 > PlayerPrefs.GetInt("lastScoreP13")) {
			//lower all previous highscores
			PlayerPrefs.SetInt("lastScoreP110", PlayerPrefs.GetInt("lastScoreP19"));
			PlayerPrefs.SetInt("lastScoreP19", PlayerPrefs.GetInt("lastScoreP18"));
			PlayerPrefs.SetInt("lastScoreP18", PlayerPrefs.GetInt("lastScoreP17"));
			PlayerPrefs.SetInt("lastScoreP17", PlayerPrefs.GetInt("lastScoreP16"));
			PlayerPrefs.SetInt("lastScoreP16", PlayerPrefs.GetInt("lastScoreP15"));
			PlayerPrefs.SetInt("lastScoreP15", PlayerPrefs.GetInt("lastScoreP14"));
			PlayerPrefs.SetInt("lastScoreP14", PlayerPrefs.GetInt("lastScoreP13"));
			//lower all score names
			PlayerPrefs.SetInt("bestPlayerP110", PlayerPrefs.GetInt("bestPlayerP19"));
			PlayerPrefs.SetInt("bestPlayerP19", PlayerPrefs.GetInt("bestPlayerP18"));
			PlayerPrefs.SetInt("bestPlayerP18", PlayerPrefs.GetInt("bestPlayerP17"));
			PlayerPrefs.SetInt("bestPlayerP17", PlayerPrefs.GetInt("bestPlayerP16"));
			PlayerPrefs.SetInt("bestPlayerP16", PlayerPrefs.GetInt("bestPlayerP15"));
			PlayerPrefs.SetInt("bestPlayerP15", PlayerPrefs.GetInt("bestPlayerP14"));
			PlayerPrefs.SetInt("bestPlayerP14", PlayerPrefs.GetInt("bestPlayerP13"));
			
			
			PlayerPrefs.SetString("bestPlayerP13", NamePick.nameP1);
			PlayerPrefs.SetInt ("lastScoreP13", totalScoreP1);
		}
		if (totalScoreP1 < PlayerPrefs.GetInt("lastScoreP13") && totalScoreP1 > PlayerPrefs.GetInt("lastScoreP14")) {
			//lower all previous highscores
			PlayerPrefs.SetInt("lastScoreP110", PlayerPrefs.GetInt("lastScoreP19"));
			PlayerPrefs.SetInt("lastScoreP19", PlayerPrefs.GetInt("lastScoreP18"));
			PlayerPrefs.SetInt("lastScoreP18", PlayerPrefs.GetInt("lastScoreP17"));
			PlayerPrefs.SetInt("lastScoreP17", PlayerPrefs.GetInt("lastScoreP16"));
			PlayerPrefs.SetInt("lastScoreP16", PlayerPrefs.GetInt("lastScoreP15"));
			PlayerPrefs.SetInt("lastScoreP15", PlayerPrefs.GetInt("lastScoreP14"));
			//lower all score names
			PlayerPrefs.SetInt("bestPlayerP110", PlayerPrefs.GetInt("bestPlayerP19"));
			PlayerPrefs.SetInt("bestPlayerP19", PlayerPrefs.GetInt("bestPlayerP18"));
			PlayerPrefs.SetInt("bestPlayerP18", PlayerPrefs.GetInt("bestPlayerP17"));
			PlayerPrefs.SetInt("bestPlayerP17", PlayerPrefs.GetInt("bestPlayerP16"));
			PlayerPrefs.SetInt("bestPlayerP16", PlayerPrefs.GetInt("bestPlayerP15"));
			PlayerPrefs.SetInt("bestPlayerP15", PlayerPrefs.GetInt("bestPlayerP14"));



			PlayerPrefs.SetString("bestPlayerP14", NamePick.nameP1);
			PlayerPrefs.SetInt ("lastScoreP14", totalScoreP1);
		}
		if (totalScoreP1 < PlayerPrefs.GetInt("lastScoreP14") && totalScoreP1 > PlayerPrefs.GetInt("lastScoreP15")) {
			//lower all previous highscores
			PlayerPrefs.SetInt("lastScoreP110", PlayerPrefs.GetInt("lastScoreP19"));
			PlayerPrefs.SetInt("lastScoreP19", PlayerPrefs.GetInt("lastScoreP18"));
			PlayerPrefs.SetInt("lastScoreP18", PlayerPrefs.GetInt("lastScoreP17"));
			PlayerPrefs.SetInt("lastScoreP17", PlayerPrefs.GetInt("lastScoreP16"));
			PlayerPrefs.SetInt("lastScoreP16", PlayerPrefs.GetInt("lastScoreP15"));
			//lower all score names
			PlayerPrefs.SetInt("bestPlayerP110", PlayerPrefs.GetInt("bestPlayerP19"));
			PlayerPrefs.SetInt("bestPlayerP19", PlayerPrefs.GetInt("bestPlayerP18"));
			PlayerPrefs.SetInt("bestPlayerP18", PlayerPrefs.GetInt("bestPlayerP17"));
			PlayerPrefs.SetInt("bestPlayerP17", PlayerPrefs.GetInt("bestPlayerP16"));
			PlayerPrefs.SetInt("bestPlayerP16", PlayerPrefs.GetInt("bestPlayerP15"));

			
			PlayerPrefs.SetString("bestPlayerP15", NamePick.nameP1);
			PlayerPrefs.SetInt ("lastScoreP15", totalScoreP1);
		}
		if (totalScoreP1 < PlayerPrefs.GetInt("lastScoreP15") && totalScoreP1 > PlayerPrefs.GetInt("lastScoreP16")) {
			//lower all previous highscores
			PlayerPrefs.SetInt("lastScoreP110", PlayerPrefs.GetInt("lastScoreP19"));
			PlayerPrefs.SetInt("lastScoreP19", PlayerPrefs.GetInt("lastScoreP18"));
			PlayerPrefs.SetInt("lastScoreP18", PlayerPrefs.GetInt("lastScoreP17"));
			PlayerPrefs.SetInt("lastScoreP17", PlayerPrefs.GetInt("lastScoreP16"));
			//lower all score names
			PlayerPrefs.SetInt("bestPlayerP110", PlayerPrefs.GetInt("bestPlayerP19"));
			PlayerPrefs.SetInt("bestPlayerP19", PlayerPrefs.GetInt("bestPlayerP18"));
			PlayerPrefs.SetInt("bestPlayerP18", PlayerPrefs.GetInt("bestPlayerP17"));
			PlayerPrefs.SetInt("bestPlayerP17", PlayerPrefs.GetInt("bestPlayerP16"));
	
			
			PlayerPrefs.SetString("bestPlayerP16", NamePick.nameP1);
			PlayerPrefs.SetInt ("lastScoreP16", totalScoreP1);
		}
		if (totalScoreP1 < PlayerPrefs.GetInt("lastScoreP16") && totalScoreP1 > PlayerPrefs.GetInt("lastScoreP17")) {
			//lower all previous highscores
			PlayerPrefs.SetInt("lastScoreP110", PlayerPrefs.GetInt("lastScoreP19"));
			PlayerPrefs.SetInt("lastScoreP19", PlayerPrefs.GetInt("lastScoreP18"));
			PlayerPrefs.SetInt("lastScoreP18", PlayerPrefs.GetInt("lastScoreP17"));
			//lower all score names
			PlayerPrefs.SetInt("bestPlayerP110", PlayerPrefs.GetInt("bestPlayerP19"));
			PlayerPrefs.SetInt("bestPlayerP19", PlayerPrefs.GetInt("bestPlayerP18"));
			PlayerPrefs.SetInt("bestPlayerP18", PlayerPrefs.GetInt("bestPlayerP17"));

			
			PlayerPrefs.SetString("bestPlayerP17", NamePick.nameP1);
			PlayerPrefs.SetInt ("lastScoreP17", totalScoreP1);
		}
		if (totalScoreP1 < PlayerPrefs.GetInt("lastScoreP17") && totalScoreP1 > PlayerPrefs.GetInt("lastScoreP18")) {
			//lower all previous highscores
			PlayerPrefs.SetInt("lastScoreP110", PlayerPrefs.GetInt("lastScoreP19"));
			PlayerPrefs.SetInt("lastScoreP19", PlayerPrefs.GetInt("lastScoreP18"));
			//lower all score names
			PlayerPrefs.SetInt("bestPlayerP110", PlayerPrefs.GetInt("bestPlayerP19"));
			PlayerPrefs.SetInt("bestPlayerP19", PlayerPrefs.GetInt("bestPlayerP18"));

			
			PlayerPrefs.SetString("bestPlayerP18", NamePick.nameP1);
			PlayerPrefs.SetInt ("lastScoreP18", totalScoreP1);
		}
		if (totalScoreP1 < PlayerPrefs.GetInt("lastScoreP18") && totalScoreP1 > PlayerPrefs.GetInt("lastScoreP19")) {
			//lower all previous highscores
			PlayerPrefs.SetInt("lastScoreP110", PlayerPrefs.GetInt("lastScoreP19"));
			//lower all score names
			PlayerPrefs.SetInt("bestPlayerP110", PlayerPrefs.GetInt("bestPlayerP19"));

			
			
			PlayerPrefs.SetString("bestPlayerP19", NamePick.nameP1);
			PlayerPrefs.SetInt ("lastScoreP19", totalScoreP1);
		}
		if (totalScoreP1 < PlayerPrefs.GetInt("lastScoreP19") && totalScoreP1 > PlayerPrefs.GetInt("lastScoreP110")) {
			PlayerPrefs.SetString("bestPlayerP110", NamePick.nameP1);
			PlayerPrefs.SetInt ("lastScoreP110", totalScoreP1);
		}
		





		if (totalScoreP2 > PlayerPrefs.GetInt("lastScoreP2")) {
			//lower all previous highscores
			PlayerPrefs.SetInt("lastScoreP2bgf10", PlayerPrefs.GetInt("lastScoreP29"));
			PlayerPrefs.SetInt("lastScoreP29", PlayerPrefs.GetInt("lastScoreP28"));
			PlayerPrefs.SetInt("lastScoreP28", PlayerPrefs.GetInt("lastScoreP27"));
			PlayerPrefs.SetInt("lastScoreP27", PlayerPrefs.GetInt("lastScoreP26"));
			PlayerPrefs.SetInt("lastScoreP26", PlayerPrefs.GetInt("lastScoreP25"));
			PlayerPrefs.SetInt("lastScoreP25", PlayerPrefs.GetInt("lastScoreP24"));
			PlayerPrefs.SetInt("lastScoreP24", PlayerPrefs.GetInt("lastScoreP23"));
			PlayerPrefs.SetInt("lastScoreP23", PlayerPrefs.GetInt("lastScoreP22"));
			PlayerPrefs.SetInt("lastScoreP22", PlayerPrefs.GetInt("lastScoreP21"));
			PlayerPrefs.SetInt("lastScoreP21", PlayerPrefs.GetInt("lastScoreP2"));
			//lower all score names
			PlayerPrefs.SetInt("bestPlayerP210", PlayerPrefs.GetInt("bestPlayerP29"));
			PlayerPrefs.SetInt("bestPlayerP29", PlayerPrefs.GetInt("bestPlayerP28"));
			PlayerPrefs.SetInt("bestPlayerP28", PlayerPrefs.GetInt("bestPlayerP27"));
			PlayerPrefs.SetInt("bestPlayerP27", PlayerPrefs.GetInt("bestPlayerP26"));
			PlayerPrefs.SetInt("bestPlayerP26", PlayerPrefs.GetInt("bestPlayerP25"));
			PlayerPrefs.SetInt("bestPlayerP25", PlayerPrefs.GetInt("bestPlayerP24"));
			PlayerPrefs.SetInt("bestPlayerP24", PlayerPrefs.GetInt("bestPlayerP23"));
			PlayerPrefs.SetInt("bestPlayerP23", PlayerPrefs.GetInt("bestPlayerP22"));
			PlayerPrefs.SetInt("bestPlayerP22", PlayerPrefs.GetInt("bestPlayerP21"));
			PlayerPrefs.SetInt("bestPlayerP21", PlayerPrefs.GetInt("bestPlayerP2"));
			
			
			PlayerPrefs.SetString("bestPlayerP2", NamePick.nameP2);
			PlayerPrefs.SetInt ("lastScoreP2", totalScoreP2);
		}
		if (totalScoreP2 < PlayerPrefs.GetInt("lastScoreP2") && totalScoreP2 > PlayerPrefs.GetInt("lastScoreP21")) {2
			PlayerPrefs.SetInt("lastScoreP29", PlayerPrefs.GetInt("lastScoreP28"));
			PlayerPrefs.SetInt("lastScoreP28", PlayerPrefs.GetInt("lastScoreP27"));
			PlayerPrefs.SetInt("lastScoreP27", PlayerPrefs.GetInt("lastScoreP26"));
			PlayerPrefs.SetInt("lastScoreP26", PlayerPrefs.GetInt("lastScoreP25"));
			PlayerPrefs.SetInt("lastScoreP25", PlayerPrefs.GetInt("lastScoreP24"));
			PlayerPrefs.SetInt("lastScoreP24", PlayerPrefs.GetInt("lastScoreP23"));
			PlayerPrefs.SetInt("lastScoreP23", PlayerPrefs.GetInt("lastScoreP22"));
			PlayerPrefs.SetInt("lastScoreP22", PlayerPrefs.GetInt("lastScoreP21"));
			//lower all score names
			PlayerPrefs.SetInt("bestPlayerP210", PlayerPrefs.GetInt("bestPlayerP29"));
			PlayerPrefs.SetInt("bestPlayerP29", PlayerPrefs.GetInt("bestPlayerP28"));
			PlayerPrefs.SetInt("bestPlayerP28", PlayerPrefs.GetInt("bestPlayerP27"));
			PlayerPrefs.SetInt("bestPlayerP27", PlayerPrefs.GetInt("bestPlayerP26"));
			PlayerPrefs.SetInt("bestPlayerP26", PlayerPrefs.GetInt("bestPlayerP25"));
			PlayerPrefs.SetInt("bestPlayerP25", PlayerPrefs.GetInt("bestPlayerP24"));
			PlayerPrefs.SetInt("bestPlayerP24", PlayerPrefs.GetInt("bestPlayerP23"));
			PlayerPrefs.SetInt("bestPlayerP23", PlayerPrefs.GetInt("bestPlayerP22"));
			PlayerPrefs.SetInt("bestPlayerP22", PlayerPrefs.GetInt("bestPlayerP21"));
			
			
			PlayerPrefs.SetString("bestPlayerP21", NamePick.nameP2);
			PlayerPrefs.SetInt ("lastScoreP21", totalScoreP2);
		}
		if (totalScoreP2 < PlayerPrefs.GetInt("lastScoreP21") && totalScoreP2 > PlayerPrefs.GetInt("lastScoreP22")) {
			PlayerPrefs.SetInt("lastScoreP210", PlayerPrefs.GetInt("lastScoreP29"));
			PlayerPrefs.SetInt("lastScoreP29", PlayerPrefs.GetInt("lastScoreP28"));
			PlayerPrefs.SetInt("lastScoreP28", PlayerPrefs.GetInt("lastScoreP27"));
			PlayerPrefs.SetInt("lastScoreP27", PlayerPrefs.GetInt("lastScoreP26"));
			PlayerPrefs.SetInt("lastScoreP26", PlayerPrefs.GetInt("lastScoreP25"));
			PlayerPrefs.SetInt("lastScoreP25", PlayerPrefs.GetInt("lastScoreP24"));
			PlayerPrefs.SetInt("lastScoreP24", PlayerPrefs.GetInt("lastScoreP23"));
			PlayerPrefs.SetInt("lastScoreP23", PlayerPrefs.GetInt("lastScoreP22"));
			//lower all score names
			PlayerPrefs.SetInt("bestPlayerP210", PlayerPrefs.GetInt("bestPlayerP29"));
			PlayerPrefs.SetInt("bestPlayerP29", PlayerPrefs.GetInt("bestPlayerP28"));
			PlayerPrefs.SetInt("bestPlayerP28", PlayerPrefs.GetInt("bestPlayerP27"));
			PlayerPrefs.SetInt("bestPlayerP27", PlayerPrefs.GetInt("bestPlayerP26"));
			PlayerPrefs.SetInt("bestPlayerP26", PlayerPrefs.GetInt("bestPlayerP25"));
			PlayerPrefs.SetInt("bestPlayerP25", PlayerPrefs.GetInt("bestPlayerP24"));
			PlayerPrefs.SetInt("bestPlayerP24", PlayerPrefs.GetInt("bestPlayerP23"));
			PlayerPrefs.SetInt("bestPlayerP23", PlayerPrefs.GetInt("bestPlayerP22"));
			
			
			PlayerPrefs.SetString("bestPlayerP22", NamePick.nameP2);
			PlayerPrefs.SetInt ("lastScoreP22", totalScoreP2);
		}
		if (totalScoreP2 < PlayerPrefs.GetInt("lastScoreP22") && totalScoreP2 > PlayerPrefs.GetInt("lastScoreP23")) {
			PlayerPrefs.SetInt("lastScoreP210", PlayerPrefs.GetInt("lastScoreP29"));
			PlayerPrefs.SetInt("lastScoreP29", PlayerPrefs.GetInt("lastScoreP28"));
			PlayerPrefs.SetInt("lastScoreP28", PlayerPrefs.GetInt("lastScoreP27"));
			PlayerPrefs.SetInt("lastScoreP27", PlayerPrefs.GetInt("lastScoreP26"));
			PlayerPrefs.SetInt("lastScoreP26", PlayerPrefs.GetInt("lastScoreP25"));
			PlayerPrefs.SetInt("lastScoreP25", PlayerPrefs.GetInt("lastScoreP24"));
			PlayerPrefs.SetInt("lastScoreP24", PlayerPrefs.GetInt("lastScoreP23"));
			//lower all score names
			PlayerPrefs.SetInt("bestPlayerP210", PlayerPrefs.GetInt("bestPlayerP29"));
			PlayerPrefs.SetInt("bestPlayerP29", PlayerPrefs.GetInt("bestPlayerP28"));
			PlayerPrefs.SetInt("bestPlayerP28", PlayerPrefs.GetInt("bestPlayerP27"));
			PlayerPrefs.SetInt("bestPlayerP27", PlayerPrefs.GetInt("bestPlayerP26"));
			PlayerPrefs.SetInt("bestPlayerP26", PlayerPrefs.GetInt("bestPlayerP25"));
			PlayerPrefs.SetInt("bestPlayerP25", PlayerPrefs.GetInt("bestPlayerP24"));
			PlayerPrefs.SetInt("bestPlayerP24", PlayerPrefs.GetInt("bestPlayerP23"));

			
			PlayerPrefs.SetString("bestPlayerP23", NamePick.nameP2);
			PlayerPrefs.SetInt ("lastScoreP23", totalScoreP2);
		}
		if (totalScoreP2 < PlayerPrefs.GetInt("lastScoreP23") && totalScoreP2 > PlayerPrefs.GetInt("lastScoreP24")) {
			PlayerPrefs.SetInt("lastScoreP210", PlayerPrefs.GetInt("lastScoreP29"));
			PlayerPrefs.SetInt("lastScoreP29", PlayerPrefs.GetInt("lastScoreP28"));
			PlayerPrefs.SetInt("lastScoreP28", PlayerPrefs.GetInt("lastScoreP27"));
			PlayerPrefs.SetInt("lastScoreP27", PlayerPrefs.GetInt("lastScoreP26"));
			PlayerPrefs.SetInt("lastScoreP26", PlayerPrefs.GetInt("lastScoreP25"));
			PlayerPrefs.SetInt("lastScoreP25", PlayerPrefs.GetInt("lastScoreP24"));
			//lower all score names
			PlayerPrefs.SetInt("bestPlayerP210", PlayerPrefs.GetInt("bestPlayerP29"));
			PlayerPrefs.SetInt("bestPlayerP29", PlayerPrefs.GetInt("bestPlayerP28"));
			PlayerPrefs.SetInt("bestPlayerP28", PlayerPrefs.GetInt("bestPlayerP27"));
			PlayerPrefs.SetInt("bestPlayerP27", PlayerPrefs.GetInt("bestPlayerP26"));
			PlayerPrefs.SetInt("bestPlayerP26", PlayerPrefs.GetInt("bestPlayerP25"));
			PlayerPrefs.SetInt("bestPlayerP25", PlayerPrefs.GetInt("bestPlayerP24"));


			PlayerPrefs.SetString("bestPlayerP24", NamePick.nameP2);
			PlayerPrefs.SetInt ("lastScoreP24", totalScoreP2);
		}
		if (totalScoreP2 < PlayerPrefs.GetInt("lastScoreP24") && totalScoreP2 > PlayerPrefs.GetInt("lastScoreP25")) {
			PlayerPrefs.SetInt("lastScoreP210", PlayerPrefs.GetInt("lastScoreP29"));
			PlayerPrefs.SetInt("lastScoreP29", PlayerPrefs.GetInt("lastScoreP28"));
			PlayerPrefs.SetInt("lastScoreP28", PlayerPrefs.GetInt("lastScoreP27"));
			PlayerPrefs.SetInt("lastScoreP27", PlayerPrefs.GetInt("lastScoreP26"));
			PlayerPrefs.SetInt("lastScoreP26", PlayerPrefs.GetInt("lastScoreP25"));
			//lower all score names
			PlayerPrefs.SetInt("bestPlayerP210", PlayerPrefs.GetInt("bestPlayerP29"));
			PlayerPrefs.SetInt("bestPlayerP29", PlayerPrefs.GetInt("bestPlayerP28"));
			PlayerPrefs.SetInt("bestPlayerP28", PlayerPrefs.GetInt("bestPlayerP27"));
			PlayerPrefs.SetInt("bestPlayerP27", PlayerPrefs.GetInt("bestPlayerP26"));
			PlayerPrefs.SetInt("bestPlayerP26", PlayerPrefs.GetInt("bestPlayerP25"));


			PlayerPrefs.SetString("bestPlayerP25", NamePick.nameP2);
			PlayerPrefs.SetInt ("lastScoreP25", totalScoreP2);
		}
		if (totalScoreP2 < PlayerPrefs.GetInt("lastScoreP25") && totalScoreP2 > PlayerPrefs.GetInt("lastScoreP26")) {
			PlayerPrefs.SetInt("lastScoreP210", PlayerPrefs.GetInt("lastScoreP29"));
			PlayerPrefs.SetInt("lastScoreP29", PlayerPrefs.GetInt("lastScoreP28"));
			PlayerPrefs.SetInt("lastScoreP28", PlayerPrefs.GetInt("lastScoreP27"));
			PlayerPrefs.SetInt("lastScoreP27", PlayerPrefs.GetInt("lastScoreP26"));
			//lower all score names
			PlayerPrefs.SetInt("bestPlayerP210", PlayerPrefs.GetInt("bestPlayerP29"));
			PlayerPrefs.SetInt("bestPlayerP29", PlayerPrefs.GetInt("bestPlayerP28"));
			PlayerPrefs.SetInt("bestPlayerP28", PlayerPrefs.GetInt("bestPlayerP27"));
			PlayerPrefs.SetInt("bestPlayerP27", PlayerPrefs.GetInt("bestPlayerP26"));
			
			
			PlayerPrefs.SetString("bestPlayerP26", NamePick.nameP2);
			PlayerPrefs.SetInt ("lastScoreP26", totalScoreP2);
		}
		if (totalScoreP2 < PlayerPrefs.GetInt("lastScoreP26") && totalScoreP2 > PlayerPrefs.GetInt("lastScoreP27")) {
			PlayerPrefs.SetInt("lastScoreP210", PlayerPrefs.GetInt("lastScoreP29"));
			PlayerPrefs.SetInt("lastScoreP29", PlayerPrefs.GetInt("lastScoreP28"));
			PlayerPrefs.SetInt("lastScoreP28", PlayerPrefs.GetInt("lastScoreP27"));
			//lower all score names
			PlayerPrefs.SetInt("bestPlayerP210", PlayerPrefs.GetInt("bestPlayerP29"));
			PlayerPrefs.SetInt("bestPlayerP29", PlayerPrefs.GetInt("bestPlayerP28"));
			PlayerPrefs.SetInt("bestPlayerP28", PlayerPrefs.GetInt("bestPlayerP27"));
			
			
			PlayerPrefs.SetString("bestPlayerP27", NamePick.nameP2);
			PlayerPrefs.SetInt ("lastScoreP27", totalScoreP2);
		}
		if (totalScoreP2 < PlayerPrefs.GetInt("lastScoreP27") && totalScoreP2 > PlayerPrefs.GetInt("lastScoreP28")) {
			PlayerPrefs.SetInt("lastScoreP210", PlayerPrefs.GetInt("lastScoreP29"));
			PlayerPrefs.SetInt("lastScoreP29", PlayerPrefs.GetInt("lastScoreP28"));
			//lower all score names
			PlayerPrefs.SetInt("bestPlayerP210", PlayerPrefs.GetInt("bestPlayerP29"));
			PlayerPrefs.SetInt("bestPlayerP29", PlayerPrefs.GetInt("bestPlayerP28"));
			
			
			PlayerPrefs.SetString("bestPlayerP28", NamePick.nameP2);
			PlayerPrefs.SetInt ("lastScoreP28", totalScoreP2);
		}
		if (totalScoreP2 < PlayerPrefs.GetInt("lastScoreP28") && totalScoreP2 > PlayerPrefs.GetInt("lastScoreP29")) {
			PlayerPrefs.SetInt("lastScoreP210", PlayerPrefs.GetInt("lastScoreP29"));
			//lower all score names
			PlayerPrefs.SetInt("bestPlayerP210", PlayerPrefs.GetInt("bestPlayerP29"));
			
			
			PlayerPrefs.SetString("bestPlayerP29", NamePick.nameP2);
			PlayerPrefs.SetInt ("lastScoreP29", totalScoreP2);
		}
		if (totalScoreP2 < PlayerPrefs.GetInt("lastScoreP29") && totalScoreP2 > PlayerPrefs.GetInt("lastScoreP210")) {
			PlayerPrefs.SetString("bestPlayerP210", NamePick.nameP2);
			PlayerPrefs.SetInt ("lastScoreP210", totalScoreP2);
		}
		/*if (PlayerPrefs.GetInt ("lastScoreP1") > PlayerPrefs.GetInt ("lastScoreP2")) {
			highScore.text = ("HighScore:" + PlayerPrefs.GetString ("bestPlayerP1") + " - " + PlayerPrefs.GetInt ("lastScoreP1")).ToString ();
		} else {
			highScore.text = ("HighScore:" + PlayerPrefs.GetString ("bestPlayerP2") + " - " + PlayerPrefs.GetInt ("lastScoreP2")).ToString ();
		}*/

		
		//Timers get reset
		if (timerSeconds <= 0){
			timerSeconds = 60;
			timerMinutes = timerMinutes - 1;
		}

		if (timerMinutes > -1) {
			timeInMinutesText.text = (timerMinutes + ":" + timerSeconds).ToString ();
		} else {
			timeInMinutesText.text = ("Time Is Up!").ToString ();
		}

		Debug.Log (PlayerPrefs.GetString("bestPlayerP1"));
		Debug.Log (PlayerPrefs.GetInt("lastScoreP1"));


		//Check if the P2 is able to fight if so, he can else he can not
		//P2 Does Damage in this section
		if (stopFight == false) {
			if (fightTimerP2 <= 0) {
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
					StartCoroutine (armDamageDealerP1 ());
					StartCoroutine (leftArmDamageP1());
				}
				if (Input.GetButton ("RightUpperArmP2Hit") && Input.GetButton ("LeftArmP2")) {
					fightTimerP2 = 1f;
					StartCoroutine (armDamageDealerP1 ());
					StartCoroutine (rightArmDamageP1());
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
				} else {//do nothing
				}
			}

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
					StartCoroutine (armDamageDealerP1 ());
					StartCoroutine (leftArmDamageP1());
				}
				if (Input.GetButton ("RightUpperArmP2Hit") && Input.GetButton ("RightArmP2")) {
					fightTimerP2 = 1f;
					StartCoroutine (armDamageDealerP1 ());
					StartCoroutine (rightArmDamageP1());
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
				} else {//do nothing
				}

				

			//Check if the P1 is able to fight if so, he can else he can not
			//P1 Does Damage in this section
			if (stopFight == false) {
				if (fightTimerP1 <= 0) {
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
						StartCoroutine (armDamageDealerP2 ());
						StartCoroutine(leftArmDamageP2());
					}
					if (Input.GetButton ("RightUpperArmP1Hit") && Input.GetButton ("LeftArmP1")) {
						fightTimerP1 = 1f;
						StartCoroutine (armDamageDealerP2 ());
						StartCoroutine(rightArmDamageP2());
					}
					if (Input.GetButton ("LeftSideP1Hit") && Input.GetButton ("LeftArmP1")) {
						fightTimerP1 = 1f;
						StartCoroutine (LeftSideDamageP2 ());
						StartCoroutine (sideDamageDealerP2 ());

					}
					if (Input.GetButton ("RightSideP1Hit") && Input.GetButton ("LeftArmP1")) {
						fightTimerP1 = 1f;
						StartCoroutine (RightSideDamageP2 ());
						StartCoroutine (sideDamageDealerP2 ());

					} else {//do nothing
					}
				}

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
						StartCoroutine (armDamageDealerP2 ());
						StartCoroutine(leftArmDamageP2());
					}
					if (Input.GetButton ("RightUpperArmP1Hit") && Input.GetButton ("RightArmP1")) {
						fightTimerP1 = 1f;
						StartCoroutine (armDamageDealerP2 ());
						StartCoroutine(rightArmDamageP2());
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
					} else {
						//do nothing
					}


		
			}
		}
	}
	//look who won
	void lookWhoWon(){
		if(totalScoreP1 > totalScoreP2){
			wonP1.SetActive (true);
		}
		else{
			wonP2.SetActive (true);
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
	public IEnumerator leftArmDamageP1(){
		leftUpperArmP1.SetActive (true);
		yield return new WaitForSeconds (0.75f);
		leftUpperArmP1.SetActive (false);
	}
	public IEnumerator rightArmDamageP1(){
		rightUpperArmP1.SetActive (true);
		yield return new WaitForSeconds (0.75f);
		rightUpperArmP1.SetActive (false);
	}
	
	//These IEnumerators give the points to P2 if P1 is hit
	public IEnumerator headDamageDealerP1(){
		totalScoreP2 = totalScoreP2 + headScoreP2;
		yield return new WaitForSeconds (0.02f);
		StopCoroutine (headDamageDealerP1());
	}
	public IEnumerator sideDamageDealerP1(){
		totalScoreP2 = totalScoreP2 + sideScoreP2;
		yield return new WaitForSeconds (0.02f);
		StopCoroutine (sideDamageDealerP1());
	}
	public IEnumerator armDamageDealerP1(){
		totalScoreP2 = totalScoreP2 + armScoreP2;
		yield return new WaitForSeconds (0.02f);
		StopCoroutine(armDamageDealerP1());

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
	public IEnumerator leftArmDamageP2(){
		leftUpperArmP2.SetActive (true);
		yield return new WaitForSeconds (0.75f);
		leftUpperArmP2.SetActive (false);
	}
	public IEnumerator rightArmDamageP2(){
		rightUpperArmP2.SetActive (true);
		yield return new WaitForSeconds (0.75f);
		rightUpperArmP2.SetActive (false);
	}
	
	//These IEnumerators deal the damage to P2
	public IEnumerator headDamageDealerP2(){
		totalScoreP1 = totalScoreP1 + headScoreP1;
		yield return new WaitForSeconds (0.02f);
		StopCoroutine (headDamageDealerP2());
	}
	public IEnumerator sideDamageDealerP2(){
		totalScoreP1 = totalScoreP1 + sideScoreP1;
		yield return new WaitForSeconds (0.02f);
		StopCoroutine (sideDamageDealerP2());
	}
	public IEnumerator armDamageDealerP2(){
		totalScoreP1 = totalScoreP1 + armScoreP1;
		yield return new WaitForSeconds (0.02f);
		StopCoroutine (armDamageDealerP2 ());
	}


	////////////
	////////////
	////////////
	 
	//Timer 
	public IEnumerator timerParty(){
		yield return new WaitForSeconds (20f);
		StartCoroutine (endTheGame ());
	}
	/*public IEnumerator timeInMinutes(){
		yield return new WaitForSeconds (60);
		timerMinutes = timerMinutes - 1;
		StartCoroutine (timeInMinutes());
	}*/
	public IEnumerator timeInSeconds(){
		yield return new WaitForSeconds (1f);
		timerSeconds = timerSeconds - 1f;
		StartCoroutine (timeInSeconds());
	}

	//End Game!
	public IEnumerator endTheGame(){
		lookWhoWon ();
		yield return new WaitForSeconds (5);
		Application.LoadLevel ("replayParty");
	}
}