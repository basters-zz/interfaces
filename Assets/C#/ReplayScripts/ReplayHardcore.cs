using UnityEngine;
using System.Collections;

public class ReplayHardcore : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void clickReplay(){
		Application.LoadLevel ("realis");
	}
	public void clickMainMenu(){
		Application.LoadLevel ("mainmenu");
	}
}
