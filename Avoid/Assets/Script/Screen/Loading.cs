using UnityEngine;
using System.Collections;

public class Loading : MonoBehaviour {

	void Start () {
		StartCoroutine(Load());
	}

	IEnumerator Load()
	{
		int mode = GameObject.Find ("HowBackGroundMoved").GetComponent<HowBackGroundMoved>().nowMode;
		AsyncOperation async;

		if(mode == 1)
			async = Application.LoadLevelAsync("EasyMode");
		else if(mode == 2)
			async = Application.LoadLevelAsync("HardMode");
		else 
			async = Application.LoadLevelAsync("InfinityMode");
		
		while(!async.isDone)
		{
			yield return true;
		}
	}
}
