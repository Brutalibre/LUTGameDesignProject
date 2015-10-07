using UnityEngine;
using System.Collections;

public class MoveForward : MonoBehaviour {

	float totalTime = 0;
	float dashTime;
	public float speed;
	public float dashSpeed;

	bool isDashing = false;
	public float dashDuration;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		totalTime += Time.deltaTime;
		float currentSpeed = speed;

		// DASH
		if (Input.GetMouseButtonDown (1)) {
			if(!isDashing){
				dashTime = 0;
				isDashing = true;
			}
		}

		if (isDashing) {
			dashTime = dashTime + Time.deltaTime;
			currentSpeed = dashSpeed;

			if(dashTime >= dashDuration) {
				isDashing = false;
			}
		}

		transform.Translate(new Vector3(currentSpeed * Time.deltaTime,0,0));
	}

	public void StopMoving(){
		speed = 0;
		dashSpeed = 0;
		dashDuration = 0;
	}

	public void IncrementSpeed(){
		speed++;
		dashSpeed++;
	}


}
