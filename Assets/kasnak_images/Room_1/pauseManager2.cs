using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class pauseManager2 : MonoBehaviour {

	  Canvas P_canvas;

	levelInfo levelCall;

	public Text currentS;
	public Text totalS;
//	private LevelControl InitialPos;
//	private LevelControl2 current_s;
//	private LevelControl2 total_s;
//	private LevelControl R_Body;
//	private TouchTest touchSystem;
//	private TouchTest isThr;

	// Use this for initialization
	void Start () {

		levelCall = Camera.main.GetComponent<levelInfo> ();
	//	touchSystem = GameObject.FindObjectOfType<TouchTest> ().GetComponent<TouchTest> ();
	//	InitialPos = GameObject.FindObjectOfType<LevelControl> ().GetComponent<LevelControl> ();
//		current_s = GameObject.FindObjectOfType<LevelControl2> ().GetComponent<LevelControl2> ();
//		total_s = GameObject.FindObjectOfType<LevelControl2> ().GetComponent<LevelControl2> ();
	//	R_Body = GameObject.FindObjectOfType<LevelControl> ().GetComponent<LevelControl> ();
	//	isThr = GameObject.FindObjectOfType<TouchTest> ().GetComponent<TouchTest> ();


		P_canvas = GetComponent<Canvas> ();
		P_canvas.enabled = false;

		
	}
	
	// Update is called once per frame
	void Update () {


		currentS.text =levelCall.coin.ToString();
		totalS.text = levelCall.coin.ToString();

		
	}

	public void Pause(){

		P_canvas.enabled =! P_canvas.enabled;

		Time.timeScale = Time.timeScale == 0 ? 1 : 0;


//		isThr.isThrown = false;
//		touchSystem.canSwipe = true;
	}









	public void Quit(){


		#if UNITY_EDITOR
		EditorApplication.isPlaying = false;
		#else
		Application.Quit();
		#endif



	}
}
