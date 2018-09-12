using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class JoyStickMaker : MonoBehaviour {
	new Transform transformB;
	new Transform transformH;

	public GameObject JoyStkickHandul = null;
	public GameObject JoyStkickBack = null;

	static public Vector2 CenterPos;
	static public Vector2 offset;
	static public Vector2 direction;
	static public Vector2 pos;
	static public bool MoveJoyStick = false;
	static public float JoyStickDistance;
	static public float radius = 1.2f;

	IEnumerator JoyStickMoving()
	{
		while (Move.MoveMethod.Equals (0)) {
			if (Move.finish) {
				JoyStkickHandul.SetActive (false);
				JoyStkickBack.SetActive (false);	
			}

			if (Input.touchCount > 0 && !Move.finish) {
				pos = Input.GetTouch (0).position; 
				pos.x = -17.5f + pos.x / 54.857142857142857142857143f;
				pos.y = -10f + pos.y / 54f;

				if (Input.GetTouch (0).phase.Equals (TouchPhase.Began)) {
					transformB.position = pos;
					transformH.position = pos;

					CenterPos = pos;

					JoyStkickHandul.SetActive (true);
					JoyStkickBack.SetActive (true);
				} else if (Input.GetTouch (0).phase.Equals (TouchPhase.Moved)) {
					JoyStickDistance = Vector2.Distance (pos, CenterPos);

					offset = pos - CenterPos;
					direction = offset.normalized;

					MoveJoyStick = true;

					if (JoyStickDistance < radius)
						transformH.position = pos;
					else
						transformH.position = direction * radius + CenterPos;
				} else if (Input.GetTouch (0).phase.Equals (TouchPhase.Ended)) {
					MoveJoyStick = false;
					JoyStkickHandul.SetActive (false);
					JoyStkickBack.SetActive (false);
				}
			}

			yield return null;
		}
	}

	void Start ()
	{
		transformB = JoyStkickBack.GetComponent<Transform> ();
		transformH = JoyStkickHandul.GetComponent<Transform> ();
		StartCoroutine (JoyStickMoving());
	}
}
