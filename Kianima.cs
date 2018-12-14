using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kianima : MonoBehaviour {
    private Animator anim;

    // Use this for initialization

    void Start () {
        anim = GetComponent<Animator>();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Ki()
    {
        anim.SetBool("Ki", true);
    }

    public void Ki2()
    {
        anim.SetBool("Ki2", true);
    }
}
