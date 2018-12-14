using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Story1_not : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        Story1 story1 = this.GetComponent<Story1>();
        story1.enabled = false;

        //2秒後に動けるようになるようにする
        Invoke("StoryReMove1", 2.0f);

    }

    void StoryReMove1()
    {
        Story1 story1 = this.GetComponent<Story1>();
        story1.enabled = true;
    }
}
