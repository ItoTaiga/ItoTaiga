using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage2_Ice_Ture : MonoBehaviour {
    public GameObject Ice;
    public GameObject Red;
    bool One;

	// Use this for initialization
	void Start () {
        One = true;
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        Color_Red red = Red.GetComponent<Color_Red>();
        Color_Blue blue = Ice.GetComponent<Color_Blue>();
        //一回だけ処理をする
        if (One)
        {
            if (red.Color_red == 1)
            {
                blue.Color_blue = 1;
                One = false;
            }
        }

    }
}
