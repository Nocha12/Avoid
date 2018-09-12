  using UnityEngine;
using System.Collections;

public class MakePattern4HM : MonoBehaviour {

	public MakeEnemy2HM ME2;
	public EnemyHardMode EHM;

	public void MakeDoom3()
	{
		GameObject EnemySonic = EHM.SuperSonic [EHM.sonicEnemyCount];
		GameObject EnemyRail = EHM.SonicRail [EHM.sonicRailEnemyCount];

		if (EHM.doomCount.Equals(0)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (-1.5f, 11f));
		else if (EHM.doomCount.Equals(1)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (-5f, 11f));
		else if (EHM.doomCount.Equals(2)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (-9.5f, 11f));
		else if (EHM.doomCount.Equals(3))
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (-14f, 11f));
		else if (EHM.doomCount.Equals(4))
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (-18.5f, 8.6f));
		else if (EHM.doomCount.Equals(5)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (-18.5f, 6.2f));
		else if (EHM.doomCount.Equals(6)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (-18.5f, 3.8f));
		else if (EHM.doomCount.Equals(7))
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (-18.5f, 1.4f));
		else if (EHM.doomCount.Equals(8))
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (-18.5f, -1.4f));
		else if (EHM.doomCount.Equals(9)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (-18.5f, -3.8f));
		else if (EHM.doomCount.Equals(10)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (-18.5f, -6.2f));
		else if (EHM.doomCount.Equals(11))
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (-18.5f, -8.6f));
		else if (EHM.doomCount.Equals(12))
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (-14f, -11f));
		else if (EHM.doomCount.Equals(13))
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (-9.5f, -11f));
		else if (EHM.doomCount.Equals(14)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (-5f, -11f));
		else if (EHM.doomCount.Equals(15))
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (-1.5f, -11f));
		else if (EHM.doomCount.Equals(16)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (1.5f, -11f));
		else if (EHM.doomCount.Equals(17)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (5f, -11f));
		else if (EHM.doomCount.Equals(18)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (9.5f, -11f));
		else if (EHM.doomCount.Equals(19))
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (14f, -11f));
		else if (EHM.doomCount.Equals(20))
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (18.5f, -8.6f));
		else if (EHM.doomCount.Equals(21)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (18.5f, -6.2f));
		else if (EHM.doomCount.Equals(22)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (18.5f, -3.8f));
		else if (EHM.doomCount.Equals(23))
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (18.5f, -1.4f));
		else if (EHM.doomCount.Equals(24))
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (18.5f, 1.4f));
		else if (EHM.doomCount.Equals(25)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (18.5f, 3.8f));
		else if (EHM.doomCount.Equals(26)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (18.5f, 6.2f));
		else if (EHM.doomCount.Equals(27))
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (18.5f, 8.6f));
		else if (EHM.doomCount.Equals(28))
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (14f, 11f));
		else if (EHM.doomCount.Equals(29))
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (9.5f, 11f));
		else if (EHM.doomCount.Equals(30)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (5f, 11f));
		else if (EHM.doomCount.Equals(31)) {
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (1.5f, 11f));
			EHM.doomCount = -1;
		}

		ME2.MakeSonicNRail (EnemySonic, EnemyRail);

		EHM.doomCount++;
	}
}
