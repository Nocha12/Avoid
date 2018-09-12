using UnityEngine;
using System.Collections;

public class MakePatternIM : MonoBehaviour {

	public MakeEnemy2IM ME2;
	public EnemyInfinityMode EIM;

	public void MakeDoom()
	{
		GameObject EnemySonic = EIM.SuperSonic [EIM.sonicEnemyCount];
		GameObject EnemyRail = EIM.SonicRail [EIM.sonicRailEnemyCount];

		if (EIM.doomCount.Equals(0)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (-4f, 11f));
		else if (EIM.doomCount.Equals(1)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (-11f, 11f));
		else if (EIM.doomCount.Equals(2)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (-18.5f, 9f));
		else if (EIM.doomCount.Equals(3))
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (-18.5f, 3f));
		else if (EIM.doomCount.Equals(4))
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (-18.5f, -3f));
		else if (EIM.doomCount.Equals(5)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (-18.5f, -9f));
		else if (EIM.doomCount.Equals(6)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (-11f, -11f));
		else if (EIM.doomCount.Equals(7))
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (-4f, -11f));
		else if (EIM.doomCount.Equals(8))
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (4f, -11f));
		else if (EIM.doomCount.Equals(9)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (11f, -11f));
		else if (EIM.doomCount.Equals(10)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (18.5f, -9f));
		else if (EIM.doomCount.Equals(11))
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (18.5f, -3f));
		else if (EIM.doomCount.Equals(12))
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (18.5f, 3f));
		else if (EIM.doomCount.Equals(13))
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (18.5f, 9f));
		else if (EIM.doomCount.Equals(14)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (11f, 11f));
		else if (EIM.doomCount.Equals(15)) {
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (4f, 11f));
			EIM.doomCount = -1;
		}
		ME2.MakeSonicNRail (EnemySonic, EnemyRail);

		EIM.doomCount++;
	}

	public void MakeDoom2()
	{
		GameObject EnemySonic = EIM.SuperSonic [EIM.sonicEnemyCount];
		GameObject EnemyRail = EIM.SonicRail [EIM.sonicRailEnemyCount];

		if (EIM.doomCount.Equals(0)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (-4f, 11f));
		else if (EIM.doomCount.Equals(1)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (-11f, 11f));
		else if (EIM.doomCount.Equals(2)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (-18.5f, 9f));
		else if (EIM.doomCount.Equals(3))
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (-18.5f, 3f));
		else if (EIM.doomCount.Equals(4))
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (-18.5f, -3f));
		else if (EIM.doomCount.Equals(5)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (-18.5f, -9f));
		else if (EIM.doomCount.Equals(6)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (-11f, -11f));
		else if (EIM.doomCount.Equals(7))
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (-4f, -11f));
		else if (EIM.doomCount.Equals(8))
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (4f, -11f));
		else if (EIM.doomCount.Equals(9)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (11f, -11f));
		else if (EIM.doomCount.Equals(10)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (18.5f, -9f));
		else if (EIM.doomCount.Equals(11))
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (18.5f, -3f));
		else if (EIM.doomCount.Equals(12))
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (18.5f, 3f));
		else if (EIM.doomCount.Equals(13))
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (18.5f, 9f));
		else if (EIM.doomCount.Equals(14)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (11f, 11f));
		else if (EIM.doomCount.Equals(15)) {
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (4f, 11f));
			EIM.doomCount = -1;
		}
		ME2.MakeSonicNRail (EnemySonic, EnemyRail);
		EIM.doomCount++;
	}
}
