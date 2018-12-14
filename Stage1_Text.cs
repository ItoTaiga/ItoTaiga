using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//この宣言が必要

public class Stage1_Text : MonoBehaviour {

    public GameObject Ha;
    public GameObject Otiruha;
    public GameObject Ki;
    public GameObject Ie;
    public GameObject Me;
    public GameObject Rein;
    GameObject Hukidashi;
    Text text;

    void Start()
    {
        text = GetComponentInChildren<Text>();//UIのテキストの取得の仕方
    }

    void Update()
    {
        Color_Green ha = Ha.GetComponent<Color_Green>();
        Color_Green otiruha = Otiruha.GetComponent<Color_Green>();
        Color_Brown ki = Ki.GetComponent<Color_Brown>();
        Color_Brown ie = Ie.GetComponent<Color_Brown>();
        Color_Green me = Me.GetComponent<Color_Green>();
        Player_Color rein = Rein.GetComponent<Player_Color>();

        if (ha.Color_green == 0 && rein.Color_Count == 1 &&me.Color_green==0)
        {
            text.text = "光っているのが色が移せる合図よ！先にある芽に移してみて！";
        }
        else if (me.Color_green == 1 && rein.Color_Count == 0　&& ki.Color_brown==1&& otiruha.Color_green ==1)
        {
            text.text = "リンゴを取りに行くために他のものを色移ししてみましょ？";
        }
        else if (rein.Color_Count == 1 && otiruha.Color_green == 0 &&ki.Color_brown==1)
        {
            text.text = "最初に取った葉っぱに移してみましょ！";
        }
        else if (ki.Color_brown == 0 && rein.Color_Count == 1)
        {
            text.text = "家に茶色を移してみましょ！";
        }
        else if (ha.Color_green == 1 && rein.Color_Count == 0 && otiruha.Color_green == 0&& ie.Color_brown ==0)
        {
            text.text = "木の茶色をどこかに移してみましょ！";

        }
        else if (ki.Color_brown ==0 && ie.Color_brown ==1 && rein.Color_Count==0 &&ha.Color_green ==0)
        {
            text.text = "最初の葉っぱにまた色を移せば屋根に上れそうね";
        }
        else if (ie.Color_brown ==1 && ha.Color_green ==1)
        {
            text.text = "屋根に上ってリンゴを取りに行きましょ！";
        }
        else
        {
            text.text = "葉っぱに近づいてスペースを押してみて！";
        }
    }


}
