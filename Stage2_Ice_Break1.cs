using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage2_Ice_Break1 : MonoBehaviour {

    private Animator anim;
    public GameObject Ice_Break;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        Stage2_IceScript ice = Ice_Break.GetComponent<Stage2_IceScript>();
        if (ice.Ice_Count == 0)
        {
            anim.SetBool("Tobasu", true);
        }

    }
}
