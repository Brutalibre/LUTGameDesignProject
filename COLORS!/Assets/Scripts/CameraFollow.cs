using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public GameObject gray;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(gray.transform.position.x + 2,gray.transform.position.y + 2,transform.position.z);
	}
}
