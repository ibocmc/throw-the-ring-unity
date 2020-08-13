using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class goldmanage2_1 : MonoBehaviour
{


    public List<GameObject> coinList;
	levelInfo levelCall;

		public bool rewards;
		public bool trap;


    public GameObject r1Coin;

	public GameObject one_to_two, R_pandora, T_monster;



	public Vector3 r_spawn_loc2;

	public Vector3 t_spawn_loc2;

	public float pandoraspawnWait;
	public float pandorastartWait;


	public float monsterspawnWait;
	public float monsterstartWait;


	public int reward1Count;
	public int trap1Count;



	public int r1CoinCount;

    void Start()
    {
		levelCall = Camera.main.GetComponent<levelInfo> ();
		StartCoroutine (LaunchReward());
		StartCoroutine (LaunchTrap());


        coinList = new List<GameObject>();

	
       
        for(int i=0;i<r1CoinCount;i++)
        {
			Instantiate(r1Coin,r1Coin.transform.position,Quaternion.identity);
			foreach (GameObject coin in GameObject.FindGameObjectsWithTag("goldcoin4")) {


				coinList.Add (coin);


			}


        }
		rewards = true;
		trap = true;
		LaunchReward ();
		LaunchTrap ();

    }

    void Update()
      {
		
	
		if(coinList.Count == 0){
			Destroy (GameObject.Find("coinhold4(Clone)"));
		for(int i=0;i<r1CoinCount;i++)
		{
			 Instantiate(r1Coin,r1Coin.transform.position,Quaternion.identity);
			foreach (GameObject coin in GameObject.FindGameObjectsWithTag("goldcoin4")) {


				coinList.Add (coin);


			}

				if(coinList.Count > 5){
					coinList.RemoveRange(0,5);
				}


		}
		}


        }
		


	IEnumerator LaunchReward(){

		yield return new WaitForSeconds(pandorastartWait);

		while(true)
		{

			for (int i=0; i<reward1Count; i++){


				Vector3 spawnPosition2 = new Vector3(Random.Range(0.6f,-0.6f), r_spawn_loc2.y, Random.Range(0.75f,0.2f));



				if(rewards){

					Instantiate(R_pandora,spawnPosition2,R_pandora.transform.rotation);

				}


				yield return new WaitForSeconds(pandoraspawnWait);

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
