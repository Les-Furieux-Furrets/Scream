using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {

	private bool isPaused = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetKeyDown (KeyCode.Escape))
			isPaused = !isPaused;
	
	if (isPaused) {
			Time.timeScale = 0f;

		}	
		else
			Time.timeScale = 1.0f;

	}

	void OnGUI ()
	{
		if(isPaused)
		{
		if(GUI.Button (new Rect(Screen.width / 2 - 40, Screen.height / 2- 60, 80, 40), "Continuer"))
			{
				isPaused = false;
			}
		if(GUI.Button (new Rect(Screen.width / 2 - 40, Screen.height / 2 +20, 80, 40), "Quitter"))
			{
				Application.LoadLevel (0);
			}

	    }

	}
}
