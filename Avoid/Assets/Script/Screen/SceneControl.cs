using UnityEngine;
using System.Collections;

public class SceneControl : MonoBehaviour
{
	public void GoToHowToPlay()
	{
		Application.LoadLevel("HowToPlay");
	}

	public void GoToSelectMode()
	{
		Application.LoadLevel("SelectPlayMode");
	}

	public void GoToEasyMode()
	{
		GameObject.Find ("HowBackGroundMoved").GetComponent<HowBackGroundMoved>().nowMode = 1;
		Application.LoadLevel("LoadScene");
	}

	public void GoToHardMode()
	{
		GameObject.Find ("HowBackGroundMoved").GetComponent<HowBackGroundMoved>().nowMode = 2;
		Application.LoadLevel("LoadScene");
	}

	public void GoToInfinityMode()
	{
		GameObject.Find ("HowBackGroundMoved").GetComponent<HowBackGroundMoved>().nowMode = 3;
		Application.LoadLevel("LoadScene");
	}
}
