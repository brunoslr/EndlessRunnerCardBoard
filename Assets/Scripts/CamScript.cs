using UnityEngine;
using System.Collections;

public class CamScript : MonoBehaviour 
{
	public int i =8;
	public GameObject player;

	void Update () 
	{

   	    transform.position = new Vector3(player.gameObject.transform.position.x + 6, 0, -10);	

	}
}
