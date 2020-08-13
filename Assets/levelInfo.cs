//Copyright © 2018 Imece Ajans
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelInfo : MonoBehaviour {



	public int coin = 3000;
	public float time;
	public int Control_coin;

	public GameObject levelUPeffect;

	public Canvas room_inC;
	public Canvas gameOverC;
	public Canvas L_UpC;
	public Text Losetext,scoretext,scoreT_GO;

	public bool control = true;

	// Use this for initialization
	void Start () {

		game_Manager.instance.Load ();
		coin = game_Manager.instance.coin;
		Debug.Log ("we"+coin);

	}
	
	// Update is called once per frame
	void Update () {
		if (control) {

			if (coin <= 0) {
				coin = 0;
				Lose ("lose");


			}

			if (time <= 0) {

				gameOverC.enabled = false;
				L_UpC.enabled = false;
				room_inC.enabled = false;

				if (coin < Control_coin) {

					Lose ("time is up!");
				} else {

					Win ();
				}
				control = false;
			}

		}
	}
	void Lose(string text){
		int levelind = game_Manager.instance.enableMaxlevel;
		int gem = game_Manager.instance.gem;

		if(coin <= 0 ){
			
		game_Manager.instance.Save (gem,coin + 1000 ,levelind);
		
		} else
			game_Manager.instance.Save (gem,coin,levelind);

		Time.timeScale = Time.timeScale == 0 ? 1 : 0;
		control = false;
		Losetext.text = text;
		gameOverC.enabled = true;
		scoreT_GO.text = coin.ToString ();

	}

	void Win(){

		int levelind = game_Manager.instance.enableMaxlevel;
		int gem = game_Manager.instance.gem;
		game_Manager.instance.Save (gem,coin,levelind);
		StartCoroutine (WinWait());
		control = false;



	}

	IEnumerator WinWait(){

		GameObject g = Instantiate (levelUPeffect,levelUPeffect.transform.position,levelUPeffect.transform.rotation);
		yield return new WaitForSeconds (2);
		Destroy (g);

		scoretext.text = coin.ToString ();
		L_UpC.enabled = true;
		Time.timeScale = Time.timeScale == 0 ? 1 : 0;
	}

}
