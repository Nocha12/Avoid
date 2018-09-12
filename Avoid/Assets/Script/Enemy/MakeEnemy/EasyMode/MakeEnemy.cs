using UnityEngine;
using System.Collections;

public class MakeEnemy : MonoBehaviour {

	public EnemyEasyMode EEM;
	public MakeEnemy2 ME2;

	public void Make_Nomal()
	{
		if (!Move.finish)
		{
			int check = Random.Range(1, 4);
			ME2.Real_Make(check, EEM.HumingEnemy[EEM.humingEnemyCount]);

			EEM.humingEnemyCount++;

			if (EEM.humingEnemyCount.Equals(10))
				EEM.humingEnemyCount = 0;
		}
	}

	public void Make_Strate()
	{
		if (!Move.finish)
		{
			int check = Random.Range(1, 4);
			ME2.Real_Make(check, EEM.StrateEnemy[EEM.strateEnemyCount]);

			EEM.strateEnemyCount++;

			if (EEM.strateEnemyCount.Equals(10))
				EEM.strateEnemyCount = 0;
		}
	}

	public void Make_Sonic()
	{
		if (!Move.finish)
		{
			int check = Random.Range(1, 4);
			ME2.Real_Make(check, EEM.SonicEnemy);
		}
	}

	public void Make_Super_Sonic()
	{
		if (!Move.finish)
		{
			int check = Random.Range(1, 4);

			ME2.Real_Make(check, EEM.SuperSonic[EEM.sonicEnemyCount]);

			if (!EnemyEasyMode.setOffCheck || EnemyEasyMode.targetCheck) {
				GameObject target = EEM.ball;
				Vector2 relativePos = target.transform.position - EEM.SuperSonic [EEM.sonicEnemyCount].transform.position;

				float angle = Mathf.Atan2 (relativePos.y, relativePos.x) * Mathf.Rad2Deg;

				EEM.SonicRail [EEM.sonicRailEnemyCount].transform.position = EEM.SuperSonic [EEM.sonicEnemyCount].transform.position;
				EEM.SonicRail [EEM.sonicRailEnemyCount].transform.localRotation = Quaternion.Euler (0, 0, angle - 90);

				EEM.SonicRail [EEM.sonicRailEnemyCount].SetActive (false);
				EEM.SonicRail [EEM.sonicRailEnemyCount].SetActive (true);

				EEM.sonicRailEnemyCount++;

				if (EEM.sonicRailEnemyCount.Equals(20))
					EEM.sonicRailEnemyCount = 0;
			}

			EEM.sonicEnemyCount++;

			if (EEM.sonicEnemyCount.Equals(20))
				EEM.sonicEnemyCount = 0;
		}
	}

	public void MakeClap()
	{
		if (!Move.finish)
		{
			int check = Random.Range(1, 4);

			ME2.Real_Make(check, EEM.ClapSonic[EEM.clapSonicCount]);

			if (!EnemyEasyMode.setOffCheck || EnemyEasyMode.targetCheck) {
				GameObject target = EEM.ball;
				Vector2 relativePos = target.transform.position - EEM.ClapSonic[EEM.clapSonicCount].transform.position;

				float angle = Mathf.Atan2 (relativePos.y, relativePos.x) * Mathf.Rad2Deg;

				EEM.ClapRail [EEM.clapSonicCount].transform.position = EEM.ClapSonic [EEM.clapSonicCount].transform.position;
				EEM.ClapRail [EEM.clapSonicCount].transform.localRotation = Quaternion.Euler (0, 0, angle - 90);

				EEM.ClapRail [EEM.clapSonicCount].SetActive (false);
				EEM.ClapRail [EEM.clapSonicCount].SetActive (true);
			}

			EEM.clapSonicCount++;

			if (EEM.clapSonicCount.Equals(5))
				EEM.clapSonicCount = 0;
		}
	}
}
