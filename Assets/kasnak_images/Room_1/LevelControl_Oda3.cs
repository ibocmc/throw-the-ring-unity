using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class LevelControl_Oda3 : MonoBehaviour {


//	public int totalCoinScore = 3000;
//	public int currentCoinScore = 0;
	public int price;

	public Text totalCoin;
	public Text currentCoin;
	public Text time;
	public Text totalCoinGO;
	public Text overTime;
	public Text overScore;

	private TouchAndThrow thrown_;
	//private TouchAndThrowRoom3 thrownOda3;

	//public Canvas RoomSelectC;
	//public Canvas MainMenuC;
	public Canvas ops_canvas;
	//public Canvas levelUpC;
	public Canvas gameOverC;

	public Canvas L_UpC;

	levelInfo levelCall;

	Canvas RoomSelectC;
	Canvas MainMenuC;

	public float remainingTime = 180f;


	// Use this for initialization
	void Start () {

		RoomSelectC = GameObject.FindGameObjectWithTag ("roomcanvas").GetComponent<Canvas>();
		MainMenuC = GameObject.FindGameObjectWithTag ("roomcanvas").GetComponent<Canvas>();
		
		levelCall = Camera.main.GetComponent<levelInfo> ();
		//RoomSelectC = GetComponent<Canvas> ();
		RoomSelectC.enabled = false;
		//MainMenuC.enabled = true;
		ops_canvas.enabled = false;
		//levelUpC.enabled = false;
		gameOverC.enabled = false;



		thrown_ = GameObject.FindObjectOfType<TouchAndThrow> ().GetComponent<TouchAndThrow> ();
		//thrownOda3 = GameObject.FindObjectOfType<TouchAndThrowRoom3> ().GetComponent<TouchAndThrowRoom3> ();

		totalCoin.text = levelCall.coin.ToString ();



	}
		

	public void RoomSelect(){

		RoomSelectC.enabled = true;
		L_UpC.enabled = false;

	}


//	public void MenuSelect(){
//
//		MainMenuC.enabled = true;
//
//	}



	public void Play(){

		RoomSelectC.enabled = true;
	}




	public void Ops(){

		ops_canvas.enabled = true;
	}

//	public void Lose(){
//		
//
//		gameOverC.enabled = true;
//		overTime.enabled = true;
//		overScore.enabled = false;
//		totalCoinGO.text = totalCoinScore.ToString ();
//		Time.timeScale = Time.timeScale == 0 ? 1 : 0;
//	}
//
//	public void Lose2(){
//		
//
//		gameOverC.enabled = true;
//		overTime.enabled = false;
//		overScore.enabled = true;
//		totalCoinGO.text = totalCoinScore.ToString ();
//		Time.timeScale = Time.timeScale == 0 ? 1 : 0;
//	}


	public void L_Up(){
		//Time.timeScale = Time.timeScale == 0 ? 1 : 0;
		//levelUpC.enabled = true;

	}

	public void EnterGameMain(){
		MainMenuC.enabled = true;
		Time.timeScale = Time.timeScale == 0 ? 1 : 1;
		SceneManager.LoadScene (0);


	}

	public void EnterGame1_1(){
		Time.timeScale = Time.timeScale == 0 ? 1 : 1;
		SceneManager.LoadScene (1);


	}
	public void EnterGame1_2(){
		Time.timeScale = Time.timeScale == 0 ? 1 : 1;
		SceneManager.LoadScene (2);


	}
	public void EnterGame1_3(){
		Time.timeScale = Time.timeScale == 0 ? 1 : 1;
		SceneManager.LoadScene (3);


	}
	public void EnterGame2_1(){
		Time.timeScale = Time.timeScale == 0 ? 1 : 1;
		SceneManager.LoadScene (4);

	}
	public void EnterGame2_2(){
		Time.timeScale = Time.timeScale == 0 ? 1 : 1;
		SceneManager.LoadScene (5);


	}
	public void EnterGame2_3(){
		Time.timeScale = Time.timeScale == 0 ? 1 : 1;
		SceneManager.LoadScene (6);


	}
	public void EnterGame3_1(){
		Time.timeScale = Time.timeScale == 0 ? 1 : 1;
		SceneManager.LoadScene (7);


	}
	public void EnterGame3_2(){
		Time.timeScale = Time.timeScale == 0 ? 1 : 1;
		SceneManager.LoadScene (8);


	}
	public void EnterGame3_3(){
		Time.timeScale = Time.timeScale == 0 ? 1 : 1;
		SceneManager.LoadScene (9);

	}


	
	// Update is called once per frame
	void Update () {
		

//		remainingTime -= Time.deltaTime;
//
//		//Mathf.FloorToInt (remainingTime);
//
//		if(remainingTime < 0){
//			remainingTime = 0;
//
//			Lose ();
//		}
//
//
//		if(totalCoinScore <= 0 ){
//			
//			totalCoinScore = 0;
//			Lose2 ();
//
//
//		}




		if(thrown_.isThrown == true){

			levelCall.coin -= price;
			thrown_.isThrown = false;
		}

		if (levelCall.control) {
			levelCall.time -= Time.deltaTime;

			if (thrown_.isThrown == true) {

				levelCall.coin -= price;

				thrown_.isThrown = false;
			}
		}


		time.text = levelCall.time.ToString ();

		totalCoin.text = levelCall.coin.ToString ();


	}



}