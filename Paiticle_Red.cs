using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paiticle_Red : MonoBehaviour {
    GameObject hit = null;
    public GameObject Pa;
    public GameObject Red;

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
        Color_Red red = GetComponent<Color_Red>();
        Player_Color player = hit.GetComponent<Player_Color>();
        //Debug.Log("Enter : " + other.gameObject.name);
        if (hit.gameObject.CompareTag("Player"))
        {
            if (red.Color_red == 1 && player.Color_Count_Red == 0 && player.Color_Count == 0)
            {
                Pa.SetActive(true);
            }
            else if (red.Color_red == 0 && player.Color_Count_Red == 1 && player.Color_Count == 1)
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
