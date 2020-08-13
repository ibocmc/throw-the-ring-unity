using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pointControl2_1 : MonoBehaviour {


	levelInfo levelCall;

	public GameObject throwEffect_good;
	public GameObject throwEffect_perfect;
	public GameObject throwEffect_excelent;
	public GameObject throwEffect_awesome;

	public GameObject trapEffect;
	public GameObject trapEffect2;


	public GameObject coinEffect;

	public Transform[] coinEffect_T;



	public bool score;

	private goldmanage2_1 clist2_1;




	// Use this for initialization
	void Start () {
		levelCall = Camera.main.GetComponent<levelInfo> ();




		clist2_1 = GameObject.FindObjectOfType<goldmanage2_1> ().GetComponent<goldmanage2_1> ();
		score = false;
	}


	void OnTriggerEnter(Collider other){


				if (other.gameObject.tag == "ikibinoda2.1") {

					levelCall.coin += 2000;

					Destroy (GameObject.FindGameObjectWithTag ("ikibinoda2.1"));
					clist2_1.coinList.Remove (GameObject.Find ("gold21"));
		
					if(!score){
						score = true;
						Instantiate (throwEffect_excelent,throwEffect_excelent.transform.position, throwEffect_excelent.transform.rotation);
						Instantiate (coinEffect, coinEffect_T[0].transform.position, Quaternion.identity);
						
					}
					
		
		
				}
				if (other.gameObject.tag == "ikibinoda2.2") {
		
		

			levelCall.coin += 2000;
		

		
					Destroy (GameObject.FindGameObjectWithTag ("ikibinoda2.2"));
					clist2_1.coinList.Remove (GameObject.Find ("gold22"));
		
					if(!score){
						score = true;
						Instantiate (throwEffect_excelent,throwEffect_excelent.transform.position, throwEffect_excelent.transform.rotation);
						Instantiate (coinEffect, coinEffect_T[1].transform.position, Quaternion.identity);
						
					}
					
		
		
				}
				if (other.gameObject.tag == "ikibinoda2.3") {
		
		

					levelCall.coin += 2000;
		

					Destroy (GameObject.FindGameObjectWithTag ("ikibinoda2.3"));
					clist2_1.coinList.Remove (GameObject.Find ("gold23"));
		
					if(!score){
						score = true;
						Instantiate (throwEffect_excelent,throwEffect_excelent.transform.position, throwEffect_excelent.transform.rotation);
						Instantiate (coinEffect, coinEffect_T[2].transform.position, Quaternion.identity);
						
					}
					Destroy (GameObject.FindGameObjectWithTag ("te_ex"), 1f);
		
		
				}
		
				if (other.gameObject.tag == "ikibinoda2.4") {

					levelCall.coin += 2000;
		

		
					Destroy (GameObject.FindGameObjectWithTag ("ikibinoda2.4"));
					clist2_1.coinList.Remove (GameObject.Find ("gold26"));
		
					if(!score){
						score = true;
						Instantiate (throwEffect_excelent,throwEffect_excelent.transform.position, throwEffect_excelent.transform.rotation);
						Instantiate (coinEffect, coinEffect_T[3].transform.position, Quaternion.identity);
						
					}
					Destroy (GameObject.FindGameObjectWithTag ("te_ex"), 1f);
		
		
				}
		
				if (other.gameObject.tag == "ikibinoda2.5") {
		
		

					levelCall.coin += 2000;
		

		
					Destroy (GameObject.FindGameObjectWithTag ("ikibinoda2.5"));
					clist2_1.coinList.Remove (GameObject.Find ("gold27"));
		
					if(!score){
						score = true;
						Instantiate (throwEffect_excelent,throwEffect_excelent.transform.position, throwEffect_excelent.transform.rotation);
						Instantiate (coinEffect, coinEffect_T[4].transform.position, Quaternion.identity);
						
					}
					
		
		
				}
		
			


		if (other.gameObject.tag == "binreward") {



			levelCall.coin += 1000;

			Destroy (GameObject.FindGameObjectWithTag ("binreward"));


			if(!score){
				Instantiate (throwEffect_awesome, throwEffect_awesome.transform.position, throwEffect_awesome.transform.rotation);
				score = true;
			}


		}


	}
	

	void OnCollisionEnter(Collision other){



		if (other.gameObject.tag == "fireball") {


			if(!score){
				score = true;
				Instantiate (trapEffect2, transform.position, transform.rotation);
				levelCall.coin -= 225;

			}


		}

		if (other.gameObject.tag == "trapHolly") {




			if(!score){
				
				score = true;
				levelCall.coin -= 225;
				Instantiate (trapEffect, transform.position, transform.rotation);


			}
				

		}


	}


		
}
