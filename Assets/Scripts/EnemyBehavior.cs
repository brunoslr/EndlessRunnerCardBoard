using UnityEngine;
using System.Collections;

namespace UnitySampleAssets._2D
{
    public class EnemyBehavior : MonoBehaviour
    {
        void FixedUpdate()
        {
        	float rate = 0.025f;
			Vector3 velocity = this.GetComponent<Rigidbody2D>().velocity;
        	
	        velocity.x += rate;
	        this.GetComponent<Rigidbody2D>().velocity = velocity;

        }

		void OnTriggerEnter2D(Collider2D other)
		{
			if(other.tag == "Player")
			{
				Debug.Log("HIT");
				//Application.Quit();
			}		
		}
    }
}
