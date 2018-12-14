using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Story7_not : MonoBehaviour {
    
    // Use this for initialization
    void Start () {
        Story7 story7 = this.GetComponent<Story7>();
        story7.enabled = false;

        //2秒後に動けるようになるようにする
        Invoke("StoryReMove7", 2.0f);

    }

    void StoryReMove7()
    {
        Story7 story7 = this.GetComponent<Story7>();
        story7.enabled = true;
    }
}
