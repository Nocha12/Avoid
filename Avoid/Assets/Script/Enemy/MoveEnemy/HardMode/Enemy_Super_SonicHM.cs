﻿using UnityEngine;
using System.Collections;

public class Enemy_Super_SonicHM : MonoBehaviour {

	public GameObject ball = null;
	bool view = false;

	bool isClap = false;

	void OnEnable()
	{
		isClap = false;

		if (!EnemyHardMode.setOffCheck) {
			Set_Target ();
			Invoke (methodName: "Appear", time: 0.76f);
			isClap = true;
		} else if(EnemyHardMode.targetCheck)
			Set_Target ();

		view = false;
	}

	void Set_Target()
	{
		if (!Move.finish)
		{
			Vector2 relativePos = ball.transform.position - transform.position;

			float angle = Mathf.Atan2(relativePos.y, relativePos.x) * Mathf.Rad2Deg;

			transform.localRotation = Quaternion.Euler(0, 0, angle - 90);
		}
	}

	void Update()
	{
		if(view)
			for(int i = 0; i < 50; i++)
				transform.Translate(transform.up * Time.deltaTime * 3.5f, Space.World);

		if (EnemyHardMode.setOff && !isClap)
			Appear ();
	}

  	void Appear()
	{
		view = true;
	}

	void Boom ()
	{
		gameObject.SetActive (false);
	}
}
