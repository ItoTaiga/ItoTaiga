using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage2_Shizuku : MonoBehaviour {
    private Animator anim;
    public GameObject mizu;

    // Use this for initialization
    void Start () {
        //アニメーターを格納
        anim = GetComponent<Animator>();

    }
	
	// Update is called once per frame
	void Update () {
        Color_Blue blue = mizu.GetComponent<Color_Blue>();
        if (blue.Color_blue == 0) {
            anim.SetBool("Waite", false);
        }else if(blue.Color_blue == 1)
        {
            anim.SetBool("Waite", true);
        }
		
	}
}
