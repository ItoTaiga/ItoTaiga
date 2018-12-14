using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kiscript : MonoBehaviour {
    public int Ki_count;
    public GameObject Brown;
    public GameObject Ki2;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Color_Brown brown = Brown.GetComponent<Color_Brown>();
        Kianima anima = Ki2.GetComponent<Kianima>();
        if (Ki_count > 1) Ki_count = 1;
        if (brown.Color_brown == 0)
        {
            Ki_count++;
        }

        if (Ki_count == 0)
        {
            anima.Ki();

        }
        else if(Ki_count ==1)
        {
            anima.Ki2();
        }


    }
}
