using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MakeMainBeat : MonoBehaviour {

	public MakeEnemy ME;
	public EnemyEasyMode EEM;

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
		EEM.BGM_Source.Play();

		EnemyEasyMode.setOffCheck = true;
		EEM.Invoke ("StartMakeStar", 0.08f);  
		EEM.Invoke ("ChangeTargetCheck", 2.02f);
		ME.Invoke ("Make_Super_Sonic", 2.02f);
		EEM.Invoke ("ChangeTargetCheck", 2.1f);
		EEM.Invoke ("ChangeSetOff", 2.3f);
		EEM.Invoke ("StartMakeGrid", 3.8f);
		EEM.Invoke ("ChangeSetOff", 6f);
		ME.Invoke ("Make_Sonic", 7.5f);
		yield return new WaitForSeconds (10f);
		EEM.Invoke ("StartMakeOther", 1.2f);
		EEM.Invoke ("ChangeSetOff", 3.5f);
		EEM.Invoke ("StartMakeBeat", 5f);
		EEM.Invoke ("StartMakeDiagonal", 5f);
		EEM.Invoke ("ChangeSetOff", 7.2f);
		EEM.Invoke ("StartMakeGrid", 8.7f);
		yield return new WaitForSeconds (10f);
		EEM.Invoke ("ChangeSetOff", 0.9f);
		EEM.Invoke ("StartMakeDiagonal", 2.5f);
		EEM.Invoke ("StartMakeGrid", 2.5f);
		EEM.Invoke ("ChangeSetOff", 4.6f);
		EEM.Invoke ("StartMakeOther", 6.3f);
		ME.Invoke ("Make_Sonic", 6.3f);
		EEM.Invoke ("ChangeSetOff", 8.55f);
		EEM.Invoke ("StartMakeClap1", 9.87232173819f);
		yield return new WaitForSeconds (10f);
		EEM.Invoke ("StartMakeGrid", 3.8f);
		EEM.Invoke ("ChangeSetOff", 6f);
		EEM.Invoke ("StartMakeDiagonal", 7.6f);
		EEM.Invoke ("ChangeSetOff", 9.8f);
		yield return new WaitForSeconds (10f);
		EEM.Invoke ("StartMakeDiagonal", 1.2f);
		EEM.Invoke ("StartMakeGrid", 1.2f);
		EEM.Invoke ("ChangeSetOff", 3.5f);
		EEM.Invoke ("StartMakeHexagon", 5f);
		EEM.Invoke ("ChangeSetOff", 7.2f);
		EEM.Invoke ("StartMakeTriPhos", 8.7f);
		yield return new WaitForSeconds (10f);
		EEM.Invoke ("ChangeSetOff", 0.9f);
		EEM.Invoke ("StartMakeOther", 2.456929761867f);
		EEM.Invoke ("StartMakeDiagonal", 2.5f);
		EEM.Invoke ("ChangeSetOff", 4.6f);
		EEM.Invoke ("StartMakeOther", 6.199999761708f);
		EEM.Invoke ("StartMakeHexagon", 6.3f);
		EEM.Invoke ("ChangeSetOff", 8.55f);
		EEM.Invoke ("StartMakeClap2", 9.9127959392023176594837f);
		yield return new WaitForSeconds (10f);
		EEM.Invoke ("StartMakeBeat", 0f);
		EEM.Invoke ("StartMakeOther", 0.0000021f);
		EEM.Invoke ("ChangeSetOff", 2.3f);
		EEM.Invoke ("StartMakeBeep1", 2.6f);
		EEM.Invoke ("ChangeSetOff", 3.6f);
		EEM.Invoke ("StartMakeGrid", 3.7f);
		EEM.Invoke ("ChangeSetOff", 6f);
		EEM.Invoke ("StartMakeBeep1", 6.3f);
		EEM.Invoke ("ChangeSetOff", 7.5f);
		EEM.Invoke ("StartMakeDiagonal", 7.6f);
		EEM.Invoke ("ChangeSetOff", 9.8f);
		yield return new WaitForSeconds (10f);
		EEM.Invoke ("StartMakeBeep1", 0.1f);
		EEM.Invoke ("ChangeSetOff", 1.1f);
		ME.Invoke ("Make_Sonic", 1.2f);
		EEM.Invoke ("StartMakeBeep3", 2.7f);
		EEM.Invoke ("ChangeSetOff", 4.8f);
		EEM.Invoke ("StartMakeStripes", 4.9f);
		EEM.Invoke ("ChangeSetOff", 7.15f);
		EEM.Invoke ("StartMakeBeep1",7.5f);
		EEM.Invoke ("ChangeSetOff", 8.58999f);
		EEM.Invoke ("StartMakeDiagonal2", 8.75f);
		yield return new WaitForSeconds (10f);
		EEM.Invoke ("ChangeSetOff", 0.9f);
		EEM.Invoke ("StartMakeBeep2", 1.1f);
		EEM.Invoke ("ChangeSetOff", 2.25f);
		EEM.Invoke ("StartMakeStripes", 2.3f);
		EEM.Invoke ("StartMakeDiagonal", 2.3f);
		EEM.Invoke ("ChangeSetOff", 4.4f);
		EEM.Invoke ("StartMakeBeep1", 4.7f);
		EEM.Invoke ("ChangeSetOff", 5.9f);
		EEM.Invoke ("StartMakeBeep3", 7.5f);
		EEM.Invoke ("ChangeSetOff", 9.6f);
		Invoke ("Clear", 11f);
	}

	void Clear()
	{
		ClearText.SetActive (true);
		ReplayBtn.SetActive (true);
		MenuBtn.SetActive (true);
		ExitBtn.SetActive (true);
	}
}
