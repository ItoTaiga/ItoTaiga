using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Color : MonoBehaviour
{

    public GameObject hit = null;
    public int Color_Count;
    public int Color_Count_Green;
    public int Color_Count_Brown;
    public int Color_Count_Red;
    public int Color_Count_Blue;
    public int Color_Count_Yellow;

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerStay2D(Collider2D other)
    {
        //Debug.Log("Enter : " + other.gameObject.name);
        hit = other.gameObject;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        //Debug.Log("Exit : " + other.gameObject.name);
        if (hit == other.gameObject)
        {
            hit = null;
        }
    }

    public void Magic_ON()
    {
        //色変えプログラム
        if (hit != null)
        {
            Color_Brown brown = hit.GetComponent<Color_Brown>();
            Color_Green green = hit.GetComponent<Color_Green>();
            Color_Red red = hit.GetComponent<Color_Red>();
            Color_Blue blue = hit.GetComponent<Color_Blue>();
            Color_Yellow yellow = hit.GetComponent<Color_Yellow>();
            ////Debug.Log(hit.name);

            //if (Input.GetKeyDown(KeyCode.X))
            //{
            if (hit.gameObject.CompareTag("Brown"))
            {
                //各条件式に&&Color_countを追加
                if (brown.Color_brown == 0 && Color_Count_Brown >= 1 && Color_Count == 1)
                {
                    brown.Color_brown++;
                    Color_Count_Brown--;
                    Color_Count--;
                    //brown.Test();
                }
                else if (brown.Color_brown == 1 && Color_Count == 0 && Color_Count == 0)
                {
                    brown.Color_brown--;
                    Color_Count_Brown++;
                    Color_Count++;
                    //brown.Test();
                }

            }
            else if (hit.gameObject.CompareTag("Green"))
            {
                if (green.Color_green == 0 && Color_Count_Green >= 1 && Color_Count == 1)
                {
                    green.Color_green++;
                    Color_Count_Green--;
                    Color_Count--;
                    //green.Test();

                }
                else if (green.Color_green == 1 && Color_Count == 0 && Color_Count == 0)
                {
                    green.Color_green--;
                    Color_Count_Green++;
                    Color_Count++;
                    //green.Test();
                }

            }
            else if (hit.gameObject.CompareTag("Red"))
            {
                if (red.Color_red == 0 && Color_Count_Red >= 1 && Color_Count == 1)
                {
                    red.Color_red++;
                    Color_Count_Red--;
                    Color_Count--;
                    //red.Test();

                }
                else if (red.Color_red == 1 && Color_Count == 0 && Color_Count == 0)
                {
                    red.Color_red--;
                    Color_Count_Red++;
                    Color_Count++;
                    //red.Test();
                }

            }
            else if (hit.gameObject.CompareTag("Blue"))
            {
                if (blue.Color_blue == 0 && Color_Count_Blue >= 1 && Color_Count == 1)
                {
                    blue.Color_blue++;
                    Color_Count_Blue--;
                    Color_Count--;
                    //blue.Test();

                }
                else if (blue.Color_blue == 1 && Color_Count == 0 && Color_Count == 0)
                {
                    blue.Color_blue--;
                    Color_Count_Blue++;
                    Color_Count++;
                    //blue.Test();
                }

            }
            else if (hit.gameObject.CompareTag("Yellow"))
            {
                if (yellow.Color_yellow == 0 && Color_Count_Yellow >= 1 && Color_Count == 1)
                {
                    yellow.Color_yellow++;
                    Color_Count_Yellow--;
                    Color_Count--;
                    //yellow.Test();
                }
                else if (yellow.Color_yellow == 1 && Color_Count == 0 && Color_Count == 0)
                {
                    yellow.Color_yellow--;
                    Color_Count_Yellow++;
                    Color_Count++;
                    //yellow.Test();
                }
            }
            //}
        }
    }
}
