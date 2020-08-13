using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pointControl3_1 : MonoBehaviour {


	levelInfo levelCall;

	public GameObject throwEffect_good;
	public GameObject throwEffect_perfect;
	public GameObject throwEffect_excelent;
	public GameObject throwEffect_awesome;

	public GameObject trapEffect;


	public bool score;


	private goldmanage3_1 clist3_1;




	// Use this for initialization
	void Start () {
		levelCall = Camera.main.GetComponent<levelInfo> ();

		clist3_1 = GameObject.FindObjectOfType<goldmanage3_1> ().GetComponent<goldmanage3_1> ();

	
	}


	void OnTriggerEnter(Collider other){

				if (other.gameObject.tag == "binoda3") {
		

					levelCall.coin += 1000;

					Destroy (GameObject.FindGameObjectWithTag ("binoda3"));
					clist3_1.coinList.Remove (GameObject.Find ("gold33"));
		
			if(!score){
				score = true;
					Instantiate (throwEffect_good, throwEffect_good.transform.position,throwEffect_good.transform.rotation);
			}
					
				}
		
				if (other.gameObject.tag == "2binoda3") {

					levelCall.coin += 2000;
		

					Destroy (GameObject.FindGameObjectWithTag ("2binoda3"));
					clist3_1.coinList.Remove (GameObject.Find ("gold34"));
		
			if(!score){
				score = true;
				Instantiate (throwEffect_good, throwEffect_good.transform.position, throwEffect_good.transform.rotation);
			}	
					
				}
				if (other.gameObject.tag == "3binoda3") {
		
		

					levelCall.coin += 3000;

					Destroy (GameObject.FindGameObjectWithTag ("3binoda3"));
					clist3_1.coinList.Remove (GameObject.Find ("gold35"));
		
			if(!score){
				score = true;
				Instantiate (throwEffect_perfect, throwEffect_perfect.transform.position, throwEffect_perfect.transform.rotation);
			}
				
				}
		
		
				if (other.gameObject.tag == "4binoda3") {
		

					levelCall.coin += 4000;
	
		
					Destroy (GameObject.FindGameObjectWithTag ("4binoda3"));
					clist3_1.coinList.Remove (GameObject.Find ("gold36"));
		
			if(!score){
				score = true;
				Instantiate (throwEffect_perfect, throwEffect_perfect.transform.position, throwEffect_perfect.transform.rotation);
			}	
					
				}
				if (other.gameObject.tag == "5binoda3") {
		
		

					levelCall.coin += 5000;

		
					Destroy (GameObject.FindGameObjectWithTag ("5binoda3"));
					clist3_1.coinList.Remove (GameObject.Find ("gold37"));

			if(!score){
				score = true;
					
				Instantiate (throwEffect_excelent, throwEffect_excelent.transform.position, throwEffect_excelent.transform.rotation);
			}
					
				}
				

		if (other.gameObject.tag == "binreward") {


			levelCall.coin += 2500;

			Destroy (GameObject.FindGameObjectWithTag ("binreward"));


			if(!score){
				score = true;
				Instantiate (throwEffect_awesome, throwEffect_awesome.transform.position, throwEffect_awesome.transform.rotation);
			}


		}


	

	}
	

	void OnCollisionEnter(Collision other){



		if (other.gameObject.tag == "trapHolly") {
			
			if(!score){
				
				score = true;
				levelCall.coin -= 750;
				Instantiate (trapEffect, transform.position, transform.rotation);

			}


		}



	}




}
