using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//この宣言が必要

public class Stage3_Text : MonoBehaviour {

    public GameObject Daiza_Red;
    public GameObject Daiza_Blue;
    public GameObject Daiza_Yellow;
    public GameObject Kaminari;
    public GameObject Kurisutal_Blue;
    public GameObject Taimatu;
    public GameObject Rein;
    GameObject Hukidashi;
    Text text;



    void Start()
    {
        text = GetComponentInChildren<Text>();//UIのテキストの取得の仕方
    }

    void Update()
    {
        Color_Red daiza_red = Daiza_Red.GetComponent<Color_Red>();
        Color_Red taimatu_red = Taimatu.GetComponent<Color_Red>();
        Color_Blue daiza_blue = Daiza_Blue.GetComponent<Color_Blue>();
        Color_Yellow daiza_yellow = Daiza_Yellow.GetComponent<Color_Yellow>();
        Color_Blue kurisutal_blue = Kurisutal_Blue.GetComponent<Color_Blue>();
        Player_Color rein = Rein.GetComponent<Player_Color>();
        Color_Yellow kaminari = Kaminari.GetComponent<Color_Yellow>();

        if (kurisutal_blue.Color_blue == 0 && rein.Color_Count == 1 && rein.Color_Count_Blue == 1)
        {
            text.text = "青色を移せるところを探しましょう！";
        }
        else if (daiza_blue.Color_blue == 1 && rein.Color_Count == 0 && rein.Color_Count_Blue == 0 && kaminari.Color_yellow == 1 && taimatu_red.Color_red == 1)
        {
            text.text = "台座の力で天候が変わったわね！ほかの色を使って色を移してみて";
        }
        else if (taimatu_red.Color_red == 0 && rein.Color_Count == 1 && rein.Color_Count_Red == 1)
        {
            text.text = "赤色を台座に使ってみましょう！";
        }
        else if (kaminari.Color_yellow == 0 && rein.Color_Count == 1 && rein.Color_Count_Yellow == 1)
        {
            text.text = "黄色を台座に使ってみましょう！";
        }
        else if (daiza_blue.Color_blue == 1 && daiza_red.Color_red == 1 && daiza_yellow.Color_yellow == 1)
        {
            text.text = "虹の力で地下への道が出たみたいね！";
        }
        else if (daiza_blue.Color_blue == 1 && daiza_red.Color_red == 1 && daiza_yellow.Color_yellow == 0)
        {
            text.text = "カミナリが使えそうよ";
        }
        else if (daiza_blue.Color_blue == 1 && daiza_red.Color_red == 0 && daiza_yellow.Color_yellow == 1)
        {
            text.text = "松明の赤をどこかに移せないかしら？";
        }
        else
        {
            text.text = "クリスタルの青色で何かできないかな？";
        }
    }
}
