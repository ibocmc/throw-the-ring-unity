using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class goldmanage2_3 : MonoBehaviour
{

	public bool reward;
	public bool trap;


	public GameObject questComplete,R_pandora,T_monster,R_enegy,R_green;


	public Vector3 r_spawn_loc;
	public Vector3 r_spawn_loc2;
	public Vector3 r_spawn_loc3;
	public Vector3 t_spawn_loc2;

	public float energystartWait;

	public float energyspawnWait;

	public float pandoraspawnWait;
	public float pandorastartWait;


	public float monsterspawnWait;
	public float monsterstartWait;

	public float rgreenstartWait;

	public float rgreenspawnWait;


	public int reward1Count;
	public int trap1Count;



    public int r3CoinCount;

    void Start()
    {

		StartCoroutine (LaunchReward());
		StartCoroutine (LaunchReward2());
		StartCoroutine (LaunchReward3());
		StartCoroutine (LaunchTrap());



       
		reward = true;
		trap = true;
		LaunchReward ();
		LaunchReward2 ();
		LaunchReward3 ();
		LaunchTrap ();

    }



	IEnumerator LaunchReward(){

		yield return new WaitForSeconds(energystartWait);

		while(true)
		{

			for (int i=0; i<reward1Count; i++){


				Vector3 spawnPosition2 = new Vector3(Random.Range(0.5f,-0.5f), r_spawn_loc.y, Random.Range(0.6f,-2f));

				if(reward){

					Instantiate(R_enegy,spawnPosition2,R_enegy.transform.rotation);

				}


				yield return new WaitForSeconds(energyspawnWait);

			}

		}
	}
	IEnumerator LaunchReward2(){

		yield return new WaitForSeconds(pandorastartWait);

		while(true)
		{

			for (int i=0; i<reward1Count; i++){


				Vector3 spawnPosition2 = new Vector3(Random.Range(0.5f,-0.5f), r_spawn_loc2.y, Random.Range(0.6f,-2f));



				if(reward){

					Instantiate(R_pandora,spawnPosition2,R_pandora.transform.rotation);

				}


				yield return new WaitForSeconds(pandoraspawnWait);

			}

		}
	}
	IEnumerator LaunchReward3(){

		yield return new WaitForSeconds(rgreenstartWait);

		while(true)
		{

			for (int i=0; i<reward1Count; i++){


				Vector3 spawnPosition2 = new Vector3(Random.Range(0.5f,-0.5f), r_spawn_loc3.y, Random.Range(0.75f,-2f));



				if(reward){

					Instantiate(R_green,spawnPosition2,R_green.transform.rotation);

				}


				yield return new WaitForSeconds(rgreenspawnWait);

			}

		}
	}


		IEnumerator LaunchTrap(){

			yield return new WaitForSeconds(monsterstartWait);

			while(true)
			{

				for (int i=0; i<trap1Count; i++){


					Vector3 spawnPosition2 = new Vector3(Random.Range(0.8f,-0.5f), t_spawn_loc2.y, Random.Range(-1f,-2f));

					if(trap){

						Instantiate(T_monster,spawnPosition2,T_monster.transform.rotation);

					}

					yield return new WaitForSeconds(monsterspawnWait);

				}
				
			}

		}


}
