using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class goldmanage1_1 : MonoBehaviour
{

	levelInfo levelCall;


    public List<GameObject> coinList;

	public GameObject r1Coin;



	public int r1CoinCount;

    void Start()
    {
		levelCall = Camera.main.GetComponent<levelInfo> ();

        coinList = new List<GameObject>();

	
        for(int i=0;i<r1CoinCount;i++)
        {
			Instantiate(r1Coin,r1Coin.transform.position,Quaternion.identity);
			foreach (GameObject coin in GameObject.FindGameObjectsWithTag("goldcoin")) {


				coinList.Add (coin);


			}


        }
			

    }


  
    void Update()
      {

	
		if(coinList.Count == 0 ){

			Destroy (GameObject.Find("coinhold(Clone)"));
		
			for(int i=0;i<r1CoinCount;i++)
		{
				
			Instantiate(r1Coin,r1Coin.transform.position,Quaternion.identity);
			
				foreach (GameObject coin in GameObject.FindGameObjectsWithTag("goldcoin")) {


					coinList.Add (coin);

			}


		}
			if(coinList.Count > 10){
				
				coinList.RemoveRange(0,10);
			}


		}
	
        }


}