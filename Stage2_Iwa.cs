using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage2_Iwa : MonoBehaviour {
    public GameObject Iwa_Coll;
    public GameObject Red;
    public GameObject Blue;
    public int kaeru;
    bool One;

    // Use this for initialization
    void Start () {
        One = true;
        Iwa_Coll.gameObject.SetActive(true);

    }
	
	// Update is called once per frame
	void Update () {
        Color_Red red = Red.GetComponent<Color_Red>();
        Color_Blue blue = Blue.GetComponent<Color_Blue>();
        if (One)
        {
            if (red.Color_red == 1)
            {
                kaeru++;
                One = false;
            }
        }

        if(kaeru==1 && blue.Color_blue == 1)
        {
            Iwa_Coll.gameObject.SetActive(false);
        }
	}
}
