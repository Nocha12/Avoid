using UnityEngine;
using System.Collections;

public class EnemyMoveSonicBeat : MonoBehaviour {
	public GameObject ball = null;
	int cnt = 0;

	void OnEnable()
	{
		cnt = 0;
		InvokeRepeating("Set_Target", 0, 0.46f);
	}

	void Set_Target()
	{
		if (cnt < 5) {
			if (!Move.finish) {
				Vector2 relativePos = ball.transform.position - transform.position;
				float angle = Mathf.Atan2 (relativePos.y, relativePos.x) * Mathf.Rad2Deg;

				transform.localRotation = Quaternion.Euler (0, 0, angle - 90);
			}
		}
		else 
			CancelInvoke ("Set_Target");
		
		cnt++;
	}

	void Update()
	{
		transform.Translate(transform.up * Time.deltaTime * 7, Space.World);
	} 

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("Super_Enemy"))
		{
			gameObject.SetActive (false);
		}
	}

	void Boom()
	{
		gameObject.SetActive (false);
	}
}
