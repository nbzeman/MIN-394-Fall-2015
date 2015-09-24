using UnityEngine;
using System.Collections;

public class Z_3rdPersonController : MonoBehaviour {

	//sin float controls
	public float sinTest;
	public float amp;
	public float offset;
	public float freq;

	//input multipliers
	public float rotMultY = 1;
	public float rotMultZ = 1;

	public float transMultZ = 1;
	public float transMultX = 1;

	
	//external transforms
	public Transform tilt;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		//creates the sin function to give the wave-like motion to the Y axis of the ghost
		sinTest =   (  (Mathf.Sin (Time.time * freq)  ) * amp ) + offset;
		//assign the sinTest value to the Y translate of the ghost position, passes through current values of the x and z
		transform.position = new Vector3 (transform.position.x , sinTest, transform.position.z);



		//this will translate the local Z based on the Vertical axis in the Unity Input Manager and the local X based on the horizontal input
		transform.Translate (Input.GetAxis ("Strafe") * transMultX, 0, Input.GetAxis ("Vertical") * transMultZ, Space.Self);



		//this will rotate the object in the positive or negative Y axis (Euler) based on the Mouse X input from Unity's input manager
		transform.Rotate (0, Input.GetAxis ("Horizontal") * rotMultY, 0);

		//this will provide the tilting effect for the Tilt transform
		tilt.localEulerAngles = new Vector3(Input.GetAxis ("Rocker") * 21, 0, -Input.GetAxis("Strafe")*20);





	}
}
