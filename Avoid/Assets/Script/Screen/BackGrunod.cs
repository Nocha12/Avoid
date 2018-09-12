using UnityEngine;
using System.Collections;

public class BackGrunod : MonoBehaviour {

	public float scrollSpeed = 0.01f;

	private HowBackGroundMoved HowMoved;

	Material myMaterial;

	void Start () {
		myMaterial = GetComponent<Renderer> ().material;
		HowMoved = GameObject.Find ("HowBackGroundMoved").GetComponent<HowBackGroundMoved>();

		myMaterial.mainTextureOffset = new Vector2 (HowMoved.howMoved, 0);
	}

	void Update () { 
		float newOffsetX = myMaterial.mainTextureOffset.x + scrollSpeed * Time.deltaTime;

		myMaterial.mainTextureOffset = new Vector2 (newOffsetX, 0);

		HowMoved.howMoved = newOffsetX;
	}
}
