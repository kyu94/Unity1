﻿using UnityEngine;
using System.Collections;

public class StartClickHandler : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Vector2 mousePosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			Collider2D hitCollider = Physics2D.OverlapPoint(mousePosition);

			if (hitCollider) {
				Application.LoadLevel("level1");
			}
		}
	}
}
