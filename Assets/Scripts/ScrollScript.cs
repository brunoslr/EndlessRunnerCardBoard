using UnityEngine;
using System.Collections;

namespace UnitySampleAssets._2D
{
    public class ScrollScript : MonoBehaviour
    {
        public float speed = 0;
		public Transform player;
        public float positionY;
        public float positionZ;
        private Vector2 textureOffset;
		
        void Start()
        {
            textureOffset = new Vector2(0, 0);
        }
		
        void Update() 
		{

       		speed = player.GetComponent<PlayerBehavior>().getSpeed();
            textureOffset.x = (textureOffset.x - (speed/100f));
            renderer.material.mainTextureOffset = textureOffset;
            	
		}
	}
}