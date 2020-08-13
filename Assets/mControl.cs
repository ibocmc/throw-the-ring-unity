
//Copyright © 2018 Imece Ajans
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;


public class mControl : MonoBehaviour {




	public Canvas RoomSelectC;

	 Canvas ops_canvas;

	 Canvas mainM_C;

	public static mControl instance;

	void Awake(){

		SingletonControl ();
	}

	public void SingletonControl()
	{
		if (GameObject.Find (gameObject.name) && !this.gameObject) {
			Destroy (GameObject.Find (gameObject.name));
		}
			
		if(instance == null){

			DontDestroyOnLoad (this);
			instance = this;

		}
		else{

			Destroy (this);
		}
	}
//	public float remainingTime = 180f;

	void AllSingletons()
	{
//		MainMenuController.instance.SingletonControl ();
//		game_Manager.instance.SingletonControl ();
//		UnlockController.instance.SingletonControl ();
//		unlockRoomCanvas.instance.SingletonControl ();
//		UnlockCanvas.instance.SingletonControl ();
//		OptionController.instance.SingletonControl ();
	
		//SingletonControl ();
	}
	// Use this for initialization
	void Start () {


		//loadC = GameObject.FindGameObjectWithTag ("loadc").GetComponent<Canvas> ();

		ops_canvas = GameObject.FindGameObjectWithTag ("Option").GetComponent<Canvas> ();

		RoomSelectC.enabled = false;

		ops_canvas.enabled = false;

		//loadC.enabled = false;

//		gameOverC.enabled = false;

	



		//thrownOda3 = GameObject.FindObjectOfType<TouchAndThrowRoom3> ().GetComponent<TouchAndThrowRoom3> ();

//		totalCoin.text = totalCoinScore.ToString ();


	}

	void Update(){

		if (Input.GetKeyDown (KeyCode.Escape))
			Application.Quit ();
		}






	public void RoomSelect(){
		AllSingletons ();
		mainM_C = GameObject.FindGameObjectWithTag ("MainMenu").GetComponent<Canvas> ();
		RoomSelectC.enabled = true;
		mainM_C.enabled = false;

		//loadC.enabled = false;

	}


//	public void Play(){
//
//		RoomSelectC.enabled = true;
//		//adManager.Instance.ShowVideo ();
//	}

	public void Back(){
		Time.timeScale = Time.timeScale == 0 ? 1 : 1;
		AllSingletons ();
		mainM_C = GameObject.FindGameObjectWithTag ("MainMenu").GetComponent<Canvas> ();
		ops_canvas = GameObject.FindGameObjectWithTag ("Option").GetComponent<Canvas> ();
		ops_canvas.enabled = false;
		mainM_C.enabled = true;
		RoomSelectC.enabled = false;
		//loadC.enabled = false;

	}


	public void Ops(){
		AllSingletons ();
		ops_canvas = GameObject.FindGameObjectWithTag ("Option").GetComponent<Canvas> ();
		mainM_C = GameObject.FindGameObjectWithTag ("MainMenu").GetComponent<Canvas> ();

		ops_canvas.enabled = true;
		mainM_C.enabled = false;
		//loadC.enabled = false;
	}


	public void QuitGame(){
		Debug.Log ("quit");
		Application.Quit ();

	}

	public void EnterGameMain(){

		SceneManager.LoadScene (0);
		AllSingletons ();
		mainM_C = GameObject.FindGameObjectWithTag ("MainMenu").GetComponent<Canvas> ();

		mainM_C.enabled = true;
		RoomSelectC.enabled = false;

		Time.timeScale = Time.timeScale == 0 ? 1 : 1;

	}

	public void EnterGame1_1(int Level){
		Time.timeScale = Time.timeScale == 0 ? 1 : 1;
		RoomSelectC.enabled = false;

		SceneManager.LoadScene (Level);

	}




}