using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {
	public bool isQuitButton = false;
	public bool magnetDetectionEnabled = true;
	private GameObject Button;

	void Start()
	{
		CardboardMagnetSensor.SetEnabled(magnetDetectionEnabled);
		// Disable screen dimming:
		Screen.sleepTimeout = SleepTimeout.NeverSleep;
	}
	
	void Update()
	{
		if (!magnetDetectionEnabled) return;
		if (CardboardMagnetSensor.CheckIfWasClicked())
		{
			if (isQuitButton) {
				Application.Quit ();
				
			}

			CardboardMagnetSensor.ResetClick();
		}
	}

	public void StartGame()
	{
	
		Application.LoadLevel ("MainScene");

	}

	public void UpdateQuitFlag()
	{
		isQuitButton = true;
	}

	public void QuitGame()
	{
		Application.Quit ();
	}

}
