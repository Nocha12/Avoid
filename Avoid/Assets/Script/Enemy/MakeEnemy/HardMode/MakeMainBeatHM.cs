using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MakeMainBeatHM : MonoBehaviour {
	
	public EnemyHardMode EHM;

	public GameObject ClearText;
	public GameObject ReplayBtn;
	public GameObject MenuBtn;
	public GameObject ExitBtn;

	public Text PerText = null;
	private int per;
	private int cnt = 0;

	void Start()
	{
		StartCoroutine (PlusPer());
	}

	IEnumerator PlusPer()
	{
		while (per < 100 && !Move.finish)
		{
			per = cnt * 10 / 9;
			PerText.text = per.ToString() + "%";
			cnt++;
			yield return new WaitForSeconds (1f);
		}
	}


	public IEnumerator MainBeat()
	{
		EHM.BGM_Source.Play();

		EHM.Invoke ("StartMakeClap1", 0.0812523471f);
		EHM.Invoke ("StartMakeBeat", 0.08125123537f);
		yield return new WaitForSeconds (10f);
		EHM.Invoke ("StartMakeGrid", 0.64f);
		EHM.Invoke ("ChangeSetOff", 1.78f);
		EHM.Invoke ("StartMakeBeep1", 2.16f);
		EHM.Invoke ("StartMakeBeep2", 3.78f);
		EHM.Invoke ("StartMakeBeep3", 5.1f);//3.2
		EHM.Invoke ("StartMakeBeep1", 8.3f);
		EHM.Invoke ("StartMakeBeep2", 9.9f);
		yield return new WaitForSeconds (10f);
		EHM.Invoke ("StartMakeBeep4", 1.4f);//1.5
		EHM.Invoke ("StartMakeDiagonal", 2.8f);
		EHM.Invoke ("ChangeSetOff", 3.94f);
		EHM.Invoke ("StartMakeBeep1", 4.32f);//1.62
		EHM.Invoke ("StartMakeBeep2", 5.94f);//1.31
		EHM.Invoke ("StartMakeBeep3", 7.25f);
		yield return new WaitForSeconds (10f);
		EHM.Invoke ("StartMakeBeep1", 0.5f);
		EHM.Invoke ("StartMakeBeep2", 1.92f);
		EHM.Invoke ("StartMakeTriPhos", 4.96f);
		EHM.Invoke ("ChangeSetOff", 6.1f);
		EHM.Invoke ("StartMakeDoom1", 6.48f);
		yield return new WaitForSeconds (10f);
		EHM.Invoke ("StartMakeDoom2", 2.56f);
		EHM.Invoke ("StartMakeDoom3", 5.6f);
		EHM.Invoke ("StartMakeStripes", 7.5f); 
		EHM.Invoke ("StartMakeClap2", 8.3834123f); 
		EHM.Invoke ("StartMakeBeep1", 8.4f);
		yield return new WaitForSeconds (10f);
		EHM.Invoke ("StartMakeBeep2", 0.02f);
		EHM.Invoke ("StartMakeBeep3", 1.43f);
		EHM.Invoke ("StartMakeBeep1", 4.63f);
		EHM.Invoke ("StartMakeBeep2", 6.25f);
		EHM.Invoke ("StartMakeBeep4", 7.75f);
		EHM.Invoke ("StartMakeHexagon", 9.15f);
		yield return new WaitForSeconds (10f);
		EHM.Invoke ("StartMakeBeep1", 0.57f);
		EHM.Invoke ("StartMakeBeep2", 2.19f);
		EHM.Invoke ("StartMakeBeep3", 3.5f);
		EHM.Invoke ("StartMakeBeep1", 6.7f);
		EHM.Invoke ("StartMakeBeep2", 8.32f);
		EHM.Invoke ("StartMakeBeep4", 9.82f);
		yield return new WaitForSeconds (10f);
		EHM.Invoke ("StartMakeDiagonal2", 1.22f);
		EHM.Invoke ("StartMakeBeep1", 2.64f);
		EHM.Invoke ("StartMakeBeep2", 4.26f);
		EHM.Invoke ("StartMakeBeep3", 5.57f);
		EHM.Invoke ("StartMakeBeep1", 8.77f);
		yield return new WaitForSeconds (10f);
		EHM.Invoke ("StartMakeBeep2", 0.39f);
		EHM.Invoke ("StartMakeBeep3", 1.7f);
		EHM.Invoke ("StartMakeDoom1", 4.9f);
		yield return new WaitForSeconds (10f);
		EHM.Invoke ("StartMakeDoom2", 0.98f);
		EHM.Invoke ("StartMakeDoom3", 4.02f);
		EHM.Invoke ("StartMakeStripes", 5.92f); 
		EHM.Invoke ("StartMakeTriPhos", 5.92f); 
		Invoke ("Clear", 8f);
	}
		
	void Clear()
	{
		ClearText.SetActive (true);
		ReplayBtn.SetActive (true);
		MenuBtn.SetActive (true);
		ExitBtn.SetActive (true);
	}
}
