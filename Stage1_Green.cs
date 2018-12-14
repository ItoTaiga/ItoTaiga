using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage1_Green : MonoBehaviour {

    public GameObject Ha;
    public GameObject Green;
    public int Green_Color;
    bool One;

    // Use this for initialization
    void Start()
    {
        One = true;
        Green.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        Color_Green green = Ha.GetComponent<Color_Green>();
        if (One)
        {
            if (green.Color_green == 0)
            {
                Green_Color++;
                One = false;
            }
        }

        if (green.Color_green == 1 && Green_Color==1)
        {
            Green.gameObject.SetActive(true);
        }
        else
        {
            Green.gameObject.SetActive(false);
        }

    }
}
