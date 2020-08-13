using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundaryOda3Item : MonoBehaviour {




	public GameObject diamondEffect1;
	public bool score;



	// Use this for initialization
	void Start () {

	}


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
