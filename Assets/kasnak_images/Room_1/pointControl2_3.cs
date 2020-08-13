using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pointControl2_3 : MonoBehaviour {

	levelInfo levelCall;



	public GameObject throwEffect_good;
	public GameObject throwEffect_perfect;
	public GameObject throwEffect_excelent;
	public GameObject throwEffect_awesome;

	public GameObject trapEffect;
	public GameObject trapEffect2;


	public bool score;

	// Use this for initialization
	void Start () {
		levelCall = Camera.main.GetComponent<levelInfo> ();


		score = false;
	}

	void OnTriggerEnter(Collider other){


				

		if (other.gameObject.tag == "binreward") {



			levelCall.coin += 1000;


			Destroy (GameObject.FindGameObjectWithTag ("binreward"));


			if(!score){
				score = true;
				Instantiate (throwEffect_awesome, throwEffect_awesome.transform.position, throwEffect_awesome.transform.rotation);

			}


		}

		if (other.gameObject.tag == "beşbin") {


			levelCall.coin += 5000;

			Destroy (GameObject.FindGameObjectWithTag ("beşbin"));


			if(!score){
				score = true;
				Instantiate (throwEffect_awesome, throwEffect_awesome.transform.position, throwEffect_awesome.transform.rotation);

			}


		}


	}
	

	void OnCollisionEnter(Collision other){



		if (other.gameObject.tag == "fireball") {


			if(!score){
				
				score = true;
				levelCall.coin -= 500;
				Instantiate (trapEffect2, transform.position, transform.rotation);


			}


		}



	}





}
