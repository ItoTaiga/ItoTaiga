using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage3_flame: MonoBehaviour {
    public GameObject Blue;
    public GameObject Red;
    public GameObject Taimatu;
    bool One;
    public float stoptime = 2.0f;

    // Use this for initialization
    void Start()
    {
        Taimatu.SetActive(false);
        One = true;

    }

    // Update is called once per frame
    void Update()
    {

        Color_Blue blue = Blue.GetComponent<Color_Blue>();
        //一回だけ処理をする
        if (One)
        {
            if (blue.Color_blue == 1)
            {
                //DelayMethodを"stoptime"秒後に呼び出す
                Invoke("DelayMethod", stoptime);
            }
        }


    }
    //
    void DelayMethod()
    {
        if (One)
       {
            Color_Red red = Red.GetComponent<Color_Red>();
            red.Color_red = 1;

            Taimatu.SetActive(true);
            One = false;
        }
    }
}
