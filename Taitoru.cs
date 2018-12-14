using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Taitoru : MonoBehaviour {

    public Animator anim;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown( "space"))
        {
            anim.SetBool("space", true);
//            SceneManager.LoadScene("Stage1");
        }
    }

    public void LoadS_1()
    {
        SceneManager.LoadScene("Puroro_gu");
    }
}
