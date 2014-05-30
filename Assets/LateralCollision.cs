using UnityEngine;
using System.Collections;

public class LateralCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		Vector3 front = transform.TransformDirection (Vector3.forward);
		if(Physics.Raycast(transform.position, fwd, 10) {
			print ("Cast is working!");
		}

	}
}
