using UnityEngine;
using System.Collections;

public class Z_CollisionLight : MonoBehaviour {

	public Light spot;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision thing){//physics code checking for trigger collisions
		
		
		if (thing.gameObject.tag == "Player") {//if the tag of the penetrating object is "Player"
			
			spot.color = Color.red;

			
		}
	}
	
	void OnCollisionExit(Collision thing){
		
		if (thing.gameObject.tag == "Player") {//if the tag of the penetrating object is "Player"
			
			spot.color = Color.white;
			
			
		}
		
	}
	
	void OnCollisionStay(Collision thing){
		
		if (thing.gameObject.tag == "Player") {//if the tag of the penetrating object is "Player"

			float tg = spot.color.g;
			spot.color = new Color(spot.color.r,tg+=.01f,spot.color.b);
			
		}
		
	}
}

