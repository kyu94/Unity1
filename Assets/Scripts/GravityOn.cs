using UnityEngine;
using System.Collections;

public class GravityOn : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	
	void OnTriggerEnter2D(Collider2D other) {
		
		if (other.tag == "Player") {
			other.gameObject.GetComponent<PlatformerCharacter2D>().isInZeroGRoom = false;
			Physics2D.gravity = new Vector2(0, -9.81f);
		}
		
	}
}
