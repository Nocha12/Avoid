using UnityEngine;
using System.Collections;

public class EnemyInfinityMode : MonoBehaviour {
	public MakeBeatIM MB;
	public MakeEnemyIM ME;
	public MakeMainBeatIM MMB;
	public AudioSource BGM_Source;   
	public AudioClip Music;
	public GameObject ball = null;
	public GameObject replayBtn = null;
	public GameObject SetBtn = null;
	public GameObject StopBtn = null;
	public GameObject MenuBtn = null;
	public GameObject PauseText = null;
	public GameObject[] HumingEnemy = new GameObject[20];
	public GameObject[] StrateEnemy = new GameObject[20];
	public GameObject SonicEnemy = null;
	public GameObject[] BeatEnemy = new GameObject[10];
	public GameObject[] SonicRail = new GameObject[20];
	public GameObject[] SuperSonic = new GameObject[20];
	static public bool setOff = false;
	static public bool setOffCheck = true;
	static public bool targetCheck = false;
	public int doomCount = 0;
	public int diagonalCount = 0;
	public int hexagonCount = 0;
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
			MenuBtn.SetActive(true);
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
	public void ReplayInfinityMode()
	{
		ReSet();
		Application.LoadLevel("InfinityMode");
	}
	public void Go_Setting()
	{
		Application.LoadLevel("Setting");
	}
	public void GoMenu()
	{
		ReSet();
		Application.LoadLevel("SelectPlayMode");
	}
	void ReSet()
	{
		Move.finish = false;
		setOff = false;
		setOffCheck = false;
		targetCheck = false;
		doomCount = 0;
		diagonalCount = 0;
		hexagonCount = 0;
		MakeMainBeatIM.score = 0;
	}
	public void Finish_Game()
	{
		Application.Quit();
	}
}
