using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage2_taki : MonoBehaviour {

    private Animator anim;
    public GameObject mizu;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        Color_Blue red = mizu.GetComponent<Color_Blue>();
        if (red.Color_blue == 1)
        {
            anim.SetBool("Nagareru", true);
        }

    }
}
