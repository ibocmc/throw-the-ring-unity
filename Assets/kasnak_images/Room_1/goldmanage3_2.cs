using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class goldmanage3_2: MonoBehaviour
{

    public List<GameObject> coinList;

	public bool reward;
	public bool trap;
	levelInfo levelCall;
	public GameObject r2Coin;
	public GameObject one_to_two,R_pandora,T_skull; 


	public Vector3 r_spawn_loc;

	public Vector3 t_spawn_loc;


	public float skullstartWait;
	public float skullspawnWait;

	public float pandorastartWait;
	public float pandoraspawnWait;


	public int reward1Count;
	public int trap1Count;

	public int  r2CoinCount;

    void Start()
    {
		levelCall = Camera.main.GetComponent<levelInfo> ();


		coinList = new List<GameObject>();


		StartCoroutine (LaunchReward2());

		StartCoroutine (LaunchTrap2());

		for(int i=0;i<r2CoinCount;i++)
		{
			 Instantiate(r2Coin,r2Coin.transform.position,Quaternion.identity);
			foreach (GameObject coin in GameObject.FindGameObjectsWithTag("goldcoin8")) {


				coinList.Add (coin);


			}


		}
			
       
		reward = true;
		trap = true;

		LaunchReward2 ();

		LaunchTrap2 ();

    }

    void Update()
      {

	
		if(coinList.Count == 0 ){
			Destroy (GameObject.Find("coinhold8(Clone)"));
			for(int i=0;i<r2CoinCount;i++)
			{
				Instantiate(r2Coin,r2Coin.transform.position,Quaternion.identity);
				foreach (GameObject coin in GameObject.FindGameObjectsWithTag("goldcoin8")) {


					coinList.Add (coin);


				}
				if(coinList.Count > 6){
					coinList.RemoveRange(0,6);
				}


			}
		}


			

        }
		



	IEnumerator LaunchReward2(){

		yield return new WaitForSeconds(pandorastartWait);

		while(true)
		{

			for (int i=0; i<reward1Count; i++){

				Vector3 spawnPosition = new Vector3(Random.Range(0.6f,0.6f), r_spawn_loc.y, Random.Range(0f,0f));




				if(reward){

					Instantiate(R_pandora,spawnPosition,R_pandora.transform.rotation);

				}


				yield return new WaitForSeconds(pandoraspawnWait);

			}

		}
	}



	IEnumerator LaunchTrap2(){

		yield return new WaitForSeconds(skullstartWait);

		while(true)
		{

			for (int i=0; i<trap1Count; i++){

				Vector3 spawnPosition = new Vector3(Random.Range(-0.2f,0.7f), t_spawn_loc.y, Random.Range(0f,-2f));


				if(trap){

					Instantiate(T_skull,spawnPosition,T_skull.transform.rotation);

				}

				yield return new WaitForSeconds(skullspawnWait);

			}

		}

	}



}
