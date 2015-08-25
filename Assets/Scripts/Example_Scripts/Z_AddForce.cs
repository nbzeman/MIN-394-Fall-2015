using UnityEngine;
using System.Collections;

public class Z_AddForce : MonoBehaviour {

	public Rigidbody rb;

	// Use this for initialization
	void Start () {
	
		rb = this.gameObject.GetComponent<Rigidbody> ();

	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey ("g")) {
			rb.AddForce(0,0,12);
			rb.AddRelativeTorque(12,0,0);
		}

	
	}
}
