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
		private float timeGap;
		public float timeIntervalForSpeedIncrement;
		public float speedIncrement;
		private GameObject cam;

        private void Awake()
        {
            character = GetComponent<PlatformerCharacter2D>();
        }

        void Start()
        {
			timeGap = Time.timeSinceLevelLoad;
			cam = GameObject.Find("Main Camera");
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

			if((Time.timeSinceLevelLoad - timeGap) > timeIntervalForSpeedIncrement && speed <= 6.0f)
			{
				speed += speedIncrement;
				timeGap = Time.timeSinceLevelLoad;
				if(cam.GetComponent<AudioSource>().audio.pitch < 1.1f)
					cam.GetComponent<AudioSource>().audio.pitch += 0.03f;
			}
        }

        private void FixedUpdate()
        {
            character.Move(speed * Time.deltaTime, false, jump);
            jump = false;
        }

        public float getSpeed()
        {
            return (speed * Time.deltaTime);

        }
    }
}