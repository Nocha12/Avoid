using UnityEngine;
using System.Collections;

public class RailIM : MonoBehaviour {

	bool isClap = false;

	void OnEnable() {
		isClap = false;

		if (!EnemyInfinityMode.setOffCheck) {
			Invoke ("Boom", 0.9200001f);
			isClap = true;
		}
	}

	void Update()
	{
		if (!isClap && EnemyInfinityMode.setOff)
			Boom ();
	}

	void Boom()
	{
		gameObject.SetActive (false);
	}
}
