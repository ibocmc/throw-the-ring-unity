//Copyright © 2018 Imece Ajans
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MainMenuController : MonoBehaviour {

	public static MainMenuController instance;

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
