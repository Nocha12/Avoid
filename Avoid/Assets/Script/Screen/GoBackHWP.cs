using UnityEngine;
using System.Collections;

public class GoBackHWP : MonoBehaviour {

	void Update()
	{
		if(Application.platform.Equals(RuntimePlatform.Android))
			if(Input.GetKey(KeyCode.Escape))
				Application.LoadLevel("SelectPlayOrHow");
	}
}
