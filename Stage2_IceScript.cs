using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage2_IceScript : MonoBehaviour {
    public GameObject Ice;
    public int Ice_Count=1;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Ice_Count == 0)
        {
            Ice.gameObject.SetActive(false);
        }
        else
        {
            Ice.gameObject.SetActive(true);
        }

    }
}
