using UnityEngine;
using System.Collections;
namespace UnitySampleAssets._2D
{
	public class ObstacleScript : MonoBehaviour 
	{
		public float speed;
		private GameObject tempEnemy;
		private bool hit = false;
		private float timeGap;
		public float timeIntervalForSpeedIncrement;
		public float speedIncrement;
		private GameObject player;

		void Start()
		{
			timeGap = Time.timeSinceLevelLoad;
			player = GameObject.FindWithTag("Player");
		}	

		void Update () 
		{
			speed = player.GetComponent<PlayerBehavior>().getSpeed();	
			rigidbody2D.velocity = Vector3.left*speed*1000;
		}
		
		void OnTriggerEnter2D(Collider2D coll)
		{	
			if(coll.gameObject.tag == "Player")
			{
				hit = true;

				if(transform.rotation.z==0)
					transform.Rotate(Vector3.forward*-90);	

				if(this.gameObject.name == "TrashCan(Clone)")
					this.transform.position = new Vector3(this.transform.position.x, 2.9f, -5f);

			}

			if(coll.gameObject.tag == "Enemy" && hit == true)
			{	
				tempEnemy = coll.gameObject;
				coll.transform.position = new Vector3(coll.transform.position.x - 10f,coll.transform.position.y,coll.transform.position.z);
				hit = false;
				Invoke ("SlowDestroy",0.5f);
				
			}
		}
		
		void OnTriggerExit2D(Collider2D coll)
		{
			if(this.gameObject.name == "LightPole(Clone)")
				this.transform.position = new Vector3(this.transform.position.x, -3.5f, -5f);

		}

		void SlowDestroy()
		{
			Destroy(tempEnemy);
			Destroy(this.gameObject);
		}
	}
}
