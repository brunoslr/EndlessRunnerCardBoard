using UnityEngine;
using System.Collections;


public class MainMenu : MonoBehaviour {
	public bool isQuitButton = false;
	void OnMouseEnter()
	{
		GetComponent<Renderer>().material.color = Color.blue;
	}

	void OnMouseExit()
	{
		GetComponent<Renderer>().material.color = Color.white;
	}

	void OnMouseUp()
	{
		if (isQuitButton) {
			Application.Quit ();
		} else {
			Application.LoadLevel ("Base");
		}
	}
}
