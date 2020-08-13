using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BellowEdge3_3 : MonoBehaviour {


    Pool p;
	GameObject kasnak;
    // Use this for initialization
    void Start()
    {
        kasnak = GameObject.Find("kasnak_for_hold3_3");
        p = kasnak.GetComponent<Pool>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.activeInHierarchy && transform.position.y <= 1)
            StartCoroutine(p.PoolBack(gameObject));
    }
}
