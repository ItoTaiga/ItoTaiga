using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage1_Brown : MonoBehaviour {
    public GameObject Yane;
    public GameObject Brown;

	// Use this for initialization
	void Start () {
        Brown.gameObject.SetActive(false);

    }
	
	// Update is called once per frame
	void Update () {
        Color_Brown brown = Yane.GetComponent<Color_Brown>();
        if (brown.Color_brown == 1)
        {
            Brown.gameObject.SetActive(true);
        }
        else
        {
            Brown.gameObject.SetActive(false);
        }

    }
}
