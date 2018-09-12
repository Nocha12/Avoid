using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MakeMainBeatIM : MonoBehaviour {

	public MakeEnemyIM ME;
	public EnemyInfinityMode EIM;
	public MakeBeatIM MB;

	public Text ScoreText = null;
	static public int score = 0;

	void Start()
	{
		StartCoroutine ("PlusScore");
	}

	IEnumerator PlusScore()
	{
		while (true)
		{
			score += 20;
			ScoreText.text = score.ToString();
			yield return new WaitForSeconds (1f);
		}
	}

	public IEnumerator MainBeat()
	{
		bool firstPattern = true;

		EIM.BGM_Source.Play();
		EIM.BGM_Source.loop = true;

		while (true) {
			if (firstPattern) {
				EnemyInfinityMode.setOffCheck = true;
				EnemyInfinityMode.targetCheck = false;
				MB.StartCoroutine ("HexagonMaker");
				firstPattern = false;
			}

			yield return new WaitForSeconds (0.08f);
			EIM.Invoke ("ChangeSetOff", 0f);
			yield return new WaitForSeconds (0.0001f);
			EnemyInfinityMode.setOffCheck = false;
			EnemyInfinityMode.targetCheck = true;
			MB.StartCoroutine ("StrateMaker");
			MB.StartCoroutine ("BeatMaker");
			yield return new WaitForSeconds (29f);
			MB.StartCoroutine ("DoomMaker");
			yield return new WaitForSeconds (7.6f);
			MB.StartCoroutine ("DoomMaker2");
			yield return new WaitForSeconds (4f);
			MB.StartCoroutine ("DoomMaker3");
			yield return new WaitForSeconds (3.5f);
			EnemyInfinityMode.setOffCheck = true;
			EnemyInfinityMode.targetCheck = false;
			yield return new WaitForSeconds (1f);
			MB.StartCoroutine ("DiagonalMaker");
			EIM.Invoke ("ChangeSetOff", 1f);
			yield return new WaitForSeconds (1.001f);
			EnemyInfinityMode.setOffCheck = false;
			EnemyInfinityMode.targetCheck = true;
			yield return new WaitForSeconds (0.001f);
			MB.StartCoroutine ("BamMaker");
			MB.StartCoroutine ("BeatMaker");
			ME.Make_Sonic ();
			yield return new WaitForSeconds (34f);
			EnemyInfinityMode.setOffCheck = true;
			EnemyInfinityMode.targetCheck = false;
			MB.StartCoroutine ("HexagonMaker");
			yield return new WaitForSeconds (0.7f);
		}
	}
}
