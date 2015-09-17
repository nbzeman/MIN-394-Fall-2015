using UnityEngine;
using System.Collections;

public class Z_3rdPersonController : MonoBehaviour {


	public float rotMultY = 1;
	public float transMultZ = 1;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	

		//this will translate the local Z based on the Vertical axis in the Unity Input Manager
		transform.Translate (0, 0, Input.GetAxis ("Vertical") * transMultZ, Space.Self);

		if (Input.GetMouseButton (1)) {
			//this will rotate the object in the positive or negative Y axis (Euler) based on the Mouse X input from Unity's input manager
			transform.Rotate (0, Input.GetAxis ("Mouse X") * rotMultY, 0);
		}


	}
}
