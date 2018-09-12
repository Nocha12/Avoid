using UnityEngine;
using System.Collections;

public class RailHM : MonoBehaviour {

	bool isClap = false;

	void OnEnable() {
		isClap = false;

		if (!EnemyHardMode.setOffCheck) {
			Invoke ("Boom", 0.76f);
			isClap = true;
		}
	}

	void Update()
	{
		if (!isClap && EnemyHardMode.setOff)
			Boom ();
	}

	void Boom()
	{
		gameObject.SetActive (false);
	}
}
