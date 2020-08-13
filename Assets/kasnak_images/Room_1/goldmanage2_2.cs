using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class goldmanage2_2 : MonoBehaviour
{


    public List<GameObject> coinList;
	levelInfo levelCall;

	public bool reward;
	public bool trap;


    public GameObject r2Coin;

	public GameObject one_to_two,R_enegy, T_monster;



	public Vector3 r_spawn_loc2;

	public Vector3 t_spawn_loc2;

	public float energystartWait;

	public float energyspawnWait;


	public float monsterspawnWait;
	public float monsterstartWait;


	public int reward1Count;
	public int trap1Count;



	public int r2CoinCount;

    void Start()
    {
		levelCall = Camera.main.GetComponent<levelInfo> ();

		StartCoroutine (LaunchReward());
		StartCoroutine (LaunchTrap());


        coinList = new List<GameObject>();

	
       
        for(int i=0;i<r2CoinCount;i++)
        {
			 Instantiate(r2Coin,r2Coin.transform.position,Quaternion.identity);
			foreach (GameObject coin in GameObject.FindGameObjectsWithTag("goldcoin5")) {


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

	
		if(coinList.Count == 0 ){
			Destroy (GameObject.Find("coinhold5(Clone)"));
		for(int i=0;i<r2CoinCount;i++)
		{
			 Instantiate(r2Coin,r2Coin.transform.position,Quaternion.identity);
			foreach (GameObject coin in GameObject.FindGameObjectsWithTag("goldcoin5")) {


				coinList.Add (coin);


			}

				if(coinList.Count > 5){
					coinList.RemoveRange(0,5);
				}


		}
		}


        }
		


	IEnumerator LaunchReward(){

		yield return new WaitForSeconds(energystartWait);

		while(true)
		{

			for (int i=0; i<reward1Count; i++){


				Vector3 spawnPosition2 = new Vector3(Random.Range(0.6f,-0.6f), r_spawn_loc2.y, Random.Range(0.75f,0.2f));



				if(reward){

					Instantiate(R_enegy,spawnPosition2,R_enegy.transform.rotation);

				}


				yield return new WaitForSeconds(energyspawnWait);

			}

		}
	}


		IEnumerator LaunchTrap(){

			yield return new WaitForSeconds(monsterstartWait);

			while(true)
			{

				for (int i=0; i<trap1Count; i++){


					Vector3 spawnPosition2 = new Vector3(Random.Range(1f,-1f), t_spawn_loc2.y, Random.Range(-2f,2f));

					

					if(trap){

						Instantiate(T_monster,spawnPosition2,T_monster.transform.rotation);

					}

					yield return new WaitForSeconds(monsterspawnWait);

				}
				
			}

		}


}
