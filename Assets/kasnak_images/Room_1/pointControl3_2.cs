using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pointControl3_2 : MonoBehaviour {

	levelInfo levelCall;


	public GameObject throwEffect_good;
	public GameObject throwEffect_perfect;
	public GameObject throwEffect_excelent;
	public GameObject throwEffect_awesome;

	public GameObject trapEffect;
	public GameObject trapEffect2;


	public bool score;

	private goldmanage3_2 clist3_2;

	void Start () {
		levelCall = Camera.main.GetComponent<levelInfo> ();

		clist3_2 = GameObject.FindObjectOfType<goldmanage3_2> ().GetComponent<goldmanage3_2> ();



	}


	void OnTriggerEnter(Collider other){

		if (other.gameObject.tag == "2binoda3_1") {
			
			

			levelCall.coin += 2000;

			
						Destroy (GameObject.FindGameObjectWithTag ("2binoda3_1"));
						clist3_2.coinList.Remove (GameObject.Find ("gold38"));
			
						if(!score){
							score = true;
							Instantiate (throwEffect_good,throwEffect_good.transform.position, throwEffect_good.transform.rotation);
							
						}
						
						
					}
			
		if (other.gameObject.tag == "3binoda3_1") {
			
			

						levelCall.coin += 3000;

						Destroy (GameObject.FindGameObjectWithTag ("3binoda3_1"));
						clist3_2.coinList.Remove (GameObject.Find ("gold39"));
			
						if(!score){
							score = true;
							Instantiate (throwEffect_good,throwEffect_good.transform.position, throwEffect_good.transform.rotation);
							
						}
						
					}
					if (other.gameObject.tag == "4binoda3_1") {
			
			

						levelCall.coin += 4000;

			
						Destroy (GameObject.FindGameObjectWithTag ("4binoda3_1"));
						clist3_2.coinList.Remove (GameObject.Find ("gold40"));
			
						if(!score){
							score = true;
							Instantiate (throwEffect_good,throwEffect_good.transform.position, throwEffect_good.transform.rotation);
							
						}
						
					}
			
			
					if (other.gameObject.tag == "5binoda3_1") {
			
			

						levelCall.coin += 5000;

			
						Destroy (GameObject.FindGameObjectWithTag ("5binoda3_1"));
						clist3_2.coinList.Remove (GameObject.Find ("gold41"));
			
						if(!score){
							score = true;
							Instantiate (throwEffect_perfect,throwEffect_perfect.transform.position, throwEffect_perfect.transform.rotation);
							
						}
						
						
					}
			
					if (other.gameObject.tag == "6binoda3_1") {
			
			

						levelCall.coin += 6000;

						Destroy (GameObject.FindGameObjectWithTag ("6binoda3_1"));
						clist3_2.coinList.Remove (GameObject.Find ("gold42"));
			
						if(!score){
							
							score = true;
							Instantiate (throwEffect_perfect,throwEffect_perfect.transform.position, throwEffect_perfect.transform.rotation);
							
						}
						
					}
					if (other.gameObject.tag == "10binoda3_1") {
			
			

					levelCall.coin += 10000;

						Destroy (GameObject.FindGameObjectWithTag ("10binoda3_1"));
						clist3_2.coinList.Remove (GameObject.Find ("gold43"));
			
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

		if (other.gameObject.tag == "lava") {


			if(!score){
				
				score = true;
				levelCall.coin -= 750;
				Instantiate (trapEffect2, transform.position, transform.rotation);


			}

		}



	}


}
