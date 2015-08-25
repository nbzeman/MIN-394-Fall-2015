using UnityEngine;
using System.Collections;

public class TriggerSound : MonoBehaviour {

	AudioSource audio;


	// Use this for initialization
	void Start () {

		audio = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision thing){

		if (thing.gameObject.tag == "Player") {

			audio.Play ();
		}
	}
}
