using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unlockRoomCanvas : MonoBehaviour {

	public static unlockRoomCanvas instance;

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
