using UnityEngine;
using System.Collections;

public class Enemy_Move_Sonic : MonoBehaviour {
	public GameObject ball = null;
	int cnt = 0;

	void OnEnable()
	{
		cnt = 0;
		InvokeRepeating(methodName: "Set_Target", time: 0, repeatRate: 0.38f);
	}

	void Set_Target()
	{
		if (cnt <= 6) {
			if (!Move.finish) {
				Vector2 relativePos = ball.transform.position - transform.position;
				float angle = Mathf.Atan2 (relativePos.y, relativePos.x) * Mathf.Rad2Deg;

				transform.localRotation = Quaternion.Euler (0, 0, angle - 90);

				cnt++;
			}
		} else
			CancelInvoke ("Set_Target");
	}

	void Update()
	{
		transform.Translate(transform.up * Time.deltaTime * 22, Space.World);
	}

	void Boom()
	{
		gameObject.SetActive (false);
	}
}
