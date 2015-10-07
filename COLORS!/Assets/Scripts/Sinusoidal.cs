using UnityEngine;
using System.Collections;

public class Sinusoidal : MonoBehaviour {

	public float frequency;
	public int x;
	public int y;
	public int z;
	Vector3 vector;

	// Use this for initialization
	void Start () {
		vector = new Vector3 (x, y, z);
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += (Mathf.Sin(2*Mathf.PI*frequency*Time.time) - Mathf.Sin(2*Mathf.PI*frequency*(Time.time - Time.deltaTime)))*vector;
	}
}
