using UnityEngine;
using System.Collections;

public class Z_float : MonoBehaviour {

	public float sinTest;
	public float amp;
	public float offset;
	public float freq;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//float sin = Mathf.Sin (Time.time);

		sinTest =   (  (Mathf.Sin (Time.time * freq)  ) * amp ) + offset;

		//transform.Translate (0, sinTest, 0);
		transform.position = new Vector3 (0, sinTest, 0);
	
	}
}
