  using UnityEngine;
using System.Collections;

public class MakePattern2HM : MonoBehaviour {

	public MakeEnemy2HM ME2;
	public EnemyHardMode EHM;

	public void MakeTriPhos ()
	{
		GameObject EnemySonic = EHM.SuperSonic [EHM.sonicEnemyCount];
		GameObject EnemyRail = EHM.SonicRail [EHM.sonicEnemyCount];

		if (EHM.triPhosCount.Equals(0)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (11f, -11f), 30);
		else if (EHM.triPhosCount.Equals(1)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (2f, 11f), 150);
		else if (EHM.triPhosCount.Equals(2)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (-18.5f, -5f), -90);
		else if (EHM.triPhosCount.Equals(3))
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (-3.4f, -11f), -30);
		else if (EHM.triPhosCount.Equals(4))
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (18.5f, 1.6f), 90);
		else if (EHM.triPhosCount.Equals(5)) {
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (-9f, 11f), -150);
			EHM.triPhosCount = -1;
		}
		ME2.MakeSonicNRail (EnemySonic, EnemyRail);
		EHM.triPhosCount++;
	}

	public void MakeDiagonal2 ()
	{
		GameObject EnemySonic = EHM.SuperSonic [EHM.sonicEnemyCount];
		GameObject EnemyRail = EHM.SonicRail [EHM.sonicEnemyCount];

		if (EHM.diagonalCount2.Equals (0))
			ME2.MakeRotation (EnemySonic, EnemyRail, new Vector2 (4f, -11f), 50);
		else if (EHM.diagonalCount2.Equals (1))
			ME2.MakeRotation (EnemySonic, EnemyRail, new Vector2 (-4f, -11f), -50);
		else if (EHM.diagonalCount2.Equals (2))
			ME2.MakeRotation (EnemySonic, EnemyRail, new Vector2 (10f, -11f), 50);
		else if (EHM.diagonalCount2.Equals (3))
			ME2.MakeRotation (EnemySonic, EnemyRail, new Vector2 (-10f, -11f), -50);
		else if (EHM.diagonalCount2.Equals (4))
			ME2.MakeRotation (EnemySonic, EnemyRail, new Vector2 (16f, -11f), 50);
		else if (EHM.diagonalCount2.Equals (5)) 
			ME2.MakeRotation (EnemySonic, EnemyRail, new Vector2 (-16f, -11f), -50);
		else if (EHM.diagonalCount2.Equals (6))
			ME2.MakeRotation (EnemySonic, EnemyRail, new Vector2 (13f, 11f), 130);
		else if (EHM.diagonalCount2.Equals (7))
			ME2.MakeRotation (EnemySonic, EnemyRail, new Vector2 (-13f, 11f), -130);
		else if (EHM.diagonalCount2.Equals (8))
			ME2.MakeRotation (EnemySonic, EnemyRail, new Vector2 (7f, 11f), 130);
		else if (EHM.diagonalCount2.Equals (9))
			ME2.MakeRotation (EnemySonic, EnemyRail, new Vector2 (-7f, 11f), -130);
		else if (EHM.diagonalCount2.Equals (10))
			ME2.MakeRotation (EnemySonic, EnemyRail, new Vector2 (1f, 11f), 130);
		else if (EHM.diagonalCount2.Equals (11)) {
			ME2.MakeRotation (EnemySonic, EnemyRail, new Vector2 (-1f, 11f), -130);
			EHM.diagonalCount2 = -1;
		}
		ME2.MakeSonicNRail (EnemySonic, EnemyRail);
		EHM.diagonalCount2++;
	}

	public void MakeStripes ()
	{
		GameObject EnemySonic = EHM.SuperSonic [EHM.sonicEnemyCount];
		GameObject EnemyRail = EHM.SonicRail [EHM.sonicEnemyCount];

		if (EHM.stripesCount.Equals (0))
			ME2.MakeRotation (EnemySonic, EnemyRail, new Vector2 (-12f, 11f), 180);
		else if (EHM.stripesCount.Equals (1))
			ME2.MakeRotation (EnemySonic, EnemyRail, new Vector2 (12f, -11f), 0);
		else if (EHM.stripesCount.Equals (2))
			ME2.MakeRotation (EnemySonic, EnemyRail, new Vector2 (-8f, 11f), 180);
		else if (EHM.stripesCount.Equals (3))
			ME2.MakeRotation (EnemySonic, EnemyRail, new Vector2 (8f, -11f), 0);
		else if (EHM.stripesCount.Equals (4))
			ME2.MakeRotation (EnemySonic, EnemyRail, new Vector2 (-4f, 11f), 180);
		else if (EHM.stripesCount.Equals (5)) 
			ME2.MakeRotation (EnemySonic, EnemyRail, new Vector2 (4f, -11f), 0);
		else if (EHM.stripesCount.Equals (6))
			ME2.MakeRotation (EnemySonic, EnemyRail, new Vector2 (18.5f, -9f), 90);
		else if (EHM.stripesCount.Equals (7))
			ME2.MakeRotation (EnemySonic, EnemyRail, new Vector2 (-18.5f, 9f), -90);
		else if (EHM.stripesCount.Equals (8))
			ME2.MakeRotation (EnemySonic, EnemyRail, new Vector2 (18.5f, -6f), 90);
		else if (EHM.stripesCount.Equals (9))
			ME2.MakeRotation (EnemySonic, EnemyRail, new Vector2 (-18.5f, 6f), -90);
		else if (EHM.stripesCount.Equals (10))
			ME2.MakeRotation (EnemySonic, EnemyRail, new Vector2 (18.5f, -3f), 90);
		else if (EHM.stripesCount.Equals (11)) {
			ME2.MakeRotation (EnemySonic, EnemyRail, new Vector2 (-18.5f, 3f), -90);
			EHM.stripesCount = -1;
		}
		ME2.MakeSonicNRail (EnemySonic, EnemyRail);

		EHM.stripesCount++;
	}
}
