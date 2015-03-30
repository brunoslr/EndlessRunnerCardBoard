using UnityEngine;
using System.Collections;

public class Enemymanager : MonoBehaviour 
{
	public GameObject spawnEnemy;
	private GameObject currentEnemy;

	void Update () 
	{
		if(currentEnemy == null)
		{
			currentEnemy = Instantiate(spawnEnemy) as GameObject;
		}
	}
}
