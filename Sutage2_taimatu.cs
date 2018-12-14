using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sutage2_taimatu : MonoBehaviour {
    private Animator anim;
    GameObject hit = null;


    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        hit = other.gameObject;
        if (hit.gameObject.CompareTag("Player"))
        {
            anim.SetBool("Taoreru", true);
        }

    }

    void OnTriggerExit2D(Collider2D other)
    {
        //プレイヤーが離れたときにアニメーションをする
        
        if (hit == other.gameObject)
        {
            hit = null;
        }
    }
}

