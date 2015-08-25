using UnityEngine;
using System.Collections;

public class Z_TriggerLight : MonoBehaviour {

	public Light spot;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider thing){//physics code checking for trigger collisions


		if (thing.gameObject.tag == "Player") {//if the tag of the penetrating object is "Player"

			spot.intensity = .01f;


		}
	}

	void OnTriggerExit(Collider thing){

		if (thing.gameObject.tag == "Player") {//if the tag of the penetrating object is "Player"
			
			spot.intensity = 0;
			
			
		}

	}

	void OnTriggerStay(Collider thing){

		if (thing.gameObject.tag == "Player") {//if the tag of the penetrating object is "Player"
			
			spot.intensity += .01f;

		}

	}




}
