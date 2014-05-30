using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	public Transform leftAnchor;
	public Transform rightAnchor;
	bool direction;
	
	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Vector3.Distance (transform.position, leftAnchor.position) <= 1) {
			direction = true;
		} else if (Vector3.Distance (transform.position, rightAnchor.position) <= 1) {
			direction = false;
		}
		
	}
	
	void FixedUpdate ()
	{
		if (direction) {
			transform.Translate (Vector3.right * .07f);
		} else {
			transform.Translate (Vector3.left  * .07f);
		}
	}
}
