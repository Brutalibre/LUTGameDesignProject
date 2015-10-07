using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIScore : MonoBehaviour {

	public ScoreIncrement scoreScript;
	Text text;

	void Awake(){
		text = GetComponent<Text> ();

		text.text = "Score: " ;
	}

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		text.text = "Score: " + scoreScript.getScore();
	}
}
