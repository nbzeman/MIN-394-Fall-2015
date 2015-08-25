using UnityEngine;
using System.Collections;

public class HitBalls : MonoBehaviour {

	public GameObject[] spheres;


	// Use this for initialization
	void Start () {

		spheres = GameObject.FindGameObjectsWithTag ("sphere");
	
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKey("n")){//if the n key is pressed down
			foreach (GameObject b in spheres) {//for every gameobject in the spheres array
				if(b.GetComponent<Rigidbody>() != null){//if there is a rigidbody in existence
					b.GetComponent<Rigidbody>().AddRelativeTorque(120,0,0);//add a relative torque to the rigid body
				}
			}
		}
	}
}
