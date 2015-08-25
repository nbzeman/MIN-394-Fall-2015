using UnityEngine;
using System.Collections;

public class Z_TriggerMultiSounds : MonoBehaviour {
	
	AudioSource audio;
	public AudioClip[] sounds;
	public int sound2play;
	
	// Use this for initialization
	void Start () {
		
		audio = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnCollisionEnter(Collision thing){
		
		if (thing.gameObject.tag == "Player") {
			
			//audio.Play ();
			audio.PlayOneShot(sounds[sound2play]);
		}
	}
}