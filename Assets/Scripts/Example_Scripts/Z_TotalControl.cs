using UnityEngine;
using System.Collections;

public class Z_TotalControl : MonoBehaviour {

	private Animator ani;
	public float mult = 1;

	// Use this for initialization
	void Start () {
	
		ani = GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {
	

		transform.Translate (-Input.GetAxis ("Horizontal")*mult, 0, -Input.GetAxis ("Vertical")*mult);

		if (Input.GetKeyDown ("up")) {

			ani.SetTrigger("leanForward");
		}
		if (Input.GetKeyUp ("up")) {
			
			ani.SetTrigger("leanBack");
		}
		if (Input.GetKeyDown ("space")) {
			ani.SetTrigger("spinTrigger");
		}

	}
}