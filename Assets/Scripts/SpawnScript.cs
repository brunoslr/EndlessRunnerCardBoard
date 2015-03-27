using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour 
{
	public GameObject [] SpawnObjects = new GameObject[2];
	public int RandomNumber;
	public GameObject EnemyObj;


	void Start () 
	{
		InvokeRepeating("SpawnStuff",1f,Random.Range(2f,4f));
	}
	

	void Update () 
	{
		if(EnemyObj==null)
		{
				Instantiate(EnemyObj);
		}
	}

	void SpawnStuff()
	{
		RandomNumber = Random.Range(0,2);
		GameObject spawn = Instantiate (SpawnObjects [RandomNumber],new Vector3(this.transform.position.x,SpawnObjects [RandomNumber].transform.position.y,this.transform.position.z), SpawnObjects [RandomNumber].transform.rotation) as GameObject;
		//spawn.transform.localScale = new Vector3(0.7f,0.7f,0.7f);

		//SpawnObjects [RandomNumber] = GameObject.Instantiate ();
//		if(SpawnObjects[RandomNumber].name == "TrashCan")
//		{
//			SpawnObjects[RandomNumber].transform.position = new Vector3(7f,7f,7f);
//			SpawnObjects[RandomNumber].transform.position = new Vector3(this.transform.position.x,this.transform.position.y,this.transform.position.z);
//		}
	}
}
