using UnityEngine;
using System.Collections;

public class MakeEnemyIM : MonoBehaviour {

	public EnemyInfinityMode EIM;
	public MakeEnemy2IM ME2;

	public GameObject ball;

	public void Make_Nomal()
	{
		if (!Move.finish)
		{
			int check = Random.Range(1, 4);
			ME2.Real_Make(check, EIM.HumingEnemy[EIM.humingEnemyCount]);

			EIM.humingEnemyCount++;

			if (EIM.humingEnemyCount.Equals(20))
				EIM.humingEnemyCount = 0;
		}
	}

	public void Make_Strate()
	{
		if (!Move.finish)
		{
			int check = Random.Range(1, 4);
			ME2.Real_Make(check, EIM.StrateEnemy[EIM.strateEnemyCount]);

			EIM.strateEnemyCount++;

			if (EIM.strateEnemyCount.Equals(20))
				EIM.strateEnemyCount = 0;
		}
	}

	public void Make_Sonic()
	{
		if (!Move.finish)
		{
			int check = Random.Range(1, 4);
			ME2.Real_Make(check, EIM.SonicEnemy);
		}
	}

	public void Make_Super_Sonic()
	{
		if (!Move.finish)
		{
			int check = Random.Range(1, 4);

			ME2.Real_Make(check, EIM.SuperSonic[EIM.sonicEnemyCount]);

			if (!EnemyInfinityMode.setOffCheck || EnemyInfinityMode.targetCheck) {
				GameObject target = ball;
				Vector2 relativePos = target.transform.position - EIM.SuperSonic [EIM.sonicEnemyCount].transform.position;

				float angle = Mathf.Atan2 (relativePos.y, relativePos.x) * Mathf.Rad2Deg;

				EIM.SonicRail [EIM.sonicRailEnemyCount].transform.position = EIM.SuperSonic [EIM.sonicEnemyCount].transform.position;
				EIM.SonicRail [EIM.sonicRailEnemyCount].transform.localRotation = Quaternion.Euler (0, 0, angle - 90);

				EIM.SonicRail [EIM.sonicRailEnemyCount].SetActive (false);
				EIM.SonicRail [EIM.sonicRailEnemyCount].SetActive (true);

				EIM.sonicRailEnemyCount++;

				if (EIM.sonicRailEnemyCount.Equals(20))
					EIM.sonicRailEnemyCount = 0;
			}

			EIM.sonicEnemyCount++;

			if (EIM.sonicEnemyCount.Equals(20))
				EIM.sonicEnemyCount = 0;
		}
	}
}
