using UnityEngine;
using System.Collections;

public class Z_PointConstraint : MonoBehaviour {

	public Transform target;
	public float offsetX=0;
	public float offsetY=0;
	public float offsetZ=0;

	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 point = new Vector3 (target.position.x + offsetX, target.position.y + offsetY, target.position.z + offsetZ);
		transform.position = point;

	}
}
