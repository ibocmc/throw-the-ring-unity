using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class goldmanage3_3: MonoBehaviour
{

	levelInfo levelCall;

    public List<GameObject> coinList;

	public GameObject r3Coin;

	public bool reward;
	public bool trap;


	public GameObject R_green,T_holly,T_skull,R_Pandora; 


	public Vector3 r_spawn_loc;
	public Vector3 r_spawn_loc2;

	public Vector3 t_spawn_loc;


	public float skullstartWait;
	public float skullspawnWait;

	public float thollystartWait;
	public float thollyspawnWait;


	public float rgreenstartWait;
	public float rgreenspawnWait;

	public float pandorastartWait;
	public float pandoraspawnWait;

	public int reward1Count;
	public int trap1Count;
	public int reward2Count;
	public int trap2Count;

    public int r3CoinCount;

    void Start()
    {

		levelCall = Camera.main.GetComponent<levelInfo> ();

		coinList = new List<GameObject>();

		StartCoroutine (LaunchReward());
		StartCoroutine (LaunchReward2());

		StartCoroutine (LaunchTrap2());
		StartCoroutine (LaunchTrap());

		for(int i=0;i<r3CoinCount;i++)
		{
			 Instantiate(r3Coin,r3Coin.transform.position,Quaternion.identity);
			foreach (GameObject coin in GameObject.FindGameObjectsWithTag("goldcoin9")) {


				coinList.Add (coin);


			}


		}


       
		reward = true;
		trap = true;
		LaunchReward ();
		LaunchReward2 ();

		LaunchTrap2 ();
		LaunchTrap ();

    }

    void Update()
      {

	
		if(coinList.Count == 0 ){

			Destroy (GameObject.Find("coinhold9(Clone)"));
			for(int i=0;i<r3CoinCount;i++)
			{
				Instantiate(r3Coin,r3Coin.transform.position,Quaternion.identity);
				foreach (GameObject coin in GameObject.FindGameObjectsWithTag("goldcoin9")) {


					coinList.Add (coin);


				}

				if(coinList.Count > 7){
					coinList.RemoveRange(0,7);
				}


			}
		}



        }
		


	IEnumerator LaunchReward(){

		yield return new WaitForSeconds(rgreenstartWait);

		while(true)
		{

			for (int i=0; i<reward1Count; i++){


				Vector3 spawnPosition2 = new Vector3(Random.Range(-0.2f,0.5f), r_spawn_loc.y, Random.Range(0f,-2f));


				if(reward){

					Instantiate(R_green,spawnPosition2,R_green.transform.rotation);

				}


				yield return new WaitForSeconds(rgreenspawnWait);

			}

		}
	}
	IEnumerator LaunchReward2(){

		yield return new WaitForSeconds(pandorastartWait);

		while(true)
		{

			for (int i=0; i<reward1Count; i++){


				Vector3 spawnPosition2 = new Vector3(Random.Range(-0.2f,0.5f), r_spawn_loc2.y, Random.Range(0f,-2f));



				if(reward){

					Instantiate(R_Pandora,spawnPosition2,R_Pandora.transform.rotation);

				}


				yield return new WaitForSeconds(pandoraspawnWait);

			}

		}
	}
	IEnumerator LaunchTrap(){

		yield return new WaitForSeconds(thollystartWait);

		while(true)
		{

			for (int i=0; i<trap1Count; i++){


				Vector3 spawnPosition2 = new Vector3(Random.Range(-0.2f,0.5f), t_spawn_loc.y, Random.Range(0f,-2f));



				if(trap){

					Instantiate(T_holly,spawnPosition2,T_holly.transform.rotation);

				}
			
				yield return new WaitForSeconds(thollyspawnWait);

			}

		}

	}


	IEnumerator LaunchTrap2(){

		yield return new WaitForSeconds(skullstartWait);

		while(true)
		{

			for (int i=0; i<trap2Count; i++){

				Vector3 spawnPosition = new Vector3(Random.Range(-0.2f,0.5f), t_spawn_loc.y, Random.Range(0f,-2f));


				if(trap){

					Instantiate(T_skull,spawnPosition,T_skull.transform.rotation);

				}

				yield return new WaitForSeconds(skullspawnWait);

			}

		}

	}



}
