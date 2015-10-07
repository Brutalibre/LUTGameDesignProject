using UnityEngine;
using System.Collections;

public class ChangeMusic : MonoBehaviour {

	public AudioClip kinetic;
	public AudioClip echo;
	public AudioClip concussive;
	public AudioClip bard;
	public AudioClip project;
	public AudioClip etheral;
	public AudioClip galaxy;

	AudioSource audioSource;


	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void SwitchColors(int color){
		switch(color+1){
		case 1:
			audioSource.clip = kinetic;
			break;
			
		case 2:
			audioSource.clip = echo;
			break;
			
		case 3:
			audioSource.clip = concussive;
			break;
			
		case 4:
			audioSource.clip = bard;
			break;
			
		case 5:
			audioSource.clip = project;
			break;
			
		case 6:
			audioSource.clip = etheral;
			break;
			
		case 7: 
			audioSource.clip = galaxy;
			break;
			
		default:
			audioSource.clip = kinetic;
			break;
		}
		
		audioSource.Play();
	}
}
