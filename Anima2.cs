using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anima2 : MonoBehaviour {
    private Animator anim;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Dasu()
    {
        anim.SetBool("Dasu2", true);
    }

    public void Kesu()
    {
        anim.SetBool("Kesu2", true);
    }
    public void Kesu2()
    {
        anim.SetBool("Kesu2", false);
    }
}
