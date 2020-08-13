using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TouchTest : MonoBehaviour {


	public float forceUp;

	public Vector3 forceDir;

	public Rigidbody rb;

	public float power;

	public float rotForce;

	public float forceUpRot;

	public Vector3 T;


	public Slider powerSlider;

	public Image arrowImg;

	private Vector3 startPos;
	private Vector3 endPos;


	public bool canSwipe = true;
	public bool isThrown;




	// Use this for initialization
	void Start () {

	
		rb.useGravity = false;
		powerSlider.value = 0;
		rb.isKinematic = false;
		isThrown = false;
		//rb.transform.Rotate (-30, 0, 0);

		//Time.timeScale = 1.2f;
	}



	
	// Update is called once per frame
	void Update () {

		if(isThrown){
			
			return;
		}

		if(!canSwipe){

			return;
		}





		if(Input.touchCount > 0){



			Touch mytouch = Input.GetTouch(0);


			if(Input.GetTouch(0).phase == TouchPhase.Began){

				//Debug.Log ("touch moved");

				if(canSwipe){
				startPos = mytouch.position;
				startPos.z = transform.position.z - Camera.main.transform.position.z;
				startPos = Camera.main.ScreenToWorldPoint (startPos);
				}


			}

			else if(Input.GetTouch(0).phase == TouchPhase.Moved){

				//	Debug.Log ("touch began");


				if(canSwipe){
					power += forceUp;
					powerSlider.value = power;

					if(power > 100){

						power = 100;

					}

					rotForce += forceUpRot;
					if(rotForce > 60){

						rotForce = 60;
					}
				}

				//				rb.useGravity = true;


			}


			else if (Input.GetTouch (0).phase == TouchPhase.Ended) {
//				
//				Vector3 throwDir = -(startPos - endPos).normalized;
//
//				throwDir.z = throwDir.magnitude;
//
//
//				float force = (startPos - endPos).sqrMagnitude;
//
//
//
//
//				rb.AddForce (throwDir * force * power,ForceMode.Impulse );


				endPos = mytouch.position;
				endPos.z = transform.position.z - Camera.main.transform.position.z;
				endPos = Camera.main.ScreenToWorldPoint (endPos);


				forceDir = endPos - startPos;
				forceDir.Normalize ();
				forceDir.z = forceDir.magnitude;

				forceDir.y = forceDir.magnitude/2f;




				Vector3 x = Vector3.Cross (endPos.normalized, startPos.normalized);
				float theta = Mathf.Asin (x.magnitude);
				Vector3 w = x.normalized * theta / Time.fixedDeltaTime;

				Quaternion q = rb.transform.rotation * rb.inertiaTensorRotation;
				T = q * Vector3.Scale (rb.inertiaTensor, (Quaternion.Inverse (q) * w));




				if (powerSlider.value > 0.01f) {
					rb.useGravity = true;
					rb.isKinematic = false;
					isThrown = true;
					canSwipe = false;
				}

				rb.AddTorque (T * 10, ForceMode.Force);

				rb.AddTorque (rb.transform.up * -rotForce, ForceMode.Force);


				rb.AddForce (forceDir * power * 5f, ForceMode.Force);




			} else {

				isThrown = false;
			}




		}


		
	}


}
