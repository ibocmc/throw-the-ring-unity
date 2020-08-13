using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover2 : MonoBehaviour {

//	public Vector3 rotd1_1;
//	public Vector3 rotd1_2;


//	public Vector3 rotd6_1;
//	public Vector3 rotd6_2;





	public float speed = 1.0f;
	public GameObject d1;
	public Vector3 posd1_1;
	public Vector3 posd1_2;


	public GameObject d2;
	public Vector3 posd2_1;
	public Vector3 posd2_2;

	public GameObject d3;
	public Vector3 posd3_1;
	public Vector3 posd3_2;

	public GameObject d4;
	public Vector3 posd4_1;
	public Vector3 posd4_2;

	public GameObject d5;
	public Vector3 posd5_1;
	public Vector3 posd5_2;

//	public GameObject d6;
//	public Vector3 posd6_1;
//	public Vector3 posd6_2;
//
//	public GameObject d7;
//	public Vector3 posd7_1;
//	public Vector3 posd7_2;


	// Use this for initialization
	void Start () {
		


	}





	
	// Update is called once per frame
	void Update () {



		d1.gameObject.transform.position= Vector3.Lerp (posd1_1, posd1_2, Mathf.PingPong(Time.time*speed, 1.0f));
		//d1.transform.Rotate(Vector3.Lerp (rotd1_1,rotd1_2,Mathf.PingPong(Time.time*speed,1.0f)));

		d2.transform.position = Vector3.Lerp (posd2_1, posd2_2, Mathf.PingPong(Time.time*speed, 1.0f));
		//d2.transform.Rotate(Vector3.Lerp (rotd1_1,rotd1_2,Mathf.PingPong(Time.time*speed,1.0f)));

		d3.transform.position = Vector3.Lerp (posd3_1, posd3_2, Mathf.PingPong(Time.time*speed, 1.0f));
		//d3.transform.Rotate(Vector3.Lerp (rotd1_1,rotd1_2,Mathf.PingPong(Time.time*speed,1.0f)));

		d4.transform.position = Vector3.Lerp (posd4_1, posd4_2, Mathf.PingPong(Time.time*speed, 1.0f));
		//d4.transform.Rotate(Vector3.Lerp (rotd1_1,rotd1_2,Mathf.PingPong(Time.time*speed,1.0f)));

		d5.transform.position = Vector3.Lerp (posd5_1, posd5_2, Mathf.PingPong(Time.time*speed, 1.0f));
		//d5.transform.Rotate(Vector3.Lerp (rotd1_1,rotd1_2,Mathf.PingPong(Time.time*speed,1.0f)));

//		d6.transform.position = Vector3.Lerp (posd6_1, posd6_2, Mathf.PingPong(Time.time*0.75f, 1.0f));
//		d6.transform.Rotate(Vector3.Lerp (rotd6_1,rotd6_2,Mathf.PingPong(Time.time*speed,1.0f)));
//
//		d7.transform.position = Vector3.Lerp (posd7_1, posd7_2, Mathf.PingPong(Time.time*0.75f, 1.0f));
//		d7.transform.Rotate(Vector3.Lerp (rotd6_1,rotd6_2,Mathf.PingPong(Time.time*speed,1.0f)));
	}
}



 
