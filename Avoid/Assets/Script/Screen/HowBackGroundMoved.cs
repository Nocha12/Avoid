using UnityEngine;
using System.Collections;

public class HowBackGroundMoved : MonoBehaviour {

	public float howMoved = 0; 
	public int nowMode = 0;

	void Awake()
	{
		DontDestroyOnLoad (transform.gameObject);
	}
}
