using UnityEngine;
using System.Collections;

public class HowToPlayControl : MonoBehaviour {

	public GameObject PreveiwBtn = null;

	public GameObject[] Bullet = new GameObject[7];
	public GameObject[]	Explain = new GameObject[7];

	int explainCount = 0;

	void Start()
	{
		PreveiwBtn.SetActive (false);
		Bullet[explainCount].SetActive (true);
		Explain[explainCount].SetActive (true);
	}

	public void Before()
	{
		if (explainCount > 0) { 
			Explain[explainCount].SetActive (false);
			Bullet[explainCount--].SetActive (false);
			Bullet[explainCount].SetActive (true);
			Explain[explainCount].SetActive (true);
		}
		if (explainCount == 0)
			PreveiwBtn.SetActive (false);
	}

	public void After()
	{
		if(explainCount == 6)
			Application.LoadLevel("SelectPlayMode");
		else if (explainCount < 6) {
			Explain[explainCount].SetActive (false);
			Bullet[explainCount++].SetActive (false);
			Bullet[explainCount].SetActive (true);
			Explain[explainCount].SetActive (true);
		}
		if(explainCount == 1)
			PreveiwBtn.SetActive (true);
	}
}
 