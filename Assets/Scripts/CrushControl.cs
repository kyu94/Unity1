using UnityEngine;
using System.Collections;

public class CrushControl : MonoBehaviour {

	public Transform topBox;
	public Transform bottomBox;

	bool open;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Vector3.Distance (topBox.position, bottomBox.position) <= 1) {
			open = true;		
		} else if (Vector3.Distance (topBox.position, transform.position) <= 1) {
			open = false;			
		}
	
	}

	void FixedUpdate() {
		
		if (open) {
			topBox.Translate (Vector3.up * .03f);
			bottomBox.Translate (Vector3.down * .03f);		
		} else {
			topBox.Translate (Vector3.down * .03f);
			bottomBox.Translate (Vector3.up * .03f);
		}
	}
}
