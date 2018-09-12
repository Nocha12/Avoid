using UnityEngine;
using System.Collections;

public class MakeBeat3HM : MonoBehaviour {

	public MakeEnemyHM ME;
	public MakePattern3HM MP3;
	public MakePattern4HM MP4;
	public EnemyHardMode EHM;

	public IEnumerator DoomMaker()
	{
		for(int i = 0; i < 16; i++)
		{
			EnemyHardMode.setOffCheck = false;

			MP3.MakeDoom ();

			EHM.Invoke ("ChangeSetOffCheck", 0.000200017f);
			yield return new WaitForSeconds (0.38f);
		}
	}

	public IEnumerator DoomMaker2()
	{
		for(int i = 0; i < 8; i++)
		{
			EnemyHardMode.setOffCheck = false;

			MP3.MakeDoom2 ();
			MP3.MakeDoom2 ();

			EHM.Invoke ("ChangeSetOffCheck", 0.000200017f);
			yield return new WaitForSeconds (0.38f);
		}
	}

	public IEnumerator DoomMaker3()
	{
		for(int i = 0; i < 32; i++)
		{
			EnemyHardMode.setOffCheck = false;

			MP4.MakeDoom3 ();

			EHM.Invoke ("ChangeSetOffCheck", 0.000200017f);
			yield return new WaitForSeconds (0.05f);
		}
	}

	public IEnumerator Beep4Maker()
	{
		for(int i = 0; i < 6; i++)
		{
			EnemyHardMode.setOff = false;
			EnemyHardMode.targetCheck = true;
			ME.Make_Super_Sonic ();
			EHM.Invoke ("ChangeTargetCheck", 0.0001f);

			if(i.Equals(0) || i.Equals(3))
				yield return new WaitForSeconds (0.38f);
			else
				yield return new WaitForSeconds (0.1f);
		}

		EHM.Invoke ("ChangeSetOff", 0f);
	}
}
