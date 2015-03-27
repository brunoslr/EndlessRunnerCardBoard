using UnityEngine;
using System.Collections;

public class Enemymanager : MonoBehaviour {
public GameObject spawnEnemy;
public GameObject currentEnemy;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
		if(currentEnemy == null)
		{
			currentEnemy = Instantiate(spawnEnemy) as GameObject;
		}
	}
}
