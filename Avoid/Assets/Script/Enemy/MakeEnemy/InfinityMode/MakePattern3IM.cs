 using UnityEngine;
using System.Collections;

public class MakePattern3IM : MonoBehaviour {

	public MakeEnemy2IM ME2;
	public EnemyInfinityMode EIM;

	public void MakeDiagonal ()
	{
		GameObject EnemySonic = EIM.SuperSonic [EIM.sonicEnemyCount];
		GameObject EnemyRail = EIM.SonicRail [EIM.sonicEnemyCount];

		if (EIM.diagonalCount.Equals (0))
			ME2.MakeRotation (EnemySonic, EnemyRail, new Vector2 (4f, -11f), 50);
		else if (EIM.diagonalCount.Equals (1))
			ME2.MakeRotation (EnemySonic, EnemyRail, new Vector2 (-4f, -11f), -50);
		else if (EIM.diagonalCount.Equals (2))
			ME2.MakeRotation (EnemySonic, EnemyRail, new Vector2 (10f, -11f), 50);
		else if (EIM.diagonalCount.Equals (3))
			ME2.MakeRotation (EnemySonic, EnemyRail, new Vector2 (-10f, -11f), -50);
		else if (EIM.diagonalCount.Equals (4))
			ME2.MakeRotation (EnemySonic, EnemyRail, new Vector2 (16f, -11f), 50);
		else if (EIM.diagonalCount.Equals (5)) 
			ME2.MakeRotation (EnemySonic, EnemyRail, new Vector2 (-16f, -11f), -50);
		else if (EIM.diagonalCount.Equals (6))
			ME2.MakeRotation (EnemySonic, EnemyRail, new Vector2 (13f, 11f), 130);
		else if (EIM.diagonalCount.Equals (7))
			ME2.MakeRotation (EnemySonic, EnemyRail, new Vector2 (-13f, 11f), -130);
		else if (EIM.diagonalCount.Equals (8))
			ME2.MakeRotation (EnemySonic, EnemyRail, new Vector2 (7f, 11f), 130);
		else if (EIM.diagonalCount.Equals (9))
			ME2.MakeRotation (EnemySonic, EnemyRail, new Vector2 (-7f, 11f), -130);
		else if (EIM.diagonalCount.Equals (10))
			ME2.MakeRotation (EnemySonic, EnemyRail, new Vector2 (1f, 11f), 130);
		else if (EIM.diagonalCount.Equals (11)) {
			ME2.MakeRotation (EnemySonic, EnemyRail, new Vector2 (-1f, 11f), -130);
			EIM.diagonalCount = -1;
		}
		ME2.MakeSonicNRail (EnemySonic, EnemyRail);

		EIM.diagonalCount++;
	}

	public void MakeHexagon ()
	{
		GameObject EnemySonic = EIM.SuperSonic [EIM.sonicEnemyCount];
		GameObject EnemyRail = EIM.SonicRail [EIM.sonicEnemyCount];

		if (EIM.hexagonCount.Equals(0)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (-18.5f, -5f), -90);
		else if (EIM.hexagonCount.Equals(1)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (-1f, -11f), -37);
		else if (EIM.hexagonCount.Equals(2)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (16.5f, -11f), 39);
		else if (EIM.hexagonCount.Equals(3))
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (18.5f, 5f), 90);
		else if (EIM.hexagonCount.Equals(4))
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (1f, 11f), 143);
		else if (EIM.hexagonCount.Equals(5)) {
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (-16.5f, 11f), -141);
			EIM.hexagonCount = -1;
		}

		ME2.MakeSonicNRail (EnemySonic, EnemyRail);

		EIM.hexagonCount++;
	}
}