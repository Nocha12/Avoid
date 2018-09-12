using UnityEngine;
using System.Collections;

public class MakeEnemy2HM : MonoBehaviour {

	public EnemyHardMode EHM;
	public GameObject ball = null;

	public void MakeSonicBeat()
	{
		if (!Move.finish)
		{
			int check = Random.Range(1, 4);
			Real_Make(check, EHM.BeatEnemy[EHM.beatEnemyCount]);

			EHM.beatEnemyCount++;

			if (EHM.beatEnemyCount.Equals(10))
				EHM.beatEnemyCount = 0;
		}
	}

	public void MakeRotation(GameObject Enemy, GameObject Rail, Vector2 pos, int rotation)
	{
		Enemy.transform.position = pos;
		Enemy.transform.localRotation = Quaternion.Euler (0, 0, rotation);

		Rail.transform.position = pos;
		Rail.transform.localRotation = Quaternion.Euler (0, 0, rotation);
	}

	public void MakeRotation(GameObject Enemy, GameObject Rail, Vector2 pos)
	{
		GameObject target = ball;
		Enemy.transform.position = pos;
		Vector2 relativePos = target.transform.position - Enemy.transform.position;
		float angle = Mathf.Atan2 (relativePos.y, relativePos.x) * Mathf.Rad2Deg;
		Enemy.transform.localRotation = Quaternion.Euler (0, 0, angle - 90);
		Rail.transform.position = pos;
		Rail.transform.localRotation = Quaternion.Euler (0, 0, angle - 90);
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

		EHM.sonicEnemyCount++;

		if (EHM.sonicEnemyCount.Equals (20))
			EHM.sonicEnemyCount = 0;

		EHM.sonicRailEnemyCount++;

		if (EHM.sonicRailEnemyCount.Equals (20))
			EHM.sonicRailEnemyCount = 0;
	}
}
