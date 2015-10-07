using UnityEngine;
using System.Collections;

public class SideCollide : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider trig){
		//moveScript = trig.gameObject.GetComponent<MoveForward> ();

		if (trig.gameObject.name == "Cube") {
			MoveForward script = trig.gameObject.GetComponent<MoveForward>();
			Debug.Log ("You're dead ");
			script.enabled = false;
		}
		//moveScript.enabled = false;

	}
}
