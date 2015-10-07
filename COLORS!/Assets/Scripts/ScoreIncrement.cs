using UnityEngine;
using System.Collections;

public class ScoreIncrement : MonoBehaviour {

	int score;

	// Use this for initialization
	void Start () {
		score = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public int getScore() {
		return score;
	}

	public void incrementScore (){
		score++;
	}

	public void resetScore (){
		score = 0;
	}
}
