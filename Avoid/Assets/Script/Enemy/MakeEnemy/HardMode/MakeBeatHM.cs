using UnityEngine;
using System.Collections;

public class MakeBeatHM : MonoBehaviour {

	public MakeEnemyHM ME;
	public MakePatternHM MP;
	public MakePattern2HM MP2;
	public EnemyHardMode EHM;

	public IEnumerator GridMaker()
	{
		for(int i = 0; i < 3; i++)
		{
			MP.MakeGrid ();
			MP.MakeGrid ();
			ME.Make_Strate  ();
			yield return new WaitForSeconds (0.38f);
		}
	}

	public IEnumerator DiagonalMaker()
	{
		for(int i = 0; i < 3; i++)
		{
			MP.MakeDiagonal ();
			MP.MakeDiagonal ();
			ME.Make_Nomal ();
			yield return new WaitForSeconds (0.38f);
		}
	}

	public IEnumerator HexagonMaker()
	{
		for(int i = 0; i < 3; i++)
		{
			MP.MakeHexagon ();
			MP.MakeHexagon ();
			ME.Make_Nomal ();
			yield return new WaitForSeconds (0.38f);
		}

		EHM.Invoke ("ChangeSetOff", 0f);
	}

	public IEnumerator TriPhosMaker()
	{
		for(int i = 0; i < 3; i++)
		{
			MP2.MakeTriPhos ();
			MP2.MakeTriPhos ();
			yield return new WaitForSeconds (0.38f);
		}
	}

	public IEnumerator StripesMaker()
	{
		for(int i = 0; i < 3; i++)
		{
			for(int j = 0; j < 4; j++)
				MP2.MakeStripes ();
			
			yield return new WaitForSeconds (0.38f);
		}

		EHM.Invoke ("ChangeSetOff", 0f);
	}

	public IEnumerator Diagonal2Maker()
	{
		for(int i = 0; i < 3; i++)
		{
			for(int j = 0; j < 4; j++)
				MP2.MakeDiagonal2 ();

			yield return new WaitForSeconds (0.38f);
		}

		EHM.Invoke ("ChangeSetOff", 0f);
	}

	public IEnumerator Beep1Maker()
	{
		for(int i = 0; i < 4; i++)
		{
			EnemyHardMode.setOff = false;
			EnemyHardMode.targetCheck = true;
			ME.Make_Super_Sonic ();
			EHM.Invoke ("ChangeTargetCheck", 0.0001f);

			if(i.Equals(0))
				yield return new WaitForSeconds (0.7f);
			else if(i.Equals(2) || i.Equals(3))
				yield return new WaitForSeconds (0.19f);
			else 
				yield return new WaitForSeconds (0.38f);
		}

		EHM.Invoke ("ChangeSetOff", 0f);
	}
}