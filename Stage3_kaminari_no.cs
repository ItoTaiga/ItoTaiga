using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage3_kaminari_no : MonoBehaviour {

    public GameObject kaminari;
    public GameObject Yellow;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Color_Yellow yellow = Yellow.GetComponent<Color_Yellow>();
        if (yellow.Color_yellow == 1)
        {
            kaminari.gameObject.SetActive(false);
        }

    }
}
