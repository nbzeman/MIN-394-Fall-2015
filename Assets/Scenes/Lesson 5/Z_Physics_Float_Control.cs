using UnityEngine;
using System.Collections;

public class Z_Physics_Float_Control : MonoBehaviour {

	Rigidbody rb;
	public float force = 35;
	// Use this for initialization
	void Start () {

		rb = this.gameObject.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKey ("space")) {

			rb.AddForce(0,force,0);
		}


	}
}
