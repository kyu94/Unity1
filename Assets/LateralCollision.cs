using UnityEngine;
using System.Collections;

public class LateralCollision : MonoBehaviour {
	
	private Vector3 front;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		front = new Vector3(transform.position.x + .1f, transform.position.y, transform.position.z);



	}
}
