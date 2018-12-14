using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hints : MonoBehaviour {
    private Animator anim;
    public int Hint=0;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("up") && Hint == 0)
        {
            anim.SetBool("Hints", true);
            Hint = 1;
        }else if (Input.GetKeyDown("up") && Hint == 2)
        {
            anim.SetBool("Hints2", false);
            Hint = 1;
        }else if(Input.GetKeyDown("up")&& Hint == 1)
        {
            anim.SetBool("Hints2", true);
            Hint = 2;
        }
        

    }
}
