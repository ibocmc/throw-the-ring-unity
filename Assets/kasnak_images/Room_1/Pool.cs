using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pool : MonoBehaviour {
    public Queue<GameObject> RingQueue = new Queue<GameObject>();
    public GameObject[] Rings;
	public GameObject ring;
    public Vector3 Ins;
	// Use this for initialization
	void Start () {
        InstantObj();
        FillQueue();

	}
	
	// Update is called once per frame
	void Update () {

		//Debug.Log (RingQueue.Count);
		
	}

    void InstantObj()
    {
        Rings = new GameObject[10];
        for (int i = 0; i < Rings.Length;i++ )
        {
            Rings[i] = Instantiate(ring, Ins, Quaternion.identity);
        }
    }

    void FillQueue()
    {
        foreach(GameObject g in Rings)
        {
            RingQueue.Enqueue(g);
        }
    }

    public GameObject NextObject(Vector3 Pos,Quaternion q)
    {
        if (RingQueue.Count > 0)
        {
            GameObject ret = RingQueue.Dequeue();
            ret.transform.position = Pos;
            ret.transform.rotation = q;
            ret.SetActive(true);
            return ret;
        }
        else
        return null;
    }

	public IEnumerator PoolBack(GameObject g)
    {
		yield return new WaitForSeconds (1f);
       	 g.transform.position = Ins;
    	 g.SetActive(false);
       	 RingQueue.Enqueue(g);
    }
}
