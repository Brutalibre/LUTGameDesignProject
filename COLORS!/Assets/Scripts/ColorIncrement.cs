using UnityEngine;
using System.Collections;

public class ColorIncrement : MonoBehaviour {

	int colors;

	public GameObject red;
	public GameObject orange;
	public GameObject yellow;
	public GameObject green;
	public GameObject blue;
	public GameObject indigo;
	public GameObject violet;

	// Use this for initialization
	void Start () {
		colors = 0;
		resetColors ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public int getColors() {
		return colors;
	}
	
	public void incrementColors () {
		colors++;
		activateColor (colors);
	}
	
	public void resetColors () {
		colors = 0;
		red.SetActive(false);
		orange.SetActive(false);
		yellow.SetActive(false);
		green.SetActive(false);
		blue.SetActive(false);
		indigo.SetActive(false);
		violet.SetActive(false);
	}

	public void activateColor(int colors){
		switch(colors){
		case 1:
			red.SetActive(true);
			break;
			
		case 2:
			orange.SetActive(true);
			break;
			
		case 3:
			yellow.SetActive(true);
			break;
			
		case 4:
			green.SetActive(true);
			break;
			
		case 5:
			blue.SetActive(true);
			break;
			
		case 6:
			indigo.SetActive(true);
			break;
			
		case 7: 
			violet.SetActive(true);
			break;
			
		default:
			resetColors();
			break;
		}
	}
}