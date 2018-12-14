using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage3_nizi : MonoBehaviour {
    public GameObject Red;
    public GameObject Blue;
    public GameObject Yellow;
    public GameObject nizi;

	// Use this for initialization
	void Start () {
        nizi.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        Color_Red red = Red.GetComponent<Color_Red>();
        Color_Blue blue = Blue.GetComponent<Color_Blue>();
        Color_Yellow yellow = Yellow.GetComponent<Color_Yellow>();
        if(red.Color_red==1 && blue.Color_blue ==1 && yellow.Color_yellow == 1)
        {
            nizi.gameObject.SetActive(true);
        }
        else
        {
            nizi.gameObject.SetActive(false);
        }

    }
}
