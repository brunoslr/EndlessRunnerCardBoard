using UnityEngine;
using System.Collections;
using UnitySampleAssets.CrossPlatformInput;

namespace UnitySampleAssets._2D
{

    [RequireComponent(typeof(PlatformerCharacter2D))]
    public class PlayerBehavior : MonoBehaviour
    {
  		public float speed = 1;
        private PlatformerCharacter2D character;
        private bool jump;

        private void Awake()
        {
            character = GetComponent<PlatformerCharacter2D>();
        }

        void Update()
        {
            if (!jump)
                // Read the jump input in Update so button presses aren't missed.
                jump = CrossPlatformInputManager.GetButtonDown("Jump");
        }

        private void FixedUpdate()
        {
            character.Move(speed * Time.deltaTime, false, jump);
			Debug.Log(jump);
            jump = false;
        }

        public float getSpeed()
        {
            return (speed * Time.deltaTime);

        }
    }
}