using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundary2_2 : MonoBehaviour {



	public GameObject diamondEffect1;
	public bool score;

	void OnTriggerEnter(Collider other){
	
		if(other.gameObject.tag == "halkapre"){

			if(!score){
				score = true;
				Instantiate (diamondEffect1,transform.position,transform.rotation);
			}

			score = false;

	}
			

	}
		



}
