using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage3_tobira : MonoBehaviour {
    public GameObject tobira;
    public GameObject Yellow;
    public GameObject Blue;
    public GameObject Red;

    // Use this for initialization
    void Start()
    {
        tobira.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Color_Yellow yellow = Yellow.GetComponent<Color_Yellow>();
        Color_Blue blue = Blue.GetComponent<Color_Blue>();
        Color_Red red = Red.GetComponent<Color_Red>();
        if (yellow.Color_yellow == 1 && blue.Color_blue == 1 && red.Color_red ==1)
        {
            tobira.gameObject.SetActive(true);
        }

    }
}
