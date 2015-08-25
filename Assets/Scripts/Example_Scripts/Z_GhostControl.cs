using UnityEngine;
using System.Collections;

public class Z_GhostControl : MonoBehaviour {

	public Animator ani;
	public float mult=1;
	public Transform underguy;

	// Use this for initialization
	void Start () {
	
		ani = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
	
		//controls the pan and forward/backward movement of object
		transform.Translate (-Input.GetAxis ("Horizontal")*mult, 0, -Input.GetAxis ("Vertical")*mult, Space.Self);
		underguy.transform.localEulerAngles= new Vector3 (0, 0, Input.GetAxis ("Horizontal") * 35);

		//Triggers the spin action of the animation
		if(Input.GetKeyDown("space")){
			ani.SetTrigger("spinTrigger");//trigger this parameter
		}
		//Triggers the forward lean animation
		if (Input.GetAxis ("Vertical") > 0) {
			ani.SetBool ("leanForward", true);
		} else {
			ani.SetBool("leanForward",false);
		}

	}
}
