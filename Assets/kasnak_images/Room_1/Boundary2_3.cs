using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundary2_3 : MonoBehaviour {



	public GameObject lightEffect1;
	public bool score;


	// Use this for initialization



	void OnTriggerEnter(Collider other){

	

	
		if(other.gameObject.tag == "halkapre"){

			if(!score){
				score = true;
				Instantiate (lightEffect1,transform.position,transform.rotation);


			}
			score = false;
	}

	

	}



//	void OnCollisionEnter(Collision other){
//
//
//
//		//yield return new WaitForSeconds (2);
//
//		if(other.gameObject.tag == "halkapre"){
//
//			//other.GetComponent<LevelControl> ().ResetPosition ();
////			R_Body.rb.transform.position = InitialPos.InitialPosition;
////			R_Body.rb.transform.rotation = Quaternion.identity;
////
////			R_Body.rb.useGravity = false;
////			R_Body.rb.isKinematic = true;
////			R_Body.rb.velocity = Vector3.zero;
////
////			touchSystem.canSwipe = true;
////			pwrsldr.power = 0;
////			pwrsldr.powerSlider.value = 0;
////			rotOpt.rotForce = 0;
////
////			thrownsys.isThrown = false;
////
////			pwrsldr.power = 0;
////			pwrsldr.powerSlider.value = 0;
////			rotOpt.rotForce = 0;
//			//Destroy(other.gameObject,1);
//
//	}
//	}


}
