using UnityEngine;
using System.Collections;

public class YouLost : MonoBehaviour {
	//[SerializeField]
	public static GameObject p1won;
	public static GameObject p2won;
	public GameObject p1won1;
	public GameObject p2won1;
	// Use this for initialization
	void Start () {
		p1won = p1won1;
		p2won = p2won1;
		//GameObject.FindObjectOfType
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public static void YouLostp2(){
		p1won.SetActive (true);
	}
	public static void YouLostp1(){
		p2won.SetActive (true);
	}
	public static IEnumerator quitInTime(){
		yield return new WaitForSeconds(4);

	}

}
