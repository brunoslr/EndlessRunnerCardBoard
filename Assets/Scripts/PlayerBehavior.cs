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
        public bool magnetDetectionEnabled = true;

        private void Awake()
        {
            character = GetComponent<PlatformerCharacter2D>();
        }

        void Start()
        {
            CardboardMagnetSensor.SetEnabled(magnetDetectionEnabled);
            // Disable screen dimming:
            Screen.sleepTimeout = SleepTimeout.NeverSleep;
        }

        void Update()
        {
            if (!magnetDetectionEnabled) return;
            if (CardboardMagnetSensor.CheckIfWasClicked() && !jump)
            {
                jump = true;
                CardboardMagnetSensor.ResetClick();
            }
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