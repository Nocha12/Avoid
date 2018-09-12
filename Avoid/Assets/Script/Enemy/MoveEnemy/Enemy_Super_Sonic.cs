using UnityEngine;
using System.Collections;

public class Enemy_Super_Sonic : MonoBehaviour {
	public GameObject ball = null;
	bool view = false;

	bool isClap = false;

	void OnEnable()
	{
		isClap = false;

		if (!EnemyEasyMode.setOffCheck) {
			Set_Target ();
			Invoke (methodName: "Appear", time: 0.9200001f);
			isClap = true;
		} else if(EnemyEasyMode.targetCheck)
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

		if (EnemyEasyMode.setOff && !isClap)
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
