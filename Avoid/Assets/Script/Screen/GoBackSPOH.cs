using UnityEngine;
using System.Collections;

public class GoBackSPOH : MonoBehaviour {

	void Update () {
		if(Application.platform.Equals(RuntimePlatform.Android))
			if(Input.GetKey(KeyCode.Escape))
				Application.LoadLevel("Start");
	}
}
