using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spring : MonoBehaviour {
    GameObject hit = null;
    private Animator anim;

    // Use this for initialization
    void Start() {
        anim = GetComponent<Animator>();


    }

    // Update is called once per frame
    void Update() {
     

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        
        //Debug.Log("Enter : " + other.gameObject.name);
        hit = other.gameObject;
        //hit.GetComponent<Rigidbody2D>().velocity = new Vector2(35,35);
        Rigidbody2D rigid =hit.GetComponent<Rigidbody2D>();
        rigid.velocity =(new Vector2(1, 1) * 23);
        hit.GetComponent<Player_Script>().Fall_A();
        anim.SetBool("Spring", true);
    }

    void OnTriggerExit2D(Collider2D other)
    {
        anim.SetBool("Spring", false);
        //Debug.Log("Exit : " + other.gameObject.name);
        if (hit == other.gameObject)
        {
            hit = null;
        }
    }
}
