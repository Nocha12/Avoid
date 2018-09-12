using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour
{
	new Transform transform;
	public static bool finish = false;
	public static int MoveMethod = 1;

	IEnumerator Moving()
	{
		while (true) {
			if (MoveMethod == 1) {
				if (Input.GetKey (KeyCode.W))
					transform.Translate (new Vector2 (0, Time.deltaTime * 15));
				if (Input.GetKey (KeyCode.S))
					transform.Translate (new Vector2 (0, Time.deltaTime * -15));
				if (Input.GetKey (KeyCode.A))
					transform.Translate (new Vector2 (Time.deltaTime * -15, 0));
				if (Input.GetKey (KeyCode.D))
					transform.Translate (new Vector2 (Time.deltaTime * 15, 0));
				if (Input.touchCount > 0 && Input.GetTouch (0).phase.Equals (TouchPhase.Moved)) {
					Vector2 touchDeltaPosition = Input.GetTouch (0).deltaPosition;

					if (Slide.Play_Speed != 0)
						transform.Translate (touchDeltaPosition.x * Slide.Play_Speed * Time.deltaTime, touchDeltaPosition.y * Slide.Play_Speed * Time.deltaTime, 0);
					else
						transform.Translate (touchDeltaPosition.x * 8 * Time.deltaTime, touchDeltaPosition.y * 8 * Time.deltaTime, 0);

					transform.position = new Vector2 (Mathf.Clamp (transform.position.x, -17.5f, 17.5f), Mathf.Clamp (transform.position.y, -10.0f, 10.0f));
				}
			} else
				MovePlayer ();

			yield return null;
		}
	}

	void Start()
	{
		transform = GetComponent<Transform> ();
		StartCoroutine (Moving ());
	}
		
	void MovePlayer ()
	{
		if (JoyStickMaker.MoveJoyStick) 
		{
			if (JoyStickMaker.JoyStickDistance < JoyStickMaker.radius) 
				transform.Translate(JoyStickMaker.direction.x * Slide.Play_Speed * JoyStickMaker.JoyStickDistance * Time.deltaTime * 1.8f, JoyStickMaker.direction.y * Slide.Play_Speed  * JoyStickMaker.JoyStickDistance * Time.deltaTime * 1.8f, 0);
			else
				transform.Translate(JoyStickMaker.direction.x * Slide.Play_Speed * JoyStickMaker.radius * Time.deltaTime * 1.8f, JoyStickMaker.direction.y * Slide.Play_Speed * JoyStickMaker.radius * Time.deltaTime * 1.8f, 0);

			transform.position = new Vector2(Mathf.Clamp(transform.position.x, -17.5f, 17.5f), Mathf.Clamp(transform.position.y, -10.0f, 10.0f));
		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag("Enemy")|| other.gameObject.CompareTag("Super_Enemy"))
		{
			Destroy(gameObject);
			finish = true;

			if (MakeMainBeatIM.score > PlayerPrefs.GetInt ("BestScore", 0)) {
				PlayerPrefs.SetInt ("BestScore", MakeMainBeatIM.score);
				PlayerPrefs.Save ();
			}
		}
	}
}
