using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage3_hare : MonoBehaviour {

    public GameObject sora;
    public GameObject Yellow;
    public GameObject Red;

    // Use this for initialization
    void Start()
    {
        sora.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        Color_Yellow yellow = Yellow.GetComponent<Color_Yellow>();
        Color_Red red = Red.GetComponent<Color_Red>();
        if (yellow.Color_yellow == 1 && red.Color_red ==1)
        {
            sora.gameObject.SetActive(true);
        }

    }
}
