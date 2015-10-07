using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Collide : MonoBehaviour {

	public GameObject scoreGO;
	public AudioSource musicGO;
	public AudioSource dropGO;
	public AudioSource breakGO;

	public MoveForward moveGrayScript;
	public MoveForward moveCamScript;

	public GameObject winScreen;
	public Text winText;

	private ScoreIncrement scoreScript;
	private ColorIncrement colorScript;
	private ChangeMusic musicScript;

	// Use this for initialization
	void Start () {
		scoreScript = scoreGO.GetComponent<ScoreIncrement> ();
		colorScript = scoreGO.GetComponent<ColorIncrement> ();
		musicScript = musicGO.GetComponent<ChangeMusic> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider col){
//		if (col.gameObject.name == "3x1block" || col.gameObject.name == "1x1block") {
//			Debug.Log ("collision " + col.gameObject.name);
//			moveScript.enabled = false;
//		}
		Debug.Log ("collision " + col.gameObject.name);
		if (col.gameObject.tag == "Drop") {
			dropGO.Play ();
			scoreScript.incrementScore();
			Destroy (col.gameObject);
		}

		if (col.gameObject.tag == "Wall") {
			breakGO.Play ();
			colorScript.incrementColors();
			musicScript.SwitchColors(colorScript.getColors());


			//moveCamScript.IncrementSpeed();
			//moveGrayScript.IncrementSpeed();

			Destroy (col.gameObject);

			// END OF THE GAME
			if(col.gameObject.name == "Violet Wall"){
				musicGO.Pause();
				moveGrayScript.StopMoving();
				moveCamScript.StopMoving();
				winScreen.SetActive(true);
				winText.text = "Colors : 7\nScore : " + scoreScript.getScore();
			}
		}
	}
}
