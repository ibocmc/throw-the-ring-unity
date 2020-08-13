//Copyright © 2018 Imece Ajans
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.UI;

public class game_Manager : MonoBehaviour {

	public static game_Manager instance;

	public int coin = 3000;
	public int gem;



	public Text coinText;


	public int enableMaxlevel=1;

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

	// Use this for initialization
	void Start () {
		
		Load ();

		coinText.text = coin.ToString ();
	}
	
	// Update is called once per frame
	void Update () {

		Load ();
		coinText.text = coin.ToString ();
		
	}

	public void Save(int _gem , int _coin , int _levelind)
	{
		Debug.Log ("save"+Application.persistentDataPath );

		BinaryFormatter bf = new BinaryFormatter ();
		FileStream file = File.Create (Application.persistentDataPath + "/levelInfo.dat");

		DataClass data = new DataClass ();
		data.gem = _gem;
		data.enableMaxlevel = _levelind;
		data.coin = _coin;

		bf.Serialize (file,data);
		file.Close();
	}


	public void Load(){

		if(File.Exists(Application.persistentDataPath + "/levelInfo.dat")){

			BinaryFormatter bf = new BinaryFormatter ();
			FileStream file = File.Open (Application.persistentDataPath + "/levelInfo.dat", FileMode.Open);

			DataClass data = (DataClass)bf.Deserialize (file);
			file.Close ();



			enableMaxlevel = data.enableMaxlevel;
			gem = data.gem;
			coin = data.coin;
			coinText.text = coin.ToString ();


		}


	}
}



[System.Serializable]
public class DataClass{

	public int gem;
	public int enableMaxlevel;
	public int coin;

}