using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stage : MonoBehaviour {
    public int Color_color;
    public GameObject S1;
    //public GameObject S3;
    int num = 1;

    void Start() {

    }
    void Update() {

        switch (num)
        {
            case 1:
                S1.gameObject.SetActive(true);
                break;
        }

        if (num >= 2)
        {
            num = 2;
        }
        if (num <= 1)
        {
            num = 1;
        }

        
        
    }
   
  }

