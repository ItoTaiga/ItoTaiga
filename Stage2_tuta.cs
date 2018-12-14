using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage2_tuta : MonoBehaviour {

    private Animator anim;
    public GameObject Kaeru;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        Color_Red red = Kaeru.GetComponent<Color_Red>();
        if (red.Color_red == 1)
        {
            anim.SetBool("kieru", true);
        }

    }
}
