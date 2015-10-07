using UnityEngine;
using System.Collections;

public class FollowGray : MonoBehaviour {

	public Transform gray_transf;
	float relPos;
	public float offset;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		relPos = gray_transf.transform.position.x - gameObject.transform.position.x;
		gameObject.transform.Translate(new Vector3(relPos - offset, 0, 0));
	}
}
