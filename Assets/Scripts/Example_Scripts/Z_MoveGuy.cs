using UnityEngine;
using System.Collections;

public class Z_MoveGuy : MonoBehaviour {

	public float moveMult=1;
	public GUIText axisValue;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


//		if (Input.GetButton ("BBB")) {
//
//			axisValue.text = "BBB Pressed";
//
//		} else {
//
//			axisValue.text = "BBB Unpressed";
//
//		}

		if (Input.GetButtonDown ("BBB")) {
			axisValue.text = "BBB Down";
			print ("Button Down");
		}else if(Input.GetButton("BBB")){
			axisValue.text = "BBB Pressed";
			print ("Button Pressed");
		}else if(Input.GetButtonUp ("BBB")){
			axisValue.text = "BBB Up";
			print ("Button Up");
		} else {
			axisValue.text = "BBB Unpressed";

		}


//		if (Input.GetButton ("BBB") || Input.GetButtonDown ("BBB")) {
//			axisValue.text = "BBB Down";
//		} else if (Input.GetButtonUp ("BBB")) {
//			axisValue.text = "BBB Up";
//		} else {
//			axisValue.text = "BBB Up";
//		}

//		if (Input.GetKey ("space")) {//sets up input for the upward thrust
//
//			this.gameObject.GetComponent<Rigidbody>().AddForce(0,15,0);
//		}

		//this.transform.Translate (Input.GetAxis ("Horizontal")/moveMult, 0, Input.GetAxis ("Vertical")/moveMult);//moves the object based on the Horizontal Axis

		//axisValue.text = Input.GetAxis ("Horizontal").ToString();
	
	}
}
