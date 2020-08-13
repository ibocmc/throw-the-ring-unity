using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class goldmanage3_1 : MonoBehaviour
{

	levelInfo levelCall;
    public List<GameObject> coinList;

   	
	public bool reward;
	public bool trap;

	public GameObject r1Coin;
	public GameObject one_to_two, R_green, T_holly;



	public Vector3 r_spawn_loc2;

	public Vector3 t_spawn_loc2;



	public float thollystartWait;
	public float thollyspawnWait;


	public float rgreenstartWait;
	public float rgreenspawnWait;


	public int reward1Count;
	public int trap1Count;




	public int r1CoinCount;

    void Start()
    {
		levelCall = Camera.main.GetComponent<levelInfo> ();


		coinList = new List<GameObject>();

		StartCoroutine (LaunchReward());

		StartCoroutine (LaunchTrap());

		for(int i=0;i<r1CoinCount;i++)
		{
		 Instantiate(r1Coin,r1Coin.transform.position,Quaternion.identity);
			foreach (GameObject coin in GameObject.FindGameObjectsWithTag("goldcoin7")) {


				coinList.Add (coin);


			}


		}


       
		reward = true;
		trap = true;
		LaunchReward ();

		LaunchTrap ();

    }

    void Update()
      {

	
		if(coinList.Count == 0){
			Destroy (GameObject.Find("coinhold7(Clone)"));
			for(int i=0;i<r1CoinCount;i++)
			{
				 Instantiate(r1Coin,r1Coin.transform.position,Quaternion.identity);
				foreach (GameObject coin in GameObject.FindGameObjectsWithTag("goldcoin7")) {


					coinList.Add (coin);


				}

				if(coinList.Count > 5){
					coinList.RemoveRange(0,5);
				}


			}
		}


	
        }
		


	IEnumerator LaunchReward(){

		yield return new WaitForSeconds(rgreenstartWait);

		while(true)
		{

			for (int i=0; i<reward1Count; i++){


				Vector3 spawnPosition2 = new Vector3(Random.Range(-0.2f,0.7f), r_spawn_loc2.y, Random.Range(0f,-2f));


				if(reward){

					Instantiate(R_green,spawnPosition2,R_green.transform.rotation);

				}


				yield return new WaitForSeconds(rgreenspawnWait);

			}

		}
	}

	IEnumerator LaunchTrap(){

		yield return new WaitForSeconds(thollystartWait);

		while(true)
		{

			for (int i=0; i<trap1Count; i++){


				Vector3 spawnPosition2 = new Vector3(Random.Range(-0.2f,0.7f), t_spawn_loc2.y, Random.Range(0,-2f));



				if(trap){

					Instantiate(T_holly,spawnPosition2,T_holly.transform.rotation);

				}

				yield return new WaitForSeconds(thollyspawnWait);

			}

		}

	}


}
