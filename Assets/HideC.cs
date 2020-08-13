using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HideC : MonoBehaviour {

	Canvas loadC;

	// Use this for initialization
	void Start () {

		loadC = GameObject.FindGameObjectWithTag ("loadc").GetComponent<Canvas> ();

		loadC.enabled = false;


		
	}
	

}
