﻿using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour {
	static int deaths = 0;
	public Transform player;

	private Vector3 playerPos;

	// Use this for initialization
	void Start () {

		playerPos = player.position;

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other) {

		if(other.tag.Equals("Player")) {
			other.gameObject.transform.position = playerPos;
			deaths++;
			Debug.Log(deaths);
		}
	}
}
