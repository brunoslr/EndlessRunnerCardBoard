﻿using UnityEngine;
using System.Collections;

public class CameraFollower : MonoBehaviour {

	public Transform player;
	// Update is called once per frame
	void Update () 
	{
		transform.position = new Vector3 (player.position.x + 6, 0, -10);
	}
}