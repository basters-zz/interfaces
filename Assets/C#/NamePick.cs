using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NamePick : MonoBehaviour {

	public static string nameP1;
	public static string nameP2;
	public Text nameP1NotStatic;
	public Text nameP2NotStatic;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		nameP1 = nameP1NotStatic.text;
		nameP2 = nameP2NotStatic.text;
		Debug.Log (nameP1);
		Debug.Log (nameP2);
	}
	public void clickPlay(){
		Application.LoadLevel ("partyMode");
	}
}
