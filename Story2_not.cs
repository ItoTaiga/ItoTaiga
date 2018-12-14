using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Story2_not : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        Story2 story2 = this.GetComponent<Story2>();
        story2.enabled = false;

        //2秒後に動けるようになるようにする
        Invoke("StoryReMove2", 2.0f);

    }

    void StoryReMove2()
    {
        Story2 story2 = this.GetComponent<Story2>();
        story2.enabled = true;
    }
}
