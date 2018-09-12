using UnityEngine;
using System.Collections;

public class MakeEnemyHM : MonoBehaviour {

	public EnemyHardMode EHM;
	public MakeEnemy2HM ME2;

	public void Make_Nomal()
	{
		if (!Move.finish)
		{
			int check = Random.Range(1, 4);
			ME2.Real_Make(check, EHM.HumingEnemy[EHM.humingEnemyCount]);

			EHM.humingEnemyCount++;

			if (EHM.humingEnemyCount.Equals(10))
				EHM.humingEnemyCount = 0;
		}
	}

	public void Make_Strate()
	{
		if (!Move.finish)
		{
			int check = Random.Range(1, 4);
			ME2.Real_Make(check, EHM.StrateEnemy[EHM.strateEnemyCount]);

			EHM.strateEnemyCount++;

			if (EHM.strateEnemyCount.Equals(10))
				EHM.strateEnemyCount = 0;
		}
	}

	public void Make_Sonic()
	{
		if (!Move.finish)
		{
			int check = Random.Range(1, 4);
			ME2.Real_Make(check, EHM.SonicEnemy);
		}
	}

	public void Make_Super_Sonic()
	{
		if (!Move.finish)
		{
			int check = Random.Range(1, 4);

			ME2.Real_Make(check, EHM.SuperSonic[EHM.sonicEnemyCount]);

			if (!EnemyHardMode.setOffCheck || EnemyHardMode.targetCheck) {
				GameObject target = EHM.ball;
				Vector2 relativePos = target.transform.position - EHM.SuperSonic [EHM.sonicEnemyCount].transform.position;

				float angle = Mathf.Atan2 (relativePos.y, relativePos.x) * Mathf.Rad2Deg;

				EHM.SonicRail [EHM.sonicRailEnemyCount].transform.position = EHM.SuperSonic [EHM.sonicEnemyCount].transform.position;
				EHM.SonicRail [EHM.sonicRailEnemyCount].transform.localRotation = Quaternion.Euler (0, 0, angle - 90);

				EHM.SonicRail [EHM.sonicRailEnemyCount].SetActive (false);
				EHM.SonicRail [EHM.sonicRailEnemyCount].SetActive (true);

				EHM.sonicRailEnemyCount++;

				if (EHM.sonicRailEnemyCount.Equals(20))
					EHM.sonicRailEnemyCount = 0;
			}

			EHM.sonicEnemyCount++;

			if (EHM.sonicEnemyCount.Equals(20))
				EHM.sonicEnemyCount = 0;
		}
	}

	public void MakeClap()
	{
		if (!Move.finish)
		{
			int check = Random.Range(1, 4);

			ME2.Real_Make(check, EHM.ClapSonic[EHM.clapSonicCount]);

			if (!EnemyHardMode.setOffCheck || EnemyHardMode.targetCheck) {
				GameObject target = EHM.ball;
				Vector2 relativePos = target.transform.position - EHM.ClapSonic[EHM.clapSonicCount].transform.position;

				float angle = Mathf.Atan2 (relativePos.y, relativePos.x) * Mathf.Rad2Deg;

				EHM.ClapRail [EHM.clapSonicCount].transform.position = EHM.ClapSonic [EHM.clapSonicCount].transform.position;
				EHM.ClapRail [EHM.clapSonicCount].transform.localRotation = Quaternion.Euler (0, 0, angle - 90);

				EHM.ClapRail [EHM.clapSonicCount].SetActive (false);
				EHM.ClapRail [EHM.clapSonicCount].SetActive (true);
			}

			EHM.clapSonicCount++;

			if (EHM.clapSonicCount.Equals(10))
				EHM.clapSonicCount = 0;
		}
	}
}
