using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Color_Green : MonoBehaviour {
    public int Color_green = 1;
    public GameObject nashi;
    public GameObject ari;
    public GameObject ki;
    public GameObject mi;
    public GameObject ha;


    // Use this for initialization
    void Start()
    {

       ki.gameObject.SetActive(false);
       mi.gameObject.SetActive(false);
       ha.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (Color_green == 0)
        {
            ari.gameObject.SetActive(false);
            nashi.gameObject.SetActive(true);
        }
        else
        {
            ari.gameObject.SetActive(true);
            nashi.gameObject.SetActive(false);
            ki.gameObject.SetActive(true);
            mi.gameObject.SetActive(true);
            ha.gameObject.SetActive(true);
        }

    }
    public void Test()
    {
 //       //Debug.Log("irokae");
    }
}
