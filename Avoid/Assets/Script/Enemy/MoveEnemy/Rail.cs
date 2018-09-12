using UnityEngine;
using System.Collections;

public class Rail : MonoBehaviour {

	bool isClap = false;

	void OnEnable() {
		isClap = false;

		if (!EnemyEasyMode.setOffCheck) {
			Invoke ("Boom", 0.9200001f);
			isClap = true;
		}
	}

	void Update()
	{
		if (!isClap && EnemyEasyMode.setOff)
			Boom ();
	}

	void Boom()
	{
		gameObject.SetActive (false);
	}
}
