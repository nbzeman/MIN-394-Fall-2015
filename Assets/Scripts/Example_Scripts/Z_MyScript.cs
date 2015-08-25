using UnityEngine;
using System.Collections;

public class Z_MyScript : MonoBehaviour {


	//Unity Variable types

	public GameObject myGO;
	public Transform myXform;
	public Camera myCam;
	public Light myLight;
	public Renderer myRenderer;
	public Material myMat;
	public Animator myAnim;
	public Vector3 myVec3 = new Vector3 (0, 0, 0);



	//universal vars
	public int myint = 0;
	public float myfloat = 1.1f;
	//public string mystring "string";

	// Use this for initialization
	void Start () {

		print ("the game has started");

	}

	void Awake (){


	}
	
	// Update is called once per frame
	void Update () {

		//print ("updated");
		print (myGO.transform.position);
		if (myGO.transform.position.y >= 2) {
			print ("Sphere Has Gone Too High! The value of Y is " + myGO.transform.position.y);
		}

	}
}
