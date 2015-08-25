using UnityEngine;
using System.Collections;

public class KnockWalls : MonoBehaviour {

	public GameObject wall;
	public Transform forcePoint;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision thing){

		if (thing.gameObject.tag == "Player") {
			print("COLLIDE");//prints a message to the console
			Rigidbody rb = wall.GetComponent<Rigidbody>();//defines rigidbody from Wall object
			rb.AddForceAtPosition(Vector3.forward*44,forcePoint.position);//create forward force at forcepoint position
		}
	}
}
