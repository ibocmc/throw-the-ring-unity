using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class room1Sound : MonoBehaviour {

	public AudioSource r1Sound;
	public Slider Room_sound;


	// Use this for initialization
	void Start () {


		r1Sound.Play ();
		
	}

	public void Volume(){

		r1Sound.volume = Room_sound.value;

	}




}
