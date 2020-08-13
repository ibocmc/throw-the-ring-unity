using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UnlockController : MonoBehaviour {


	public AudioSource payment;
	public AudioSource payment_denied;
	public static UnlockController instance;

	public CanvasGroup lockC;
	public Text coinB;
	public Text gemB;
	Canvas roomC;
	int[] gemseries = { 5, 10, 15, 20, 25, 30, 35, 40 };
	int[] coinseries = { 20000, 100000,250000, 500000, 1000000, 2000000, 20000000, 500000000 };

	public Button [] buttons;
	public Button[] UnlockB;
	int getlevelindex;

	// Use this for initialization

	void Awake(){
//		Time.timeScale = Time.timeScale == 0 ? 1 : 0;
		SingletonControl ();
	}

	public void SingletonControl()
	{
		if(instance == null){

			DontDestroyOnLoad (this);
			instance = this;

		}
		else{

			Destroy (this.gameObject);
		}
	}
	void Start () {
		if(lockC.alpha == 1){

			Time.timeScale = Time.timeScale == 0 ? 1 : 0;

		}

		LevelStartControl ();
	}
	


	public void UnlockLevel(int levelindex){
		

		game_Manager.instance.Load ();
		int maxlevel = game_Manager.instance.enableMaxlevel;

		Debug.Log (maxlevel+" "+(levelindex-1).ToString());
		if(maxlevel == levelindex-1){
			Debug.Log ("test");
			coinB.text = "      " + coinseries[levelindex - 2]+" coin";

			gemB.text = "Use " + gemseries[levelindex - 2] + " gem";
			roomC = GameObject.FindGameObjectWithTag ("roomcanvas").GetComponent<Canvas> ();
			roomC.enabled = false;
			lockC.alpha = 1;
			lockC.blocksRaycasts = true;
			lockC.interactable = true;
			getlevelindex = levelindex;
		}

	}

	public void Cancel(){
		lockC.alpha = 0;
		lockC.blocksRaycasts = false;
		lockC.interactable = false;
		roomC.enabled = true;
	}

	public void AcceptUnlockedLevelWithCoin(){
		
		int mycoin = game_Manager.instance.coin;
		if (coinseries [getlevelindex - 2] < mycoin) {
			int coin = game_Manager.instance.coin;
			int gem = game_Manager.instance.gem;

			coin = coin - coinseries [getlevelindex - 2];
			payment.Play ();
			game_Manager.instance.Save (gem, coin, getlevelindex);
			UnlockB [getlevelindex - 2].gameObject.SetActive (false);
			buttons [getlevelindex - 2].interactable = true;
			lockC.alpha = 0;
			lockC.blocksRaycasts = false;
			lockC.interactable = false;
			roomC.enabled = true;
		} else
			payment_denied.Play ();
			



	}

	void LevelStartControl(){

		game_Manager.instance.Load ();
		int maxlevel = game_Manager.instance.enableMaxlevel;
		for(int i = 0; i < maxlevel-1; i++ ){

			UnlockB [i].gameObject.SetActive (false);
			buttons [i].interactable = true;

		}

	}

}
