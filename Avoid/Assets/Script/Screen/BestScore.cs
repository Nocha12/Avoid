using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BestScore : MonoBehaviour 
{	
	public Text BestScoreText = null;

	void Start () {
		if (PlayerPrefs.HasKey ("BestScore")) {
			BestScoreText.text =  "BEST " + PlayerPrefs.GetInt ("BestScore", 0).ToString();
			PlayerPrefs.Save ();
		}  else {
			BestScoreText.text = "BEST 0";
		}	
	}
}
