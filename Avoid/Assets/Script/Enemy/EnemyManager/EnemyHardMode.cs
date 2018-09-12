using UnityEngine;
using System.Collections;

public class EnemyHardMode : MonoBehaviour {
	public MakeBeatHM MB;
	public MakeBeat2HM MB2;
	public MakeBeat3HM MB3;
	public MakeEnemyHM ME;
	public MakeMainBeatHM MMB;
	public GameObject ball = null;
	public AudioSource BGM_Source;   
	public AudioClip Music;
	public GameObject replayBtn = null;
	public GameObject SetBtn = null;
	public GameObject StopBtn = null;
	public GameObject MenuBtn = null;
	public GameObject PauseText = null;
	public GameObject[] HumingEnemy = new GameObject[10];
	public GameObject[] StrateEnemy = new GameObject[10];
	public GameObject SonicEnemy = null;
	public GameObject[] BeatEnemy = new GameObject[10];
	public GameObject[] SonicRail = new GameObject[20];
	public GameObject[] SuperSonic = new GameObject[20];
	public GameObject[] ClapSonic = new GameObject[10];
	public GameObject[] ClapRail = new GameObject[10];
	static public bool setOff = false;
	static public bool setOffCheck = true;
	static public bool targetCheck = false;
	public int starCount = 0;
	public int gridCount = 0;
	public int diagonalCount = 0;
	public int diagonalCount2 = 0;
	public int hexagonCount = 0;
	public int triPhosCount = 0;
	public int stripesCount = 0;
	public int doomCount = 0;
	public int humingEnemyCount = 0;
	public int strateEnemyCount = 0;
	public int beatEnemyCount = 0;
	public int sonicEnemyCount = 0;
	public int clapSonicCount = 0;
	public int sonicRailEnemyCount = 0;
	private bool isPause = true;
	void Awake()
	{ 
		Time.timeScale = 1;
		Screen.SetResolution (1920, 1080, true);
		BGM_Source.clip = Music;
		MMB.StartCoroutine ("MainBeat");
	}
	void Update()
	{
		checkPause ();
		if (Move.finish)
		{
			BGM_Source.Stop ();	
			CancelInvoke ();
			MMB.CancelInvoke ();
			ME.CancelInvoke ();
			MB.StopAllCoroutines ();
			MMB.StopAllCoroutines ();
			replayBtn.SetActive(true);
			SetBtn.SetActive(true);
			StopBtn.SetActive(true);
			MenuBtn.SetActive (true);
		}
	}
	void checkPause()
	{
		if (Application.platform.Equals (RuntimePlatform.Android)) {
			if ((Input.GetKey (KeyCode.Escape) || Input.GetKey(KeyCode.Home)) && !Move.finish) {
				if (isPause) {
					Time.timeScale = 0;
					BGM_Source.Pause ();
					isPause = false;
					PauseText.SetActive (true);
				}
			}
			if (Input.touchCount > 0 && !isPause){
				Time.timeScale = 1;
				BGM_Source.Play ();
				isPause = true;
				PauseText.SetActive (false);
			}
		}
	}
	void StartMakeGrid() { MB.StartCoroutine (MB.GridMaker()); }
	void StartMakeDiagonal() { MB.StartCoroutine (MB.DiagonalMaker()); }
	void StartMakeHexagon() { MB.StartCoroutine (MB.HexagonMaker()); }
	void StartMakeTriPhos() { MB.StartCoroutine (MB.TriPhosMaker()); }
	void StartMakeStripes() { MB.StartCoroutine (MB.StripesMaker()); }
	void StartMakeDiagonal2() { MB.StartCoroutine (MB.Diagonal2Maker()); }
	void StartMakeBeat() { MB.StartCoroutine (MB2.BeatMaker()); }
	void StartMakeClap1() { MB.StartCoroutine (MB2.ClapMaker1()); }
	void StartMakeClap2() { MB.StartCoroutine (MB2.ClapMaker2()); }
	void StartMakeDoom1() { MB.StartCoroutine (MB3.DoomMaker()); }
	void StartMakeDoom2() { MB.StartCoroutine (MB3.DoomMaker2()); }
	void StartMakeDoom3() { MB.StartCoroutine (MB3.DoomMaker3()); }
	void StartMakeBeep1() { MB.StartCoroutine (MB.Beep1Maker()); }
	void StartMakeBeep2() { MB.StartCoroutine (MB2.Beep2Maker()); }
	void StartMakeBeep3() { MB.StartCoroutine (MB2.Beep3Maker()); }
	void StartMakeBeep4() { MB.StartCoroutine (MB3.Beep4Maker()); }
	void ChangeTargetCheck()
	{
		if (targetCheck)
			targetCheck = false;
		else  
			targetCheck = true;
	}
	void ChangeSetOff()
	{
		if (setOff)
			setOff = false;
		else {
			setOff = true;
			Invoke ("ChangeSetOff", 0.098412364f);
		}
	}
	void ChangeSetOffCheck()
	{
		if (setOffCheck)
			setOffCheck = false;
		else 
			setOffCheck = true;
	}
	public void ReplayHardMode()
	{
		ReSet();
		Application.LoadLevel("HardMode");
	}
	public void Go_Setting()
	{
		Application.LoadLevel("Setting");
	}
	public void GoMenu()
	{
		ReSet ();
		Application.LoadLevel ("SelectPlayMode");
	}
	void ReSet()
	{
		Move.finish = false;
		setOff = false;
		setOffCheck = false;
		targetCheck = false;
		starCount = 0;
		gridCount = 0;
		diagonalCount = 0;
		hexagonCount = 0;
	}
	public void Finish_Game()
	{
		Application.Quit();
	}
}
