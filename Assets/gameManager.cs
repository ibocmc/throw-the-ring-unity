using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour {


	public Canvas gameover;
	public Text currentS;
	public Text totalS;

	public Text overTime;
	public Text overScore;

	private LevelControl2 current_s;
	private LevelControl2 total_s;
	private LevelControl2 c_time;


	// Use this for initialization
	void Start () {

		gameover = GetComponent<Canvas> ();
		gameover.enabled = false;

		current_s = GameObject.FindObjectOfType<LevelControl2> ().GetComponent<LevelControl2> ();
		total_s = GameObject.FindObjectOfType<LevelControl2> ().GetComponent<LevelControl2> ();
		c_time = GameObject.FindObjectOfType<LevelControl2> ().GetComponent<LevelControl2> ();
		
	}
	

}
