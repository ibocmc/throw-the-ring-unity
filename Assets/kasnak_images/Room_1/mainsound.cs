using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class mainsound : MonoBehaviour {

	Canvas mainM_C;
	Canvas Ops_C;

	public AudioSource m_music;

	public Slider mainS_Slider;
	public Slider sfxSlider;


	void Start () {

		m_music.Play ();
	}


	public void Volume(){

		m_music.volume = mainS_Slider.value;
	}


	public void Sreset(){

		mainS_Slider.value = 0.5f;
		sfxSlider.value = 0.5f;
	}

	public void Back (){

		Time.timeScale = Time.timeScale == 0 ? 1 : 1;
		mainM_C = GameObject.FindGameObjectWithTag ("MainMenu").GetComponent<Canvas> ();
		Ops_C = GameObject.FindGameObjectWithTag ("Option").GetComponent<Canvas> ();
		mainM_C.enabled = true;
		Ops_C.enabled = false;
	}

	public void Q(){

		Application.Quit ();

	}




//	public void EnterGame1_1(){
//		
//		SceneManager.LoadScene (1);
//		Time.timeScale = Time.timeScale == 0 ? 1 : 1;
//	}
//	public void EnterGame1_2(){
//
//		SceneManager.LoadScene (2);
//		Time.timeScale = Time.timeScale == 0 ? 1 : 1;
//
//	}
//	public void EnterGame1_3(){
//
//		SceneManager.LoadScene (3);
//		Time.timeScale = Time.timeScale == 0 ? 1 : 1;
//
//	}
//	public void EnterGame2_1(){
//
//		SceneManager.LoadScene (4);
//		Time.timeScale = Time.timeScale == 0 ? 1 : 1;
//
//	}
//	public void EnterGame2_2(){
//
//		SceneManager.LoadScene (5);
//		Time.timeScale = Time.timeScale == 0 ? 1 : 1;
//
//	}
//	public void EnterGame2_3(){
//
//		SceneManager.LoadScene (6);
//		Time.timeScale = Time.timeScale == 0 ? 1 : 1;
//
//	}
//	public void EnterGame3_1(){
//
//		SceneManager.LoadScene (7);
//		Time.timeScale = Time.timeScale == 0 ? 1 : 1;
//
//	}
//	public void EnterGame3_2(){
//
//		SceneManager.LoadScene (8);
//		Time.timeScale = Time.timeScale == 0 ? 1 : 1;
//
//	}
//	public void EnterGame3_3(){
//
//		SceneManager.LoadScene (9);
//		Time.timeScale = Time.timeScale == 0 ? 1 : 1;
//
//	}



}
