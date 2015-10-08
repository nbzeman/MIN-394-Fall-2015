using UnityEngine;
using System.Collections;

public class Z_OnTrigger_Enter : MonoBehaviour {

	public Rigidbody sphere0;
	public Rigidbody sphere1;
	public Rigidbody sphere2;
	
	public float zForce=5;
	public float explosiveForce = 10;


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
			sphere0.constraints = RigidbodyConstraints.FreezeAll;


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
			
			print (thing.gameObject.name + " Is Exiting " + this.gameObject.name);

			sphere0.constraints = RigidbodyConstraints.None;//unfreeze constraints
			sphere0.AddForce(0,0,zForce);


			sphere1.AddExplosionForce(explosiveForce,thing.transform.position,0,1000);
			sphere2.AddExplosionForce(explosiveForce,thing.transform.position,0,1000);

			
		}
		
	}


}
