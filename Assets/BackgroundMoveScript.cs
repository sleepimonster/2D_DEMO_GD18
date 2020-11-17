using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMoveScript : MonoBehaviour {

	// Background scroll speed can be set in Inspector with slider
	[Range(1f, 20f)]
	public float scrollSpeed = 1f;
	public GameObject player;
	// Scroll offset value to smoothly repeat backgrounds movement
	public float scrollOffset;

	Vector2 startPos;
	Vector2 playerPos;
	float newPos;
	// Use this for initialization
	void Start () {
		// Getting backgrounds start position
		
		startPos = transform.position;
		Debug.Log("playerPos" + playerPos);
		Debug.Log("startPos" + startPos);
	}
	
	
	void Update () {
		playerPos = player.transform.position;
		if(playerPos.x > startPos.x)
			{
				transform.position = startPos + Vector2.right;
				startPos = transform.position;
			}
		Debug.Log("start.X" + startPos.x);

	}
}
