using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class GameObjectsToCollections : MonoBehaviour {


	public GameObject[] spheres;
	public Light[] lights;
	public List<Rigidbody> rigids;

	// Use this for initialization
	void Start () {
	

		spheres = GameObject.FindGameObjectsWithTag ("sphere");//get all Game Object items with game tag into spheres Array
		lights = GameObject.FindObjectsOfType<Light> ();

		foreach (GameObject b in spheres) {
			if(b.GetComponent<Rigidbody>() != null){//if gameobject has rigid body
				rigids.Add(b.GetComponent<Rigidbody>());//append that rigid body to the list
			}
		}

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
