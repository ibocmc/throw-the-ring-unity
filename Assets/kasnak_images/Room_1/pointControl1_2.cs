using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pointControl1_2 : MonoBehaviour {

	levelInfo levelCall;


	public GameObject throwEffect_good;
	public GameObject throwEffect_perfect;
	public GameObject throwEffect_excelent;
	public GameObject throwEffect_awesome;

	public GameObject trapEffect;


	public GameObject coinEffect;
	public GameObject coinEffect2;



	public Transform[] coinEffect_T;


	public bool score;


	private goldmanage1_2 clist1_2;



	// Use this for initialization
	void Start () {

		levelCall = Camera.main.GetComponent<levelInfo> ();

		clist1_2 = GameObject.FindObjectOfType<goldmanage1_2> ().GetComponent<goldmanage1_2> ();

		score = false;



	}


	void OnTriggerEnter(Collider other){

		if (other.gameObject.tag == "ikiyüzelli_2") {


			levelCall.coin += 250;


			clist1_2.coinList.Remove (GameObject.Find ("gold12"));

			if(!score){
				score = true;
			Instantiate (throwEffect_good, throwEffect_good.transform.position, throwEffect_good.transform.rotation);
			Instantiate (coinEffect, coinEffect_T[0].transform.position, Quaternion.identity);
			}
			score = false;
			Destroy (GameObject.FindGameObjectWithTag ("ikiyüzelli_2"));



		}


		if (other.gameObject.tag == "beşyüz_2" ) {



			levelCall.coin += 500;

			clist1_2.coinList.Remove (GameObject.Find ("gold13"));

			if(!score){
				score = true;
				Instantiate (throwEffect_good, throwEffect_good.transform.position, throwEffect_good.transform.rotation);
				Instantiate (coinEffect, coinEffect_T [1].transform.position, Quaternion.identity);
			}
			score = false;

			Destroy (GameObject.FindGameObjectWithTag ("beşyüz_2"));
		}

		if (other.gameObject.tag == "beşyüz_2_") {



			levelCall.coin += 500;


			clist1_2.coinList.Remove (GameObject.Find ("gold14"));

			if(!score){
				score = true;
				Instantiate (throwEffect_good, throwEffect_good.transform.position, throwEffect_good.transform.rotation);
				Instantiate (coinEffect, coinEffect_T [2].transform.position, Quaternion.identity);
			}
			score = false;
			Destroy (GameObject.FindGameObjectWithTag ("beşyüz_2_"));



		}

		if (other.gameObject.tag == "bin" ) {



			levelCall.coin += 1000;


			clist1_2.coinList.Remove (GameObject.Find ("gold15"));

			if(!score){
				score = true;
				Instantiate (throwEffect_perfect, throwEffect_perfect.transform.position, throwEffect_perfect.transform.rotation);
				Instantiate (coinEffect2, coinEffect_T [3].transform.position, Quaternion.identity);
			}
			score = false;
			Destroy (GameObject.FindGameObjectWithTag ("bin"));


		}


		if (other.gameObject.tag == "binbeşyüz" ) {



			levelCall.coin += 1500;



			clist1_2.coinList.Remove (GameObject.Find ("gold16"));

			if(!score){
				score = true;
				Instantiate (throwEffect_excelent, throwEffect_excelent.transform.position, throwEffect_excelent.transform.rotation);
				Instantiate (coinEffect2, coinEffect_T [4].transform.position, Quaternion.identity);
			}
			score = false;


			Destroy (GameObject.FindGameObjectWithTag ("binbeşyüz"));

		}

		if (other.gameObject.tag == "ikibin") {



			levelCall.coin += 2000;




			clist1_2.coinList.Remove (GameObject.Find ("gold17"));


			if(!score){
				score = true;
				Instantiate (throwEffect_excelent, throwEffect_excelent.transform.position, throwEffect_excelent.transform.rotation);
				Instantiate (coinEffect2, coinEffect_T [5].transform.position, Quaternion.identity);
			}
			score = false;

			Destroy (GameObject.FindGameObjectWithTag ("ikibin"));


		}
			

		if (other.gameObject.tag == "binreward") {



			levelCall.coin += 1000;




			if(!score){
				score = true;
				Instantiate (throwEffect_awesome, throwEffect_awesome.transform.position, throwEffect_awesome.transform.rotation);
			}
			score = false;
			Destroy (GameObject.FindGameObjectWithTag ("binreward"));



		}



	}

	public void OnCollisionEnter(Collision other){
		
		if (other.gameObject.tag == "trapHolly" ) {

			if (!score) {
				score = true;
				levelCall.coin -= 125;
				Instantiate (trapEffect, transform.position, transform.rotation);
			}

			score = false;
				
		}
			

	}




}
