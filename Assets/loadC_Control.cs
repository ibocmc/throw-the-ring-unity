
//Copyright © 2018 Imece Ajans
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class loadC_Control : MonoBehaviour {

	 Canvas loadC;


	public static loadC_Control instance;

	void Awake(){

		SingletonControl ();

	}

	void Start(){

		loadC = GameObject.FindGameObjectWithTag ("loadc").GetComponent<Canvas> ();

//		loadC.enabled = false;


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

	public void ShowC(){

		loadC.enabled = true;

	}



}
