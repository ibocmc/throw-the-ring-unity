using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class LevelControl2 : MonoBehaviour {
	
	public int price;

	public Text totalCoin;
	public Text currentCoin;
	public Text time;
	public Text totalCoinGO;
	public Text overTime;
	public Text overScore;

	private TouchAndThrow thrown_;


	Canvas RoomSelectC;
	Canvas MainMenuC;


	public Canvas ops_canvas;
	public Canvas L_UpC;

	public Canvas gameOverC;

	levelInfo levelcall;


	public float remainingTime = 180f;


	// Use this for initialization
	void Start () {
		
		levelcall = Camera.main.GetComponent<levelInfo> ();

		RoomSelectC = GameObject.FindGameObjectWithTag ("roomcanvas").GetComponent<Canvas>();
		MainMenuC = GameObject.FindGameObjectWithTag ("roomcanvas").GetComponent<Canvas>();



		RoomSelectC.enabled = false;

		ops_canvas.enabled = false;

		gameOverC.enabled = false;



		thrown_ = GameObject.FindObjectOfType<TouchAndThrow> ().GetComponent<TouchAndThrow> ();

		//thrownOda3 = GameObject.FindObjectOfType<TouchAndThrowRoom3> ().GetComponent<TouchAndThrowRoom3> ();

		totalCoin.text = levelcall.coin.ToString ();


	}
		

	public void RoomSelect(){
		
		L_UpC.enabled = false;
		RoomSelectC.enabled = true;

	}
		

	public void Play(){

		RoomSelectC.enabled = true;
//		adManager.Instance.ShowVideo ();
	}

	public void Back(){
		Time.timeScale = Time.timeScale == 0 ? 1 : 1;

		ops_canvas.enabled = false;
		RoomSelectC.enabled = false;

	}


	public void Ops(){

		ops_canvas.enabled = true;
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


	void Update () {

		if (levelcall.control) {
			levelcall.time -= Time.deltaTime;

			if (thrown_.isThrown == true) {

				levelcall.coin -= price;

				thrown_.isThrown = false;
			}
		}

		time.text = levelcall.time.ToString ();

		totalCoin.text = levelcall.coin.ToString ();


	}



}