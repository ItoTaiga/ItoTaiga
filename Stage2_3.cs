using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stage2_3 : MonoBehaviour {

    public GameObject Clear;
    GameObject hit = null;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }

    void OnTriggerStay2D(Collider2D other)
    {
        hit = other.gameObject;

        if (hit.gameObject.CompareTag("Player"))
        {
            ikou();
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (hit == other.gameObject)
        {
            hit = null;
            //Debug.Log("Exit : " + other.gameObject.name);
            
        }

    }

    void ikou()
    {
        SceneManager.LoadScene("Story5");

    }
}
