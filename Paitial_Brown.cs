using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paitial_Brown : MonoBehaviour {

    GameObject hit = null;
    public GameObject Pa;
    public GameObject Brown;

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
        Color_Brown brown = GetComponent<Color_Brown>();
        Player_Color player = hit.GetComponent<Player_Color>();
//        //Debug.Log("Enter : " + other.gameObject.name);
        if (brown.Color_brown == 1 && player.Color_Count_Brown == 0 && player.Color_Count==0)
        {
            Pa.SetActive(true);
        }
        else if (brown.Color_brown == 0 && player.Color_Count_Brown == 1 && player.Color_Count == 1)
        {
            Pa.SetActive(true);
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
