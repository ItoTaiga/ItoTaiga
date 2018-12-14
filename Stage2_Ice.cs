using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage2_Ice : MonoBehaviour {
    public GameObject Ice;
    GameObject hit = null;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D other)
    {

        //Debug.Log("Enter : " + other.gameObject.name);
        hit = other.gameObject;
        Stage2_IceScript ice = GetComponent<Stage2_IceScript>();
        if (hit.gameObject.CompareTag("Rock"))
        {
            ice.Ice_Count--;

        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        //Debug.Log("Exit : " + other.gameObject.name);
        if (hit == other.gameObject)
        {
            hit = null;
        }
    }
}
