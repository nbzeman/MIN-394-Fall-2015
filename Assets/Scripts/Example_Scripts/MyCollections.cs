using UnityEngine;
using System.Collections;
using System.Collections.Generic;//using this for Lists
using System.Linq;//using for flexible collection management

public class MyCollections : MonoBehaviour {

	//built-in arrays
	public int [] ints;//I have not declared a number of slots for this array
	public int[] ints_set_number = new int[5];//I have declared the amount of slots for this array but not values for those slots
	private int[] ints_sets_values = {79,32,22,43,4,12,16,18,44};//set the number of slots, AND the values going into those slots

	//gameobjects
	public GameObject[] spheres;
	public GameObject [] spheres_set_number = new GameObject[3];
	public GameObject [] spheres_autoFind;


	//lists
	public List<string> string_list = new List<string>();
	public List<string> string_list_values = new List<string>(){"zero","one","two","three"};
	public List<Rigidbody> rgbs = new List<Rigidbody>();

	// Use this for initialization
	void Start () {

		//uses the Linq classes to sort and average data from a list

		print ("average is " + ints_sets_values.Average ());
		print ("Minimum value is " + ints_sets_values.Min ());
		print ("Maximum value is " + ints_sets_values.Max ());

		//load all of the rigid bodies in the sphere array into the rgbs array
		for (int i=0; i<spheres_set_number.Length; i++) {

			print (spheres_set_number[i].name + " " + i);
			spheres_set_number[i].GetComponent<Renderer>().material.color = new Color(0,1,0);
		}


		foreach (GameObject g in spheres_set_number) {
			if(g.GetComponent<Rigidbody>() != null){
			rgbs.Add (g.GetComponent<Rigidbody>());
			g.GetComponent<Rigidbody>().AddForce(Vector3.up*200);
			}
		}

	}
	
	// Update is called once per frame
	void Update () {
	

	}
}
