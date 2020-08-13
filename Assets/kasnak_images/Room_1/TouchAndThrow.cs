using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;




public class TouchAndThrow : MonoBehaviour
{
	
	public bool isSpawned = false;
	public bool isThrown = false;

	//private float dragDistance;  //minimum distance for a swipe to be registered




	private Vector3 startPos;
	private Vector3 endPos;

	public Vector3 T;
	public Rigidbody rb;

	public float power;

	public float rotForce;

	public float forceUp;

	public float forceUpRot;

	public Slider powerSlider;

	public Transform spos;

	public float startTime;
	public float endTime;



	Pool p;


	public Vector3 actualForce;
	levelInfo levelcall;


	void Start()
	{
		levelcall = Camera.main.GetComponent<levelInfo> ();
		p = GetComponent<Pool>();

		//dragDistance = Screen.height * 20 / 100; //dragDistance is 15% height of the screen
	
		powerSlider.value = 0;
	}

	public void Reset(){


		SceneManager.LoadScene (0);
		Time.timeScale = Time.timeScale == 0 ? 1 : 1;
	}
	public void Reset2(){


		SceneManager.LoadScene (1);
		Time.timeScale = Time.timeScale == 0 ? 1 : 1;
	}

	public void Reset3(){


		SceneManager.LoadScene (2);
		Time.timeScale = Time.timeScale == 0 ? 1 : 1;
	}



	void Update()
	{
		if (Input.touchCount > 0 && levelcall.control ) // user is touching the screen with a single touch
		{


			Touch mytouch = Input.GetTouch(0);



			if (mytouch.phase == TouchPhase.Began) //check for the first touch
			{
				
				startTime = Time.time;
				startPos = mytouch.position;
				startPos.z = transform.position.z - Camera.main.transform.position.z;
				startPos = Camera.main.ScreenToWorldPoint (startPos);



			}
			else if (mytouch.phase == TouchPhase.Moved) // update the last position based on where they moved
			{
				

					power += forceUp;
//					float timediff = endTime - startTime;

					powerSlider.value = power;

					if(power > 100){

						power = 100;

					}

			}
			else if (mytouch.phase == TouchPhase.Ended) //check if the finger is removed from the screen
			{
				
				endTime = Time.time;
				endPos = mytouch.position;
				endPos.z = transform.position.z - Camera.main.transform.position.z;
				endPos = Camera.main.ScreenToWorldPoint (endPos);



				if(powerSlider.value > 0.01f){

					SpawnObject();

					isThrown = true;

					if(isThrown){
						endPos = new Vector3 (0,0,0);
						startPos = new Vector3 (0,0,0);
						actualForce = new Vector3 (0,0,0);
						startTime = 0;
						endTime = 0;
						powerSlider.value = 0;
						power = 0;
						//rotForce = 0;
				}
					isSpawned = true;
					

				}


			}
		}
	}
	void SpawnObject()
	{
		if (isSpawned == true)
		{
			
			float timediff = endTime - startTime;


			Vector3 force = endPos - startPos;

			actualForce = new Vector3 (force.x, force.y / 1.5f , force.y) * 100.0F / timediff ;

			GameObject g = p.NextObject (spos.position, Quaternion.identity);

			g.GetComponent<Rigidbody>().AddForce (actualForce, ForceMode.Force);
			Debug.Log (endPos + " " + startPos);






//			Vector3 x = Vector3.Cross (endPos.normalized, startPos.normalized);
//			float theta = Mathf.Asin (x.magnitude);
//			Vector3 w = x.normalized * theta / Time.fixedDeltaTime;
//
//			Quaternion q = rb.transform.rotation * rb.inertiaTensorRotation;
//			T = q * Vector3.Scale (rb.inertiaTensor, (Quaternion.Inverse (q) * w));
//
//
//
//			g.GetComponent<Rigidbody>().AddTorque (T, ForceMode.Force);
//			
			g.GetComponent<Rigidbody>().AddTorque (rb.transform.up * -50f, ForceMode.Force);
			

			return;


		}
	}
}