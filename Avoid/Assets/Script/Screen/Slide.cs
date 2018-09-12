using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Slide : MonoBehaviour 
{
	public Slider slider;
	public GameObject BackBtn = null;
	public GameObject JoyStickBtn = null;
	public GameObject DragBtn = null;

	public static float Play_Speed = 0;

	void Start () {
		Time.timeScale = 0;

		if (PlayerPrefs.HasKey ("PlaySpeed")) {
			slider.value = PlayerPrefs.GetFloat ("PlaySpeed", 0);
			PlayerPrefs.Save ();
		}
		Move.MoveMethod = PlayerPrefs.GetInt ("MoveMethod", 1);
			
		if (Move.MoveMethod.Equals (1)) {
			DragBtn.SetActive (true);
			JoyStickBtn.SetActive (false);
		} else {
			DragBtn.SetActive (false);
			JoyStickBtn.SetActive (true);
		}
		PlayerPrefs.Save ();
	}

	void Update () {
		Play_Speed = slider.value;
		PlayerPrefs.SetFloat ("PlaySpeed", slider.value);

		if(Application.platform.Equals(RuntimePlatform.Android))
			if(Input.GetKey(KeyCode.Escape))
				Application.LoadLevel("LoadScene");
	}

	public void Go_Game()
	{
		Application.LoadLevel("LoadScene");
	}

	public void ChangeMoveMethod()
	{
		Move.MoveMethod = PlayerPrefs.GetInt ("MoveMethod", 1);

		if (Move.MoveMethod.Equals(1)){
			Move.MoveMethod = 0;
			DragBtn.SetActive (false);
			JoyStickBtn.SetActive (true);
			PlayerPrefs.SetInt ("MoveMethod", Move.MoveMethod);
		} else {
			Move.MoveMethod = 1;
			DragBtn.SetActive (true);
			JoyStickBtn.SetActive (false);
			PlayerPrefs.SetInt ("MoveMethod", Move.MoveMethod);
		}
	}
}
