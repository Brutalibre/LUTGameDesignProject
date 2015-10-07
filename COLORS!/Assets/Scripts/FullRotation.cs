using UnityEngine;
using System.Collections;

public class FullRotation : MonoBehaviour {

	float totalTime = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		totalTime += Time.deltaTime;

		transform.Rotate (new Vector3 (1, 0, 1));

	}
}
