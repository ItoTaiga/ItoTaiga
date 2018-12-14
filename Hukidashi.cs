using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hukidashi : MonoBehaviour {
    GameObject hit = null;
    public GameObject Text;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerStay2D(Collider2D other)
    {
        hit = other.gameObject;

    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (hit.gameObject.CompareTag("Player"))
        {
            Text.SetActive(false);
        }
        if (hit == other.gameObject)
        {
            hit = null;
        }

    }
}
