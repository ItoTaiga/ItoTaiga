using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage1_MeAnimation : MonoBehaviour {
    private Animator anim;
    public GameObject Me;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();

    }
	
	// Update is called once per frame
	void Update () {
        Color_Green green = GetComponent<Color_Green>();
        if(green.Color_green == 1)
        {
            anim.SetBool("Me", true);
        }

    }


}
