using UnityEngine;
using System.Collections;

public class AniControl : MonoBehaviour {

	private Animator ani;
	public float mult = 1;

	// Use this for initialization
	void Start () {

		ani = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {

		//controls the pan and forward/backward movement of object
		transform.Translate (-Input.GetAxis ("Horizontal")*mult, 0, -Input.GetAxis ("Vertical")*mult, Space.Self);

		//check for spacebar and trigger animation spin
		if (Input.GetButtonDown ("Jump")) {
			ani.SetTrigger("spinTrigger");
		}
	}
}
