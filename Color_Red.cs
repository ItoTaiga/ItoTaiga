﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Color_Red : MonoBehaviour
{

    public int Color_red;
    public GameObject nashi;
    public GameObject ari;
    public GameObject nashi2;
    public GameObject ari2;

    // Use this for initialization
    void Start()
    {
    
    }


    // Update is called once per frame
    void Update()
    {
        if (Color_red == 0)
        {
            ari.gameObject.SetActive(false);
            nashi.gameObject.SetActive(true);
            ari2.gameObject.SetActive(false);
            nashi2.gameObject.SetActive(true);
        }
        else
        {
            ari.gameObject.SetActive(true);
            nashi.gameObject.SetActive(false);
            ari2.gameObject.SetActive(true);
            nashi2.gameObject.SetActive(false);
        }

    }
    public void Test()
    {
 //       //Debug.Log("red");
    }


}
