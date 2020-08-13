using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pointControl3_3 : MonoBehaviour {


	levelInfo levelCall;

	public GameObject throwEffect_good;
	public GameObject throwEffect_perfect;
	public GameObject throwEffect_excelent;
	public GameObject throwEffect_awesome;

	public GameObject trapEffect;
	public GameObject trapEffect2;


	public bool score;


	private goldmanage3_3 clist3_3;

	// Use this for initialization
	void Start () {
		levelCall = Camera.main.GetComponent<levelInfo> ();


		clist3_3 = GameObject.FindObjectOfType<goldmanage3_3> ().GetComponent<goldmanage3_3> ();

	}



	void OnTriggerEnter(Collider other){

				if (other.gameObject.tag == "2binoda3_2") {
		
		

			levelCall.coin += 2000;
		

		
					Destroy (GameObject.FindGameObjectWithTag ("2binoda3_2"));
					clist3_3.coinList.Remove (GameObject.Find ("gold44"));
		
					if(!score){
						score = true;
						Instantiate (throwEffect_good, throwEffect_good.transform.position, throwEffect_good.transform.rotation);
						
					}
					
				}
				if (other.gameObject.tag == "4binoda3_2") {
		
		

					levelCall.coin += 4000;
		

					Destroy (GameObject.FindGameObjectWithTag ("4binoda3_2"));
					clist3_3.coinList.Remove (GameObject.Find ("gold45"));
		
					if(!score){
						score = true;
						Instantiate (throwEffect_good, throwEffect_good.transform.position, throwEffect_good.transform.rotation);
						
					}
					
				}
				if (other.gameObject.tag == "6binoda3_2") {
		
		

					levelCall.coin += 6000;
		

					Destroy (GameObject.FindGameObjectWithTag ("6binoda3_2"));
					clist3_3.coinList.Remove (GameObject.Find ("gold46"));
		
					if(!score){
						score = true;
						Instantiate (throwEffect_perfect, throwEffect_perfect.transform.position, throwEffect_perfect.transform.rotation);
						
					}
					
				}
		
				if (other.gameObject.tag == "8binoda3_2") {

					levelCall.coin += 8000;
		

					Destroy (GameObject.FindGameObjectWithTag ("8binoda3_2"));
					clist3_3.coinList.Remove (GameObject.Find ("gold47"));
		
					if(!score){
						score = true;
						Instantiate (throwEffect_perfect, throwEffect_perfect.transform.position, throwEffect_perfect.transform.rotation);
						
					}
					Destroy (GameObject.FindGameObjectWithTag ("te_ex"), 1f);
					//ResetPosition ();
				}
		
				if (other.gameObject.tag == "10binoda3_2") {
		
		

					levelCall.coin += 10000;
		

					Destroy (GameObject.FindGameObjectWithTag ("10binoda3_2"));
					clist3_3.coinList.Remove (GameObject.Find ("gold48"));
		
					if(!score){
						score = true;
						Instantiate (throwEffect_perfect, throwEffect_perfect.transform.position, throwEffect_perfect.transform.rotation);
						
					}
					
				}
				if (other.gameObject.tag == "15binoda3_2_1") {

					levelCall.coin += 15000;

					Destroy (GameObject.FindGameObjectWithTag ("15binoda3_2_1"));
					clist3_3.coinList.Remove (GameObject.Find ("gold49"));
		
					if(!score){
						score = true;
						Instantiate (throwEffect_excelent, throwEffect_excelent.transform.position, throwEffect_excelent.transform.rotation);
						
					}
					
				}
		
				if (other.gameObject.tag == "15binoda3_2_2") {
		
		
					levelCall.coin += 15000;

		
					Destroy (GameObject.FindGameObjectWithTag ("15binoda3_2_2"));
					clist3_3.coinList.Remove (GameObject.Find ("gold50"));
		
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
			Destroy (GameObject.FindGameObjectWithTag ("te_ex"), 1f);

		}





	}
	

	void OnCollisionEnter(Collision other){



		if (other.gameObject.tag == "lava") {
			

			if(!score){
				levelCall.coin -= 1500;
				score = true;
				Instantiate (trapEffect, transform.position, transform.rotation);



			}


		}

		if (other.gameObject.tag == "trapHolly") {


			if(!score){
				
				score = true;
				levelCall.coin -= 1500;
				Instantiate (trapEffect, transform.position, transform.rotation);

			}


		}



	}


}
