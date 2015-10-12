using UnityEngine;
using System.Collections;

public class MainMenuScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void clickStart(){
		Application.LoadLevel("realis");
	}
	public void clickStartParty(){
		Application.LoadLevel("NameChoose");
	}
	public void ClickExit(){
		Application.Quit ();
	}
}
