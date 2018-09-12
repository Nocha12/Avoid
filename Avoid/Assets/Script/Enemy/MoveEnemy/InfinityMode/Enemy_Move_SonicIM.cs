using UnityEngine;
using System.Collections;

public class Enemy_Move_SonicIM : MonoBehaviour {

	public GameObject ball = null;

	void OnEnable()
	{
		InvokeRepeating(methodName: "Set_Target", time: 0, repeatRate: 0.92f);
	}

	void Set_Target()
	{
		if (!Move.finish) {
			Vector2 relativePos = ball.transform.position - transform.position;
			float angle = Mathf.Atan2 (relativePos.y, relativePos.x) * Mathf.Rad2Deg;

			transform.localRotation = Quaternion.Euler (0, 0, angle - 90);
		} else
			CancelInvoke ("Set_Target");
	}

	void Update()
	{
		transform.Translate(transform.up * Time.deltaTime * 17, Space.World);
	}

	void Boom()
	{
		gameObject.SetActive (false);
	}
}
