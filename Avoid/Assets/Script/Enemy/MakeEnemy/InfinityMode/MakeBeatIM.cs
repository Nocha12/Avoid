using UnityEngine;
using System.Collections;

public class MakeBeatIM : MonoBehaviour {

	public MakeEnemyIM ME;
	public MakeEnemy2IM ME2;
	public MakePatternIM MP;
	public MakePattern2IM MP2;
	public MakePattern3IM MP3;
	public EnemyInfinityMode EIM;

	public IEnumerator DoomMaker()
	{
		for(int i = 0; i < 16; i++)
		{
			MP.MakeDoom ();
			yield return new WaitForSeconds (0.4f);
		}
	}

	public IEnumerator DoomMaker2()
	{
		for(int i = 0; i < 16; i++)
		{
			MP.MakeDoom2 ();
			yield return new WaitForSeconds (0.2f);
		}
	}

	public IEnumerator DoomMaker3()
	{
		for(int i = 0; i < 32; i++)
		{
			MP2.MakeDoom3 ();
			yield return new WaitForSeconds (0.1f);
		}
	}
		
	public IEnumerator BamMaker()
	{
		for(int i = 0; i < 32; i++)
		{
			for(int j = 0; j < 7; j++)
				ME.Make_Super_Sonic();
			yield return new WaitForSeconds (0.92f);
		}
	}

	public IEnumerator StrateMaker()
	{
		while (true) {
			ME.Make_Strate();
			ME.Make_Nomal ();
			yield return new WaitForSeconds (1.2f);
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

	public IEnumerator DiagonalMaker()
	{
		for(int i = 0; i < 2; i++)
		{
			for(int j = 0; j < 6; j++)
				MP3.MakeDiagonal ();
			yield return new WaitForSeconds (0.2f);
		}
	}

	public IEnumerator HexagonMaker()
	{
		for(int j = 0; j < 6; j++)
			MP3.MakeHexagon ();
		yield return null;
	}
}