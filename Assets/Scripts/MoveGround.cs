using UnityEngine;
using System.Collections;

public class MoveGround : MonoBehaviour {

	public Transform player;
	public float positionY;
	public float positionZ;
	// Update is called once per frame
	void Update () 
	{
		transform.position = new Vector3 (player.position.x -20, positionY, positionZ);
	}
}
