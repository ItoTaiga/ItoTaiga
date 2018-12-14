using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tue_Color : MonoBehaviour {
    public GameObject Player;

    // Use this for initialization
    void Start () {
        //GameObject Player = GameObject.Find("Rain");
	}
	
	// Update is called once per frame
	void Update () {
        Player_Color Tue = Player.GetComponent<Player_Color>();
        ParticleSystem.MainModule main = GetComponent<ParticleSystem>().main;

        if (Tue.Color_Count == 1 && Tue.Color_Count_Red == 1)
        {
            //パーティクルを赤にする
            main.startColor = Color.red;
        }
        else if(Tue.Color_Count== 1 && Tue.Color_Count_Blue == 1)
        {
            //パーティクルを青にする
            main.startColor = Color.blue;
        }
        else if (Tue.Color_Count == 1 && Tue.Color_Count_Yellow == 1)
        {
            //パーティクを黄色にする
            main.startColor = Color.yellow;
        }
        else if(Tue.Color_Count == 1 && Tue.Color_Count_Green == 1)
        {
            //パーティクルを緑にする
            main.startColor = Color.green;
        }
        else if(Tue.Color_Count == 1 && Tue.Color_Count_Brown == 1)
        {
            //パーティクルを茶色にする
            main.startColor = new Color(0.8396226f, 0.4573543f, 0.1465379f);
        }
        else
        {
            //それ以外の場合のパーティクルの色
            //main.startColor = Color.HSVToRGB(27, 76, 82);
            main.startColor = Color.grey;
        }

 //       //Debug.Log(main.startColor.color);

    }
}
