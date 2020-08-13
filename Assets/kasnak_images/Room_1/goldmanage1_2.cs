using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class goldmanage1_2 : MonoBehaviour
{
	
	levelInfo levelCall;
    public List<GameObject> coinList;

	public Text tcoins;

	public bool rewards;

	public bool rewards_oda2;
    public GameObject r2Coin;

	public GameObject one_to_two, r_green, t_holly;


	public Vector3 r_spawn_loc;

	public Vector3 t_spawn_loc;


	public float r_greenspawnWait;
	public float r_greenstartWait;

	public float t_hollyspawnWait;
	public float t_hollystartWait;

	public int reward1Count;
	public int trap1Count;




	public int r2CoinCount;

	public  void Start()
    {
		levelCall = Camera.main.GetComponent<levelInfo> ();

		StartCoroutine (LaunchReward());
		StartCoroutine (LaunchTrap());


        coinList = new List<GameObject>();

	
       
        for(int i=0;i<r2CoinCount;i++)
        {
			Instantiate(r2Coin,r2Coin.transform.position,Quaternion.identity);
			foreach (GameObject coin in GameObject.FindGameObjectsWithTag("goldcoin2")) {


				coinList.Add (coin);


			}


        }
		rewards = true;
		LaunchReward ();
		LaunchTrap ();

    }

    void Update()
      {

	
		if(coinList.Count == 0 ){

			Destroy (GameObject.Find("coinhold_2(Clone)"));
		for(int i=0;i<r2CoinCount;i++)
		{
			Instantiate(r2Coin,r2Coin.transform.position,Quaternion.identity);
			foreach (GameObject coin in GameObject.FindGameObjectsWithTag("goldcoin2")) {


				coinList.Add (coin);


			}
				if(coinList.Count > 6){
					coinList.RemoveRange(0,6);
				}

		}
		}


        }
		


	IEnumerator LaunchReward(){

		yield return new WaitForSeconds(r_greenstartWait);

		while(true)
		{

			for (int i=0; i<reward1Count; i++){

				Vector3 spawnPosition = new Vector3(Random.Range(0.3f,-0.3f), r_spawn_loc.y, Random.Range(-1.5f,0.2f));




				if(rewards){

					Instantiate(r_green,spawnPosition,r_green.transform.rotation);

				}



				yield return new WaitForSeconds(r_greenspawnWait);

			}

		}

	}

	IEnumerator LaunchTrap(){

		yield return new WaitForSeconds(t_hollystartWait);

		while(true)
		{

			for (int i=0; i<trap1Count; i++){

				Vector3 spawnPosition = new Vector3(Random.Range(0.6f,-0.6f), t_spawn_loc.y, Random.Range(0.7f,-2f));



				if(rewards){

					Instantiate(t_holly,spawnPosition,t_holly.transform.rotation);

				}


				yield return new WaitForSeconds(t_hollyspawnWait);

			}

		}

	}

}
