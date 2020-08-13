using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionController : MonoBehaviour {

	public static OptionController instance;

	void Awake(){

		SingletonControl ();
	}

	public void SingletonControl()
	{
		if(instance == null){

			DontDestroyOnLoad (this);
			instance = this;

		}
		else{

			Destroy (this.gameObject);
		}
	}
}
