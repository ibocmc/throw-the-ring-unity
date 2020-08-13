using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pointControl2_2 : MonoBehaviour {


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

	private goldmanage2_2 clist2_2;




	// Use this for initialization
	void Start () {

		levelCall = Camera.main.GetComponent<levelInfo> ();


		clist2_2 = GameObject.FindObjectOfType<goldmanage2_2> ().GetComponent<goldmanage2_2> ();

	}

	void OnTriggerEnter(Collider other){


				if (other.gameObject.tag == "beşbinoda2_2.1") {
		
		

					levelCall.coin += 5000;

					Destroy (GameObject.FindGameObjectWithTag ("beşbinoda2_2.1"));
					clist2_2.coinList.Remove (GameObject.Find ("gold28"));
		
					if (!score) {
						score = true;
						Instantiate (throwEffect_excelent,throwEffect_excelent.transform.position, throwEffect_excelent.transform.rotation);
						Instantiate (coinEffect, coinEffect_T[0].transform.position, Quaternion.identity);
						
					}
					
		
		
				}
		
				if (other.gameObject.tag == "beşbinoda2_2.2") {
		
		

					levelCall.coin += 5000;

		
					Destroy (GameObject.FindGameObjectWithTag ("beşbinoda2_2.2"));
					clist2_2.coinList.Remove (GameObject.Find ("gold29"));
		
					if (!score) {
						score = true;
						Instantiate (throwEffect_excelent,throwEffect_excelent.transform.position, throwEffect_excelent.transform.rotation);
						Instantiate (coinEffect, coinEffect_T[1].transform.position, Quaternion.identity);
						
					}
					
		
				}
				if (other.gameObject.tag == "beşbinoda2_2.3") {
		
		

					levelCall.coin += 5000;
		
		

					Destroy (GameObject.FindGameObjectWithTag ("beşbinoda2_2.3"));
					clist2_2.coinList.Remove (GameObject.Find ("gold30"));
		
					if (!score) {
						score = true;
						Instantiate (throwEffect_excelent,throwEffect_excelent.transform.position, throwEffect_excelent.transform.rotation);
						Instantiate (coinEffect, coinEffect_T[1].transform.position, Quaternion.identity);
						
					}
					
		
		
				}
		
				if (other.gameObject.tag == "beşbinoda2_2.4") {
		
		

					levelCall.coin += 5000;

		
					Destroy (GameObject.FindGameObjectWithTag ("beşbinoda2_2.4"));
					clist2_2.coinList.Remove (GameObject.Find ("gold31"));
		
					if (!score) {
						score = true;
						Instantiate (throwEffect_excelent,throwEffect_excelent.transform.position, throwEffect_excelent.transform.rotation);
						Instantiate (coinEffect, coinEffect_T[2].transform.position, Quaternion.identity);
						
					}
					
		
		
				}
				if (other.gameObject.tag == "beşbinoda2_2.5") {
		
		

					levelCall.coin += 5000;

					Destroy (GameObject.FindGameObjectWithTag ("beşbinoda2_2.5"));
					clist2_2.coinList.Remove (GameObject.Find ("gold32"));
		
					if (!score) {
						score = true;
						Instantiate (throwEffect_excelent,throwEffect_excelent.transform.position, throwEffect_excelent.transform.rotation);
						Instantiate (coinEffect, coinEffect_T[3].transform.position, Quaternion.identity);
						
					}
					
		
				}
					


		if (other.gameObject.tag == "binreward") {



			levelCall.coin += 1000;


			Destroy (GameObject.FindGameObjectWithTag ("binreward"));


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
				levelCall.coin -= 250;
				Instantiate (trapEffect2, transform.position, transform.rotation);


			}


		}


	}






}
