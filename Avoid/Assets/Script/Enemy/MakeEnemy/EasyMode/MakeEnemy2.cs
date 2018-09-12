using UnityEngine;
using System.Collections;

public class MakeEnemy2 : MonoBehaviour {

	public EnemyEasyMode EEM;

	public void MakeSonicBeat()
	{
		if (!Move.finish)
		{
			int check = Random.Range(1, 4);
			Real_Make(check, EEM.BeatEnemy[EEM.beatEnemyCount]);

			EEM.beatEnemyCount++;

			if (EEM.beatEnemyCount.Equals(10))
				EEM.beatEnemyCount = 0;
		}
	}

	public void MakeRotation(GameObject Enemy, GameObject Rail, Vector2 pos, int rotation)
	{
		Enemy.transform.position = pos;
		Enemy.transform.localRotation = Quaternion.Euler (0, 0, rotation);

		Rail.transform.position = pos;
		Rail.transform.localRotation = Quaternion.Euler (0, 0, rotation);
	}

	public void Real_Make(int range, GameObject Enemy)
	{
		if (range.Equals(1))
		{
			Enemy.transform.position = new Vector2 (Random.Range (-18.5f, 18.5f), 11f);
			Enemy.SetActive (false);
			Enemy.SetActive (true);
		}
		else if (range.Equals(2))
		{
			Enemy.transform.position = new Vector2 (Random.Range (-18.5f, 18.5f), -11f);
			Enemy.SetActive (false);
			Enemy.SetActive (true);
		}
		else if (range.Equals(3))
		{
			Enemy.transform.position = new Vector2(18.5f, Random.Range(-11f, 11f));
			Enemy.SetActive (false);
			Enemy.SetActive (true);
		}
		else if(range.Equals(4))
		{
			Enemy.transform.position =  new Vector2(-18.5f, Random.Range(-11f, 11f));
			Enemy.SetActive (false);
			Enemy.SetActive (true);
		}
	}
	public void MakeSonicNRail(GameObject EnemySonic, GameObject EnemyRail)
	{
		EnemySonic.SetActive (false);
		EnemySonic.SetActive (true);
		EnemyRail.SetActive (false);
		EnemyRail.SetActive (true);

		EEM.sonicEnemyCount++;

		if (EEM.sonicEnemyCount.Equals (20))
			EEM.sonicEnemyCount = 0;

		EEM.sonicRailEnemyCount++;

		if (EEM.sonicRailEnemyCount.Equals (20))
			EEM.sonicRailEnemyCount = 0;
	}
}
