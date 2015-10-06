using UnityEngine;
using System.Collections;

public class Z_OnTrigger_Enter : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnTriggerEnter(Collider thing){

		print (thing.gameObject.name + " collided with " + this.gameObject.name);

		if (thing.gameObject.tag == "Player") {

			print ("TRIGGER ENTERED");

		}

	}

	void OnTriggerStay(Collider thing){
		
		print (thing.gameObject.name + " is colliding with " + this.gameObject.name);
		
		if (thing.gameObject.tag == "Player") {
			
			print ("TRIGGER STAY");
			
		}
		
	}

	void OnTriggerExit(Collider thing){
		
		print (thing.gameObject.name + " is exiting a collision with " + this.gameObject.name);
		
		if (thing.gameObject.tag == "Player") {
			
			print ("TRIGGER LEAVE");
			
		}
		
	}


}
