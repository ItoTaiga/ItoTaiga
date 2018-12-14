using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kaminari_Stop : MonoBehaviour {

    public GameObject kaminari0;

    // Use this for initialization
    void Start()
    {
        //Player_Script rein = Rain.GetComponent<Player_Script>();
        //Rigidbody2D rigid2D = Rain.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() { }

    void Stop()
    {
        Animator rein = kaminari0.GetComponent<Animator>();
        rein.enabled = false;
    }
}
