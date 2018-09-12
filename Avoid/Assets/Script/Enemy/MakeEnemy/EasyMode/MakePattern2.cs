 using UnityEngine;
using System.Collections;

public class MakePattern2 : MonoBehaviour {

	public MakeEnemy2 ME2;
	public EnemyEasyMode EEM;

	public void MakeTriPhos ()
	{
		GameObject EnemySonic = EEM.SuperSonic [EEM.sonicEnemyCount];
		GameObject EnemyRail = EEM.SonicRail [EEM.sonicEnemyCount];

		if (EEM.triPhosCount.Equals(0)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (11f, -11f), 30);
		else if (EEM.triPhosCount.Equals(1)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (2f, 11f), 150);
		else if (EEM.triPhosCount.Equals(2)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (-18.5f, -5f), -90);
		else if (EEM.triPhosCount.Equals(3))
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (-3.4f, -11f), -30);
		else if (EEM.triPhosCount.Equals(4))
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (18.5f, 1.6f), 90);
		else if (EEM.triPhosCount.Equals(5)) {
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (-9f, 11f), -150);
			EEM.triPhosCount = -1;
		}
		ME2.MakeSonicNRail (EnemySonic, EnemyRail);
		EEM.triPhosCount++;
	}

	public void MakeDiagonal2 ()
	{
		GameObject EnemySonic = EEM.SuperSonic [EEM.sonicEnemyCount];
		GameObject EnemyRail = EEM.SonicRail [EEM.sonicEnemyCount];

		if (EEM.diagonalCount2.Equals (0))
			ME2.MakeRotation (EnemySonic, EnemyRail, new Vector2 (4f, -11f), 50);
		else if (EEM.diagonalCount2.Equals (1))
			ME2.MakeRotation (EnemySonic, EnemyRail, new Vector2 (-4f, -11f), -50);
		else if (EEM.diagonalCount2.Equals (2))
			ME2.MakeRotation (EnemySonic, EnemyRail, new Vector2 (10f, -11f), 50);
		else if (EEM.diagonalCount2.Equals (3))
			ME2.MakeRotation (EnemySonic, EnemyRail, new Vector2 (-10f, -11f), -50);
		else if (EEM.diagonalCount2.Equals (4))
			ME2.MakeRotation (EnemySonic, EnemyRail, new Vector2 (16f, -11f), 50);
		else if (EEM.diagonalCount2.Equals (5)) 
			ME2.MakeRotation (EnemySonic, EnemyRail, new Vector2 (-16f, -11f), -50);
		else if (EEM.diagonalCount2.Equals (6))
			ME2.MakeRotation (EnemySonic, EnemyRail, new Vector2 (13f, 11f), 130);
		else if (EEM.diagonalCount2.Equals (7))
			ME2.MakeRotation (EnemySonic, EnemyRail, new Vector2 (-13f, 11f), -130);
		else if (EEM.diagonalCount2.Equals (8))
			ME2.MakeRotation (EnemySonic, EnemyRail, new Vector2 (7f, 11f), 130);
		else if (EEM.diagonalCount2.Equals (9))
			ME2.MakeRotation (EnemySonic, EnemyRail, new Vector2 (-7f, 11f), -130);
		else if (EEM.diagonalCount2.Equals (10))
			ME2.MakeRotation (EnemySonic, EnemyRail, new Vector2 (1f, 11f), 130);
		else if (EEM.diagonalCount2.Equals (11)) {
			ME2.MakeRotation (EnemySonic, EnemyRail, new Vector2 (-1f, 11f), -130);
			EEM.diagonalCount2 = -1;
		}
		ME2.MakeSonicNRail (EnemySonic, EnemyRail);
		EEM.diagonalCount2++;
	}
}
