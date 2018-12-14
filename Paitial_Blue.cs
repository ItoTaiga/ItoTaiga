using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paitial_Blue : MonoBehaviour {

    GameObject hit = null;
    public GameObject Pa;
    //public GameObject Blue;

    // Use this for initialization
    void Start()
    {

        Pa.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerStay2D(Collider2D other)
    {
        hit = other.gameObject;
        Color_Blue blue = GetComponent<Color_Blue>();
        Player_Color player = hit.GetComponent<Player_Color>();
        if (hit.gameObject.CompareTag("Player"))
        { 
//            //Debug.Log("Stay : " + other.gameObject.name);
            if (blue.Color_blue == 1 && player.Color_Count_Blue == 0 && player.Color_Count == 0)
            {
                Pa.SetActive(true);
            }
            else if (blue.Color_blue == 0 && player.Color_Count_Blue == 1 && player.Color_Count == 1)
            {
                Pa.SetActive(true);
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (hit == other.gameObject)
        {
            hit = null;
//            //Debug.Log("Exit : " + other.gameObject.name);
            Pa.SetActive(false);
        }

    }
}
