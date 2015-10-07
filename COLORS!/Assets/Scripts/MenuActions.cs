using UnityEngine;
using System.Collections;

public class MenuActions : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void LoadLevel(string name){
		Application.LoadLevel (name);
	}

	public void ExitApplication() {
		Application.Quit();
	}
}
