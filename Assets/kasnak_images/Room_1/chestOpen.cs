using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chestOpen : MonoBehaviour {


	public Animator chestAnim;




//	public ParticleSystem chest_eng,chest_eng_2;

	// Use this for initialization
	void Start () {

//		chest_eng = GetComponent<ParticleSystem> ();

//		pan1 = GetComponent<ParticleSystem> ();
//		pan2 = GetComponent<ParticleSystem> ();


	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnCollisionEnter(Collision other){

		if(other.gameObject.tag == "zemin"){
			
			gameObject.GetComponent<Rigidbody> ().isKinematic = true;

			chestAnim.Play ("open");



		}

	}
}
