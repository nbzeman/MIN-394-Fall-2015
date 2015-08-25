using UnityEngine;
using System.Collections;

public class MoveEyeGuyInY : MonoBehaviour {


	public float mult = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetButton("Jump")){
			this.transform.Translate(0,mult,0);
		}
		if (!Input.GetButton ("Jump") && this.transform.position.y >= 1) {

			this.transform.position = Vector3.Lerp (this.transform.position,new Vector3(0,1,0),Time.deltaTime * 2.5f);
		}
	
	}
}
