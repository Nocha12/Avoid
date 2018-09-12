using UnityEngine;
using System.Collections;

public class MakeBeat2 : MonoBehaviour {

	public MakeEnemy ME;
	public MakeEnemy2 ME2;
	public MakePattern MP;
	public MakePattern2 MP2;
	public EnemyEasyMode EEM;

	public IEnumerator Beep1Maker()
	{
		for(int i = 0; i < 6; i++)
		{
			EnemyEasyMode.targetCheck = true;
			ME.Make_Super_Sonic ();
			EEM.Invoke ("ChangeTargetCheck", 0.0001f);

			if(i.Equals(0) || i.Equals(1) || i.Equals(2))
				yield return new WaitForSeconds (0.15f);
			else if(i.Equals(3))
				yield return new WaitForSeconds (0.3f);
			else 
				yield return new WaitForSeconds (0.1f);
		}
	}		

	public IEnumerator Beep2Maker()
	{
		for(int i = 0; i < 8; i++)
		{
			EnemyEasyMode.targetCheck = true;
			ME.Make_Super_Sonic ();
			EEM.Invoke ("ChangeTargetCheck", 0.0001f);

			if(i.Equals(0) || i.Equals(1) || i.Equals(2))
				yield return new WaitForSeconds (0.15f);
			else if(i.Equals(3))
				yield return new WaitForSeconds (0.3f);
			else 
				yield return new WaitForSeconds (0.1f);
		}
	}

	public IEnumerator Beep3Maker()
	{
		for(int i = 0; i < 10; i++)
		{
			EnemyEasyMode.targetCheck = true;
			ME.Make_Super_Sonic ();
			EEM.Invoke ("ChangeTargetCheck", 0.0001f);

			if(i.Equals(0) || i.Equals(1) || i.Equals(2))
				yield return new WaitForSeconds (0.1f);
			else if(i.Equals(3))
				yield return new WaitForSeconds (0.2f);
			else if(i.Equals(5) || i.Equals(7) || i.Equals(9))
				yield return new WaitForSeconds (0.2f);
			else
				yield return new WaitForSeconds (0.3f);
		}
	}

	public IEnumerator BeatMaker()
	{
		for(int i = 0; i < 30; i++)
		{
			ME2.MakeSonicBeat ();
			yield return new WaitForSeconds (0.9200001f);
		}
	}

	public IEnumerator ClapMaker1()
	{
		for(int i = 0; i <= 30; i++)
		{
			EnemyEasyMode.setOffCheck = false;

			if(i.Equals(30))
				for(int j = 0; j < 7; j++)
					ME.Make_Super_Sonic ();
			else 
				ME.MakeClap ();

			EEM.Invoke ("ChangeSetOffCheck", 0.000200017f);
			yield return new WaitForSeconds (0.46f);
		}
	}
	public IEnumerator ClapMaker2()
	{
		for(int i = 0; i <= 61; i++)
		{
			EnemyEasyMode.setOffCheck = false;

			if(i.Equals(30))
				for(int j = 0; j < 7; j++)
					ME.Make_Super_Sonic ();
			else if(i.Equals(60))
				for(int j = 0; j < 8; j++)
					ME.Make_Super_Sonic ();
			else 
				ME.MakeClap ();

			EEM.Invoke ("ChangeSetOffCheck", 0.000200017f);
			yield return new WaitForSeconds (0.46f);
		}
	}
}
