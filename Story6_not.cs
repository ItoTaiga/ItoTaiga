using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Story6_not : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        Story6 story6 = this.GetComponent<Story6>();
        story6.enabled = false;

        //2秒後に動けるようになるようにする
        Invoke("StoryReMove6", 2.0f);

    }

    void StoryReMove6()
    {
        Story6 story6 = this.GetComponent<Story6>();
        story6.enabled = true;
    }
}
