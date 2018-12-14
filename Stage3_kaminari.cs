using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage3_kaminari : MonoBehaviour {

    public GameObject kaminari;
    public GameObject Blue;

    // Use this for initialization
    void Start()
    {
        kaminari.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        Color_Blue blue = Blue.GetComponent<Color_Blue>();
        if (blue.Color_blue == 1)
        {
        kaminari.gameObject.SetActive(true);
        }
    }


}
