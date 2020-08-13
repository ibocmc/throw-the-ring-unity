using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panOpen : MonoBehaviour {



	public Animator pandoraAnim;
//	public ParticleSystem pan1,pan2;


//	public ParticleSystem chest_eng,chest_eng_2;

	// Use this for initialization
	void Start () {

//		chest_eng = GetComponent<ParticleSystem> ();

//		pan1 = GetComponent<ParticleSystem> ();
//		pan2 = GetComponent<ParticleSystem> ();
		pandoraAnim.enabled = false;

	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnCollisionEnter(Collision other){

		if(other.gameObject.tag == "zemin"){
			pandoraAnim.enabled = true;
			pandoraAnim.Play ("bang");
			gameObject.GetComponent<Rigidbody> ().isKinematic = true;


		}
//		if(other.gameObject.tag == "ikibinoda2"){
//			
//			gameObject.GetComponent<Rigidbody> ().isKinematic = true;
//
//
//		}


	}
}
