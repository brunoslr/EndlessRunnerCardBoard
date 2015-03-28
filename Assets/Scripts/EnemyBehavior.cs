using UnityEngine;
using System.Collections;

namespace UnitySampleAssets._2D
{
    public class EnemyBehavior : MonoBehaviour
    {
		private const string TWITTER_ADDRESS = "http://twitter.com/intent/tweet";
		private const string TWEET_LANGUAGE = "en"; 
		
		void ShareToTwitter (string textToDisplay)
		{
			Application.OpenURL(TWITTER_ADDRESS +
			                    "?text=" + WWW.EscapeURL(textToDisplay + (Time.time).ToString("#.##") + "#EndlessRunnerHighScore") +
			                    "&amp;lang=" + WWW.EscapeURL(TWEET_LANGUAGE));
		}

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
				ShareToTwitter("I JUST POSTED MY HIGH SCORE ON TWITTER: ");
				Application.Quit();
			}		
		}
    }
}
