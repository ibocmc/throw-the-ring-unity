using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pointControl1_3 : MonoBehaviour {

	levelInfo levelCall;
	public GameObject throwEffect_excelent;
	public GameObject throwEffect_awesome;

	public GameObject trapEffect;

	public bool score;

	public Transform[] coinEffect_T;

	public GameObject coinEffect;


	private goldmanage1_3 clist1_3;




	// Use this for initialization
	void Start () {
		levelCall = Camera.main.GetComponent<levelInfo> ();
		clist1_3 = GameObject.FindObjectOfType<goldmanage1_3> ().GetComponent<goldmanage1_3> ();
		score = false;
	}

	void OnTriggerEnter(Collider other){


		if (other.gameObject.tag == "ikibinbeşyüz" ) {
			
			levelCall.coin += 2500;

			Destroy (GameObject.FindGameObjectWithTag ("ikibinbeşyüz"));
			clist1_3.coinList.Remove (GameObject.Find ("gold18"));

			if(!score){
				score = true;
				Instantiate (throwEffect_excelent, throwEffect_excelent.transform.position, throwEffect_excelent.transform.rotation);
				Instantiate (coinEffect, coinEffect_T [0].transform.position, Quaternion.identity);
			}
			score = false;

			Destroy (GameObject.FindGameObjectWithTag ("te_ex"));


		}

		if (other.gameObject.tag == "ikibinbeşyüz_") {



			levelCall.coin += 2500;


			Destroy (GameObject.FindGameObjectWithTag ("ikibinbeşyüz_"));
			clist1_3.coinList.Remove (GameObject.Find ("gold19"));

			if(!score){
				score = true;
				Instantiate (throwEffect_excelent, throwEffect_excelent.transform.position, throwEffect_excelent.transform.rotation);
				Instantiate (coinEffect, coinEffect_T [1].transform.position, Quaternion.identity);
			}
			score = false;
		
			Destroy (GameObject.FindGameObjectWithTag ("te_ex"));


		}
		if (other.gameObject.tag == "beşbin") {



			levelCall.coin += 5000;



			Destroy (GameObject.FindGameObjectWithTag ("beşbin"));
			clist1_3.coinList.Remove (GameObject.Find ("gold20"));

			if(!score){
				score = true;
				Instantiate (throwEffect_excelent, throwEffect_excelent.transform.position, throwEffect_excelent.transform.rotation);
				Instantiate (coinEffect, coinEffect_T [2].transform.position, Quaternion.identity);	
			}
			score = false;


			Destroy (GameObject.FindGameObjectWithTag ("te_ex"), 1f);
			score = true;

		}
			


		if (other.gameObject.tag == "binreward" ) {

			levelCall.coin += 1000;


			Destroy (GameObject.FindGameObjectWithTag ("binreward"));

			if(!score){
				score = true;
				Instantiate (throwEffect_awesome, throwEffect_awesome.transform.position, throwEffect_awesome.transform.rotation);
			}
			score = false;

			Destroy (GameObject.FindGameObjectWithTag ("te_ex"), 1f);



		}
			
	}
	

	void OnCollisionEnter(Collision other){

		if(other.gameObject.tag == "trapice"){


			if (!score) {
				
				score = true;
				levelCall.coin -= 150;
				Instantiate (trapEffect, transform.position, transform.rotation);

			}
			score = false;
		


			}
			

		}



	}


	

	
	

