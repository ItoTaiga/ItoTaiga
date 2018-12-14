using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Color_Brown : MonoBehaviour {
    public int Color_brown;
    public GameObject nashi;
    public GameObject ari;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Color_brown == 0)
        {
            ari.gameObject.SetActive(false);
            nashi.gameObject.SetActive(true);
        }
        else
        {
            ari.gameObject.SetActive(true);
            nashi.gameObject.SetActive(false);
        }

    }
    public void Test()
    {
//        //Debug.Log("brown");
    }
}
