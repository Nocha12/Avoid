using UnityEngine;
using System.Collections;

public class FirstScr : MonoBehaviour {

	void Awake()
	{
		Screen.SetResolution( 1920, 1080, true );

		Move.MoveMethod = PlayerPrefs.GetInt ("MoveMethod", 1);
		PlayerPrefs.Save ();

		if (PlayerPrefs.HasKey ("PlaySpeed")) {
			Slide.Play_Speed = PlayerPrefs.GetFloat ("PlaySpeed", 0);
			PlayerPrefs.Save ();
		}
	}

	void Update () {
		if(Application.platform.Equals(RuntimePlatform.Android))
			if(Input.GetKey(KeyCode.Escape))
				Application.Quit();

		if (Input.touchCount > 0 || Input.GetMouseButtonDown(0)) 
		{
			Application.LoadLevel("SelectPlayOrHow");
		}
	}
}
