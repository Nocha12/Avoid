using UnityEngine;
using System.Collections;

public class Enemy_Move_Strate : MonoBehaviour
{
	public GameObject ball = null;
    public static int Fif_Speed = 5;

	void OnEnable()
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
        transform.Translate(transform.up * Time.deltaTime * 5, Space.World);
    }

	void OnTriggerEnter2D(Collider2D other)
    {
		if (other.gameObject.CompareTag("Enemy") || other.gameObject.CompareTag("Super_Enemy"))
        {
			gameObject.SetActive (false);
        }
    }

    void Boom()
    {
		gameObject.SetActive (false);
    }
}
