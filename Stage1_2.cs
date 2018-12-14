using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stage1_2 : MonoBehaviour {
    public GameObject Apple;
    GameObject hit = null;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        

    }

    void OnTriggerStay2D(Collider2D other)
    {
        hit = other.gameObject;
        if (hit.gameObject.CompareTag("Player"))
         {
             SceneManager.LoadScene("Story3");
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
}
