using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Story5_not : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        Story5 story5 = this.GetComponent<Story5>();
        story5.enabled = false;

        //2秒後に動けるようになるようにする
        Invoke("StoryReMove5", 2.0f);

    }

    void StoryReMove5()
    {
        Story5 story5 = this.GetComponent<Story5>();
        story5.enabled = true;
    }
}
