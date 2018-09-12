using UnityEngine;
using System.Collections;

public class Enemy_Move : MonoBehaviour {

	public GameObject ball = null;
    bool huming = true;

    public static int Tri_Speed = 4;

	void OnEnable()
	{
		huming = true;
		Invoke(methodName: "No_Huming", time: 4);
	}

	void OnDisable()
	{
		CancelInvoke ("No_Huming");
	}
	
	void Update () {
        if (huming)
        {
            if (!Move.finish)
            {
				Vector2 relativePos = ball.transform.position - transform.position;
                float angle = Mathf.Atan2(relativePos.y, relativePos.x) * Mathf.Rad2Deg;

				transform.localRotation = Quaternion.Euler(0, 0, angle - 90);
            }
        }
		transform.Translate(transform.up * Time.deltaTime * 4, Space.World);
    }

	void OnTriggerEnter2D(Collider2D other)
    {
		if (other.gameObject.CompareTag("Enemy") || other.gameObject.CompareTag("Super_Enemy"))
        {
			gameObject.SetActive (false);
        }
    }

    void No_Huming ()
    {
        huming = false;
    }

    void Boom ()
    {
		gameObject.SetActive (false);
    }
}
