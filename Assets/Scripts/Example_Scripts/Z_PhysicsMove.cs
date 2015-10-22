﻿using UnityEngine;
using System.Collections;

public class Z_PhysicsMove : MonoBehaviour {

	public float moveSpeed = 1.0f;
	public float turnSpeed = 1.0f;
	public float upForce = 12;
	public Rigidbody rb;
	public GameObject go;
	// Use this for initialization
	void Start () {

		//loads the rigidbody component of THIS GAMEOBJECT to the variable rb
		rb = this.gameObject.GetComponent<Rigidbody> ();

	}
	
	// Update is called once per frame
	void Update () {
	
		float ty = transform.eulerAngles.y;
		transform.localEulerAngles = new Vector3 (0, ty += Input.GetAxis ("Horizontal")*turnSpeed, 0);
		if (Input.GetKey ("up")) {

			transform.Translate(0,0,moveSpeed,Space.Self);
		}
		if (Input.GetKey ("down")) {
			
			transform.Translate(0,0,-moveSpeed,Space.Self);
		}
		if (Input.GetButton ("Jump") && rb!= null) {

			rb.AddForce(0,upForce,0);
		}

	}
}
