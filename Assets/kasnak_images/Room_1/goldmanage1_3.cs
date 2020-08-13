using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class goldmanage1_3 : MonoBehaviour
{

	levelInfo levelCall;

    public List<GameObject> coinList;

    public GameObject r3Coin;

	public GameObject  t_ice;

	public Vector3 r_spawn_loc;

	public Vector3 t_spawn_loc;


	public float t2_icestartWait;
	public float t2_icespawnWait;


	public int trap1Count;

	public bool trap;

	public int r3CoinCount;



    void Start()
    {
		levelCall = Camera.main.GetComponent<levelInfo> ();



		StartCoroutine (LaunchTrap2());

        coinList = new List<GameObject>();

       
        for(int i=0;i<r3CoinCount;i++)
        {
			Instantiate(r3Coin,r3Coin.transform.position,Quaternion.identity);
				foreach (GameObject coin in GameObject.FindGameObjectsWithTag("goldcoin3")) {


				coinList.Add (coin);


			}


        }

		trap = true;
		LaunchTrap2 ();

    }

  
    void Update()
      {

	
		if(coinList.Count == 0 ){

			Destroy (GameObject.Find("coinhold_3(Clone)"));
		for(int i=0;i<r3CoinCount;i++)
		{
			Instantiate(r3Coin,r3Coin.transform.position,Quaternion.identity);
			foreach (GameObject coin in GameObject.FindGameObjectsWithTag("goldcoin3")) {


				coinList.Add (coin);


			}
				if(coinList.Count > 3){
					coinList.RemoveRange(0,3);
				}


			}
		}



        }
		

	IEnumerator LaunchTrap2(){

		yield return new WaitForSeconds(t2_icestartWait);

		while(true)
		{

			for (int i=0; i<trap1Count; i++){

				Vector3 spawnPosition = new Vector3(t_spawn_loc.x, t_spawn_loc.y, Random.Range(-1f,-2f));


				if(trap){

					Instantiate(t_ice,spawnPosition,t_ice.transform.rotation);

				}

				yield return new WaitForSeconds(t2_icespawnWait);

			}

		}

	}

}
