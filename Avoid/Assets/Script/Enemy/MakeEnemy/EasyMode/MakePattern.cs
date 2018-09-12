using UnityEngine;
using System.Collections;

public class MakePattern : MonoBehaviour {

	public MakeEnemy2 ME2;
	public EnemyEasyMode EEM;

	public void MakeGrid()
	{
		GameObject EnemySonic = EEM.SuperSonic [EEM.sonicEnemyCount];
		GameObject EnemyRail = EEM.SonicRail [EEM.sonicEnemyCount];

		if (EEM.gridCount.Equals(0)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (-10f, 11f), 180); 
		else if (EEM.gridCount.Equals(1)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (0f, 11f), 180); 
		else if (EEM.gridCount.Equals(2)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (10f, 11f), 180); 
		else if (EEM.gridCount.Equals(3)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (18.5f, 5f), 90); 
		else if (EEM.gridCount.Equals(4)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (18.5f, 0f), 90);
		else if (EEM.gridCount.Equals(5)) {
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (18.5f, -5f), 90);
			EEM.gridCount = -1;
		}
		ME2.MakeSonicNRail (EnemySonic, EnemyRail);
		EEM.gridCount++;
	}

	public void MakeDiagonal()
	{
		GameObject EnemySonic = EEM.SuperSonic [EEM.sonicEnemyCount];
		GameObject EnemyRail = EEM.SonicRail [EEM.sonicEnemyCount];

		if (EEM.diagonalCount.Equals(0)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (0f, 11f), 120);
		else if (EEM.diagonalCount.Equals(1)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (15f, 11f), 120);
		else if (EEM.diagonalCount.Equals(2)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (30f, 11f), 120);
		else if (EEM.diagonalCount.Equals(3))
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (0f, -11f), 60);
		else if (EEM.diagonalCount.Equals(4))
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (15f, -11f), 60);
		else if (EEM.diagonalCount.Equals(5)) {
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (30f, -11f), 60);
			EEM.diagonalCount = -1;
		}
		ME2.MakeSonicNRail (EnemySonic, EnemyRail);
		EEM.diagonalCount++;
	}

	public void MakeHexagon ()
	{
		GameObject EnemySonic = EEM.SuperSonic [EEM.sonicEnemyCount];
		GameObject EnemyRail = EEM.SonicRail [EEM.sonicEnemyCount];

		if (EEM.hexagonCount.Equals(0)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (-18.5f, -5f), -90);
		else if (EEM.hexagonCount.Equals(1)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (-1f, -11f), -37);
		else if (EEM.hexagonCount.Equals(2)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (16.5f, -11f), 39);
		else if (EEM.hexagonCount.Equals(3))
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (18.5f, 5f), 90);
		else if (EEM.hexagonCount.Equals(4))
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (1f, 11f), 143);
		else if (EEM.hexagonCount.Equals(5)) {
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (-16.5f, 11f), -141);
			EEM.hexagonCount = -1;
		}
		ME2.MakeSonicNRail (EnemySonic, EnemyRail);
		EEM.hexagonCount++;
	}
}
