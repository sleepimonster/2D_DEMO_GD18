using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMoveScript : MonoBehaviour {

	// Background scroll speed can be set in Inspector with slider
	[Range(1f, 20f)]
	public float scrollSpeed = 1f;
	float a;
	// Scroll offset value to smoothly repeat backgrounds movement
	public float scrollOffset;

	// Start position of background movement
	//Vector2 startPos;

	// Backgrounds new position
	//float newPos;

	// Use this for initialization
	void Start () {
		// Getting backgrounds start position
		//startPos = transform.position;
	}
	

	void Update () {
		a += Input.GetAxis("Horizontal");
		Vector2 offset = new Vector2(a*scrollSpeed, 0);
		GetComponent<MeshRenderer>().material.mainTextureOffset = offset;
	}
}
