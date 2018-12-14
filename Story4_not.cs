using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Story4_not : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        Story4 story4 = this.GetComponent<Story4>();
        story4.enabled = false;

        //2秒後に動けるようになるようにする
        Invoke("StoryReMove4", 2.0f);

    }

    void StoryReMove4()
    {
        Story4 story4 = this.GetComponent<Story4>();
        story4.enabled = true;
    }
}
