using UnityEngine;
using System.Collections;

public class MakePattern3 : MonoBehaviour {

	public MakeEnemy2 ME2;
	public EnemyEasyMode EEM;

	public void MakeStripes ()
	{
		GameObject EnemySonic = EEM.SuperSonic [EEM.sonicEnemyCount];
		GameObject EnemyRail = EEM.SonicRail [EEM.sonicEnemyCount];
		if (EEM.stripesCount.Equals (0))
			ME2.MakeRotation (EnemySonic, EnemyRail, new Vector2 (-12f, 11f), 180);
		else if (EEM.stripesCount.Equals (1))
			ME2.MakeRotation (EnemySonic, EnemyRail, new Vector2 (12f, -11f), 0);
		else if (EEM.stripesCount.Equals (2))
			ME2.MakeRotation (EnemySonic, EnemyRail, new Vector2 (-8f, 11f), 180);
		else if (EEM.stripesCount.Equals (3))
			ME2.MakeRotation (EnemySonic, EnemyRail, new Vector2 (8f, -11f), 0);
		else if (EEM.stripesCount.Equals (4))
			ME2.MakeRotation (EnemySonic, EnemyRail, new Vector2 (-4f, 11f), 180);
		else if (EEM.stripesCount.Equals (5)) 
			ME2.MakeRotation (EnemySonic, EnemyRail, new Vector2 (4f, -11f), 0);
		else if (EEM.stripesCount.Equals (6))
			ME2.MakeRotation (EnemySonic, EnemyRail, new Vector2 (18.5f, -9f), 90);
		else if (EEM.stripesCount.Equals (7))
			ME2.MakeRotation (EnemySonic, EnemyRail, new Vector2 (-18.5f, 9f), -90);
		else if (EEM.stripesCount.Equals (8))
			ME2.MakeRotation (EnemySonic, EnemyRail, new Vector2 (18.5f, -6f), 90);
		else if (EEM.stripesCount.Equals (9))
			ME2.MakeRotation (EnemySonic, EnemyRail, new Vector2 (-18.5f, 6f), -90);
		else if (EEM.stripesCount.Equals (10))
			ME2.MakeRotation (EnemySonic, EnemyRail, new Vector2 (18.5f, -3f), 90);
		else if (EEM.stripesCount.Equals (11)) {
			ME2.MakeRotation (EnemySonic, EnemyRail, new Vector2 (-18.5f, 3f), -90);
			EEM.stripesCount = -1;
		}
		ME2.MakeSonicNRail (EnemySonic, EnemyRail);
		EEM.stripesCount++;
	}
	 
	public void MakeStar()
	{
		GameObject EnemySonic = EEM.SuperSonic [EEM.sonicEnemyCount];
		GameObject EnemyRail = EEM.SonicRail [EEM.sonicEnemyCount];

		if (EEM.starCount.Equals(0)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (12f, -11f), 35); 
		else if (EEM.starCount.Equals(1)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (3.3f, 11f), -215); 
		else if (EEM.starCount.Equals(2)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (-18.5f, -10f), -69); 
		else if (EEM.starCount.Equals(3)) 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (18.5f, 2f), 90); 
		else if (EEM.starCount.Equals(4)) { 
			ME2.MakeRotation(EnemySonic, EnemyRail, new Vector2 (-18.5f, 4f), -110);
			EEM.starCount = -1;
		}
		ME2.MakeSonicNRail (EnemySonic, EnemyRail);
		EEM.starCount++;
	}
}
