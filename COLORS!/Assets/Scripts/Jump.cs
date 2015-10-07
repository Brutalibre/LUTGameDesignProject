using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {

	GameObject gray;
	Rigidbody gray_rb;
	private bool onGround;
	public int force = 500;

	void Start(){
		onGround = false;
		gray = gameObject;
		gray_rb = gray.GetComponent<Rigidbody> ();
	}

	void Update() {
	
		if (onGround) {
			if (Input.GetMouseButtonDown (0))
				gray_rb.AddForce (new Vector3 (0, force, 0));
		}

	}

	void OnCollisionEnter(Collision col) {
		//Debug.Log("collision with " + col.collider.name);

		if (col.collider.tag == "Ground")
			onGround = true;
	}

	void OnCollisionStay(Collision col){
		//Debug.Log ("collision with " + col.collider.name);
		
		if (col.collider.tag == "Ground")
			onGround = true;
	}

	void OnCollisionExit(Collision col){

		if (col.collider.tag == "Ground")
			onGround = false;
	}
}
