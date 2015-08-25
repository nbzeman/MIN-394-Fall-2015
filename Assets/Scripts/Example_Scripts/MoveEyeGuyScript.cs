using UnityEngine;
using System.Collections;

public class MoveEyeGuyScript : MonoBehaviour {

	public float mult = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//logic-generated Input control
//		if (Input.GetAxis ("Horizontal") > 0) {
//			this.transform.Translate(mult,0,0);
//		}
//		if (Input.GetAxis ("Horizontal") < 0) {
//			this.transform.Translate(-mult,0,0);
//		}

		//transform-based Input Control
		float vecX = this.transform.position.x; 
		float vecZ = this.transform.position.z; 
		this.transform.position = new Vector3 (vecX += Input.GetAxis ("Horizontal")*mult, 1, vecZ += Input.GetAxis("Vertical")*mult);//set the Z of the object to the input axis

	}
}
