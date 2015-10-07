using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Dead : MonoBehaviour {

	Camera cam;

	public ScoreIncrement scoreScript;
	public ColorIncrement colorScript;

	public MoveForward moveGrayScript;
	public MoveForward moveCamScript;

	public AudioSource musicGO;

	public Transform grayTransform;

	public GameObject loseScreen;
	public Text loseText;

	// Use this for initialization
	void Start () {
		cam = GetComponent<Camera> ();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 viewPos = cam.WorldToViewportPoint (grayTransform.position);
		if (viewPos.x < 0 || viewPos.y < 0 || viewPos.y > 1) {

			musicGO.Pause();
			moveGrayScript.StopMoving();
			moveCamScript.StopMoving();
			loseScreen.SetActive(true);
			loseText.text = "Colors : " + colorScript.getColors() + "\nScore : " + scoreScript.getScore();

		}
	}
}
