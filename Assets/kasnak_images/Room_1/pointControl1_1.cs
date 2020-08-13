using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pointControl1_1 : MonoBehaviour {

	levelInfo levelCall;

	public GameObject throwEffect_good;
	public GameObject throwEffect_perfect;
	public GameObject throwEffect_excelent;
	public GameObject throwEffect_awesome;

	public GameObject coinEffect;

	public Transform[] coinEffect_T;

	public bool score;

	private goldmanage1_1 clist1_1;

	Pool p;

	public GameObject poolObj;


//	int ListCointCount;
//	string[] allTags = { "elli", "yüz", "yüzelli", "üçyüz", "dörtyüz" };

	 



	// Use this for initialization
	void Start () {

		levelCall = Camera.main.GetComponent<levelInfo> ();
		p = poolObj.GetComponent<Pool>();




		clist1_1 = GameObject.FindObjectOfType<goldmanage1_1> ().GetComponent<goldmanage1_1> ();

//		ListCointCount = clist1_1.coinList.Count;
		score = false;
	}




	void OnTriggerEnter(Collider other){


//		if (System.Array.Exists (allTags, element => element == other.gameObject.tag)) {
//			int index = System.Array.IndexOf (allTags, other.gameObject.tag);
//			if (index < 3) {
//				CCS.currentCoinScore += 50f * (index + 1);
//				TCS.totalCoinScore += 50f * (index + 1);
//			} else {
//				CCS.currentCoinScore += 100f * (index);
//				TCS.totalCoinScore += 100f * (index);
//			}
//			CC_t.currentCoin.text = CCS.currentCoinScore.ToString ();
//			TC_t.totalCoin.text = TC_t.totalCoinScore.ToString ();
//
//
//			Destroy (other.gameObject, 1f);
//			ListCointCount--;
//
//			Instantiate (throwEffect_good, throwEffect_good.transform.position, throwEffect_good.transform.rotation);
//			//Instantiate(throwEffect_good, throwEffect_good.transform.position, throwEffect_good.transform.rotation); // coineffect vector cekerek ekle
//			Destroy (GameObject.FindGameObjectWithTag ("te_ex"), 1f);
//			score = true;
//		}
//
		if (other.gameObject.tag == "elli" ) {

		
			levelCall.coin += 50;

			clist1_1.coinList.Remove (GameObject.Find ("gold1"));
			if(!score){
				score = true;
				Instantiate (throwEffect_good, throwEffect_good.transform.position, throwEffect_good.transform.rotation);
				Instantiate (coinEffect, coinEffect_T [0].transform.position, Quaternion.identity);
			}
			score = false;
			Destroy (GameObject.FindGameObjectWithTag ("elli"));


		}

		if (other.gameObject.tag == "yüz") {


			levelCall.coin += 100;


			Destroy (GameObject.FindGameObjectWithTag ("yüz"));
			clist1_1.coinList.Remove (GameObject.Find ("gold2"));
			if(!score){
				score = true;
				Instantiate (coinEffect, coinEffect_T [1].transform.position, Quaternion.identity);

				Instantiate (throwEffect_good, throwEffect_good.transform.position, throwEffect_good.transform.rotation);
			}
			score = false;



		}

		if (other.gameObject.tag == "yüzelli") {

			levelCall.coin += 150;

			Destroy (GameObject.FindGameObjectWithTag ("yüzelli"));
			clist1_1.coinList.Remove (GameObject.Find ("gold3"));
			if(!score){
				score = true;
				Instantiate (coinEffect, coinEffect_T [2].transform.position, Quaternion.identity);
				Instantiate (throwEffect_good, throwEffect_good.transform.position, throwEffect_good.transform.rotation);
			}
			score = false;



		}

		if (other.gameObject.tag == "yüzelli_") {


			levelCall.coin += 150;


			Destroy (GameObject.FindGameObjectWithTag ("yüzelli_"));
			clist1_1.coinList.Remove (GameObject.Find ("gold4"));
			if(!score){
				score = true;
				Instantiate (coinEffect, coinEffect_T [3].transform.position, Quaternion.identity);
				Instantiate (throwEffect_good, throwEffect_good.transform.position, throwEffect_good.transform.rotation);
			}
			score = false;
		
		
			}
			


		if (other.gameObject.tag == "üçyüz") {


			levelCall.coin += 300;


			clist1_1.coinList.Remove (GameObject.Find ("gold5"));
			if(!score){
				score = true;
				Instantiate (coinEffect, coinEffect_T [4].transform.position, Quaternion.identity);
				Instantiate (throwEffect_perfect, throwEffect_perfect.transform.position, throwEffect_perfect.transform.rotation);
			}
			score = false;
		

			Destroy (GameObject.FindGameObjectWithTag ("üçyüz"));

		}
		if (other.gameObject.tag == "dörtyüz" ) {


			levelCall.coin += 400;


			clist1_1.coinList.Remove (GameObject.Find ("gold6"));

			if(!score){
				score = true;
				Instantiate (throwEffect_perfect, throwEffect_perfect.transform.position, throwEffect_perfect.transform.rotation);
				Instantiate (coinEffect, coinEffect_T [5].transform.position, Quaternion.identity);
			}
			score = false;
			Destroy (GameObject.FindGameObjectWithTag ("dörtyüz"));


		}

		if (other.gameObject.tag == "dörtyüz_" ) {


			levelCall.coin += 400;



			clist1_1.coinList.Remove (GameObject.Find ("gold7"));
			if(!score){
				score = true;
				Instantiate (coinEffect, coinEffect_T [6].transform.position, Quaternion.identity);
				Instantiate (throwEffect_perfect, throwEffect_perfect.transform.position, throwEffect_perfect.transform.rotation);
			}
			score = false;

			Destroy (GameObject.FindGameObjectWithTag ("dörtyüz_"));



		}

		if (other.gameObject.tag == "beşyüz" ) {

			levelCall.coin+= 500;


		
			clist1_1.coinList.Remove (GameObject.Find ("gold8"));
			if(!score){
				score = true;
				Instantiate (coinEffect, coinEffect_T [7].transform.position, Quaternion.identity);
				Instantiate (throwEffect_excelent, throwEffect_excelent.transform.position, throwEffect_excelent.transform.rotation);
			}
			score = false;
			Destroy (GameObject.FindGameObjectWithTag ("beşyüz"));
		

		}

		if (other.gameObject.tag == "beşyüz_") {



			levelCall.coin += 500;



			clist1_1.coinList.Remove (GameObject.Find ("gold9"));
			if(!score){
				score = true;
				Instantiate (coinEffect, coinEffect_T [8].transform.position, Quaternion.identity);
				Instantiate (throwEffect_excelent, throwEffect_excelent.transform.position, throwEffect_excelent.transform.rotation);
			}
			score = false;

			Destroy (GameObject.FindGameObjectWithTag ("beşyüz_"));


		}

		if (other.gameObject.tag == "altıyüz") {

			levelCall.coin += 600;


			clist1_1.coinList.Remove (GameObject.Find ("gold10"));
			if(!score){
				score = true;
				Instantiate (coinEffect, coinEffect_T [9].transform.position, Quaternion.identity);
		
				Instantiate (throwEffect_excelent, throwEffect_excelent.transform.position, throwEffect_excelent.transform.rotation);
			}
			score = false;
			Destroy (GameObject.FindGameObjectWithTag ("altıyüz"));



		}

		if (other.gameObject.tag == "altıyüz_") {



			levelCall.coin += 600;


			clist1_1.coinList.Remove (GameObject.Find ("gold11"));
			if(!score){
				score = true;
				Instantiate (coinEffect, coinEffect_T [10].transform.position, Quaternion.identity);
				Instantiate (throwEffect_excelent, throwEffect_excelent.transform.position, throwEffect_excelent.transform.rotation);
			}
			score = false;

			Destroy (GameObject.FindGameObjectWithTag ("altıyüz_"));



		}

	


	}
		
	
	
}
