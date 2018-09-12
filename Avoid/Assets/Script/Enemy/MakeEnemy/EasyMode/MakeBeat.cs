using UnityEngine;
using System.Collections;

public class MakeBeat : MonoBehaviour {

	public MakeEnemy ME;
	public MakePattern MP;
	public MakePattern2 MP2;
	public MakePattern3 MP3;
	public EnemyEasyMode EEM;

	public IEnumerator StarMaker()
	{
		for(int i = 0; i < 5; i++)
		{
			MP3.MakeStar ();
			ME.Make_Nomal ();
			yield return new WaitForSeconds (0.38f);
		}
	}

	public IEnumerator GridMaker()
	{
		for(int i = 0; i < 6; i++)
		{
			MP.MakeGrid ();
			ME.Make_Strate  ();
			yield return new WaitForSeconds (0.38f);
		}
	}

	public IEnumerator DiagonalMaker()
	{
		for(int i = 0; i < 6; i++)
		{
			MP.MakeDiagonal ();
			yield return new WaitForSeconds (0.38f);
		}
	}

	public IEnumerator HexagonMaker()
	{
		for(int i = 0; i < 6; i++)
		{
			MP.MakeHexagon ();
			ME.Make_Nomal ();
			yield return new WaitForSeconds (0.38f);
		}
	}

	public IEnumerator TriPhosMaker()
	{
		for(int i = 0; i < 6; i++)
		{
			MP2.MakeTriPhos ();
			ME.Make_Strate ();
			yield return new WaitForSeconds (0.38f);
		}
	}

	public IEnumerator StripesMaker()
	{
		for(int i = 0; i < 6; i++)
		{
			MP3.MakeStripes ();
			MP3.MakeStripes ();
			yield return new WaitForSeconds (0.38f);
		}
	}

	public IEnumerator Diagonal2Maker()
	{
		for(int i = 0; i < 6; i++)
		{
			MP2.MakeDiagonal2 ();
			MP2.MakeDiagonal2 ();
			yield return new WaitForSeconds (0.38f);
		}
	}

	public IEnumerator OthersMaker()
	{
		for(int i = 0; i < 6; i++)
		{
			EnemyEasyMode.targetCheck = true;
			ME.Make_Super_Sonic ();
			EEM.Invoke ("ChangeTargetCheck", 0.0001f);
			yield return new WaitForSeconds (0.38f);
		}
	}
}