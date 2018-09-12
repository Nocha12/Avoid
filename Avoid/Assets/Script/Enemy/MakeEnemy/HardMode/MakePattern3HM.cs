  using UnityEngine;
using System.Collections;

public class MakePattern3HM : MonoBehaviour {

	public MakeEnemy2HM ME2;
	public EnemyHardMode EHM;

	public void MakeDoom()
	{
		GameObject EnemySonic = EHM.SuperSonic [EHM.sonicEnemyCount];
		GameObject EnemyRail = EHM.SonicRail [EHM.sonicRailEnemyCount];

		if (EHM.doomCount.Equals(0)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (-4f, 11f));
		else if (EHM.doomCount.Equals(1)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (-11f, 11f));
		else if (EHM.doomCount.Equals(2)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (-18.5f, 9f));
		else if (EHM.doomCount.Equals(3))
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (-18.5f, 3f));
		else if (EHM.doomCount.Equals(4))
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (-18.5f, -3f));
		else if (EHM.doomCount.Equals(5)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (-18.5f, -9f));
		else if (EHM.doomCount.Equals(6)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (-11f, -11f));
		else if (EHM.doomCount.Equals(7))
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (-4f, -11f));
		else if (EHM.doomCount.Equals(8))
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (4f, -11f));
		else if (EHM.doomCount.Equals(9)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (11f, -11f));
		else if (EHM.doomCount.Equals(10)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (18.5f, -9f));
		else if (EHM.doomCount.Equals(11))
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (18.5f, -3f));
		else if (EHM.doomCount.Equals(12))
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (18.5f, 3f));
		else if (EHM.doomCount.Equals(13))
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (18.5f, 9f));
		else if (EHM.doomCount.Equals(14)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (11f, 11f));
		else if (EHM.doomCount.Equals(15)) {
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (4f, 11f));
			EHM.doomCount = -1;
		}
		ME2.MakeSonicNRail (EnemySonic, EnemyRail);
		EHM.doomCount++;
	}

	public void MakeDoom2()
	{
		GameObject EnemySonic = EHM.SuperSonic [EHM.sonicEnemyCount];
		GameObject EnemyRail = EHM.SonicRail [EHM.sonicRailEnemyCount];

		if (EHM.doomCount.Equals(0)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (-4f, 11f));
		else if (EHM.doomCount.Equals(1)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (-11f, 11f));
		else if (EHM.doomCount.Equals(2)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (-18.5f, 9f));
		else if (EHM.doomCount.Equals(3))
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (-18.5f, 3f));
		else if (EHM.doomCount.Equals(4))
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (-18.5f, -3f));
		else if (EHM.doomCount.Equals(5)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (-18.5f, -9f));
		else if (EHM.doomCount.Equals(6)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (-11f, -11f));
		else if (EHM.doomCount.Equals(7))
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (-4f, -11f));
		else if (EHM.doomCount.Equals(8))
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (4f, -11f));
		else if (EHM.doomCount.Equals(9)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (11f, -11f));
		else if (EHM.doomCount.Equals(10)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (18.5f, -9f));
		else if (EHM.doomCount.Equals(11))
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (18.5f, -3f));
		else if (EHM.doomCount.Equals(12))
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (18.5f, 3f));
		else if (EHM.doomCount.Equals(13))
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (18.5f, 9f));
		else if (EHM.doomCount.Equals(14)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (11f, 11f));
		else if (EHM.doomCount.Equals(15)) {
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (4f, 11f));
			EHM.doomCount = -1;
		}

		ME2.MakeSonicNRail (EnemySonic, EnemyRail);

		EHM.doomCount++;
	}
}
