using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Story3_not : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        Story3 story3 = this.GetComponent<Story3>();
        story3.enabled = false;
    
        //2秒後に動けるようになるようにする
        Invoke("StoryReMove3", 2.0f);

    }

    void StoryReMove3()
    {
        Story3 story3 = this.GetComponent<Story3>();
        story3.enabled = true;
    }
}
