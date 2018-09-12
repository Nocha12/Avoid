using UnityEngine;
using System.Collections;

public class MakePatternHM : MonoBehaviour {

	public MakeEnemy2HM ME2;
	public EnemyHardMode EHM;

	public void MakeGrid()
	{
		GameObject EnemySonic = EHM.SuperSonic [EHM.sonicEnemyCount];
		GameObject EnemyRail = EHM.SonicRail [EHM.sonicEnemyCount];

		if (EHM.gridCount.Equals(0)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (-10f, 11f), 180); 
		else if (EHM.gridCount.Equals(1)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (0f, 11f), 180); 
		else if (EHM.gridCount.Equals(2)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (10f, 11f), 180); 
		else if (EHM.gridCount.Equals(3)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (18.5f, 5f), 90); 
		else if (EHM.gridCount.Equals(4)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (18.5f, 0f), 90);
		else if (EHM.gridCount.Equals(5)) {
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (18.5f, -5f), 90);
			EHM.gridCount = -1;
		}
		ME2.MakeSonicNRail (EnemySonic, EnemyRail);
		EHM.gridCount++;
	}

	public void MakeDiagonal()
	{
		GameObject EnemySonic = EHM.SuperSonic [EHM.sonicEnemyCount];
		GameObject EnemyRail = EHM.SonicRail [EHM.sonicEnemyCount];

		if (EHM.diagonalCount.Equals(0)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (0f, 11f), 120);
		else if (EHM.diagonalCount.Equals(1)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (15f, 11f), 120);
		else if (EHM.diagonalCount.Equals(2)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (30f, 11f), 120);
		else if (EHM.diagonalCount.Equals(3))
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (0f, -11f), 60);
		else if (EHM.diagonalCount.Equals(4))
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (15f, -11f), 60);
		else if (EHM.diagonalCount.Equals(5)) {
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (30f, -11f), 60);
			EHM.diagonalCount = -1;
		}

		ME2.MakeSonicNRail (EnemySonic, EnemyRail);

		EHM.diagonalCount++;
	}

	public void MakeHexagon ()
	{
		GameObject EnemySonic = EHM.SuperSonic [EHM.sonicEnemyCount];
		GameObject EnemyRail = EHM.SonicRail [EHM.sonicEnemyCount];

		if (EHM.hexagonCount.Equals(0)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (-18.5f, -5f), -90);
		else if (EHM.hexagonCount.Equals(1)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (-1f, -11f), -37);
		else if (EHM.hexagonCount.Equals(2)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (16.5f, -11f), 39);
		else if (EHM.hexagonCount.Equals(3))
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (18.5f, 5f), 90);
		else if (EHM.hexagonCount.Equals(4))
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (1f, 11f), 143);
		else if (EHM.hexagonCount.Equals(5)) {
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (-16.5f, 11f), -141);
			EHM.hexagonCount = -1;
		}
		ME2.MakeSonicNRail (EnemySonic, EnemyRail);
		EHM.hexagonCount++;
	}
}
