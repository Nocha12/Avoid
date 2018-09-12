using UnityEngine;
using System.Collections;

public class MakeBeat2HM : MonoBehaviour {

	public MakeEnemyHM ME;
	public MakeEnemy2HM ME2;
	public EnemyHardMode EHM;

	public IEnumerator BeatMaker()
	{
		for(int i = 0; i < 125; i++)
		{
			ME2.MakeSonicBeat ();
			yield return new WaitForSeconds (0.76f);
		}
	}

	public IEnumerator ClapMaker1()
	{
		for(int i = 0; i <= 90; i++)
		{
			EnemyHardMode.setOffCheck = false;

			if(i.Equals(15) || i.Equals(30) || i.Equals(46) || i.Equals(62) || i.Equals(77))
				for(int j = 0; j < 10; j++)
					ME.Make_Super_Sonic ();
			else 
				ME.MakeClap ();

			EHM.Invoke ("ChangeSetOffCheck", 0.0001305017f);
			yield return new WaitForSeconds (0.38f);
		}
	}

	public IEnumerator ClapMaker2()
	{
		for(int i = 0; i <= 61; i++)
		{
			EnemyHardMode.setOffCheck = false;

			for(int j = 0; j < 5;j++)
				ME.MakeClap ();
		
			EHM.Invoke ("ChangeSetOffCheck", 0.0001305017f);
			yield return new WaitForSeconds (0.76f);
		}
	}

	public IEnumerator Beep2Maker()
	{
		for(int i = 0; i < 6; i++)
		{
			EnemyHardMode.setOff = false;
			EnemyHardMode.targetCheck = true;
			ME.Make_Super_Sonic ();
			EHM.Invoke ("ChangeTargetCheck", 0.0001f);

			if(i.Equals(0) || i.Equals(2))
				yield return new WaitForSeconds (0.38f);
			else if(i.Equals(1) || i.Equals(3))
				yield return new WaitForSeconds (0.19f);
			else 
				yield return new WaitForSeconds (0.1f);
		}

		EHM.Invoke ("ChangeSetOff", 0f);
	}

	public IEnumerator Beep3Maker()
	{
		for(int i = 0; i < 11; i++)
		{
			EnemyHardMode.setOff = false;
			EnemyHardMode.targetCheck = true;
			ME.Make_Super_Sonic ();
			EHM.Invoke ("ChangeTargetCheck", 0.0001f);

			if(i.Equals(0) || i.Equals(2) || i.Equals(5) || i.Equals(8) || i.Equals(9) || i.Equals(10))
				yield return new WaitForSeconds (0.38f);
			else if(i.Equals(1))
				yield return new WaitForSeconds (0.19f);
			else
				yield return new WaitForSeconds (0.1f);
		}

		EHM.Invoke ("ChangeSetOff", 0f);
	}
}
