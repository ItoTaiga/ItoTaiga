using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//この宣言が必要

public class Stage2_Text : MonoBehaviour {
    public GameObject Kaeru;
    public GameObject Taimatu;
    public GameObject Ice;
    public GameObject Kurisutal;
    public GameObject Mizu;
    public GameObject Rein;
    public GameObject Iwa;
    GameObject Hukidashi;
    Text text;



    void Start()
    {
        text = GetComponentInChildren<Text>();//UIのテキストの取得の仕方
    }

     void Update()
    {
        Color_Red kaeru_red = Kaeru.GetComponent<Color_Red>();
        Color_Red taimatu_red = Taimatu.GetComponent<Color_Red>();
        Color_Blue Ice_blue = Ice.GetComponent<Color_Blue>();
        Color_Red kurisutal_red = Kurisutal.GetComponent<Color_Red>();
        Color_Blue mizu_blue = Mizu.GetComponent<Color_Blue>();
        Player_Color rein = Rein.GetComponent<Player_Color>();
        Stage2_Iwa iwa = Iwa.GetComponent<Stage2_Iwa>();

        if (kurisutal_red.Color_red == 0 && rein.Color_Count == 1 && rein.Color_Count_Red == 1)
        {
            text.text = "赤色を移せるところを探しましょう！";
        } else if (Ice_blue.Color_blue == 0 && rein.Color_Count == 1 && rein.Color_Count_Blue == 1)
        {
            text.text = "湖と岩の穴は繋がってるみたいね岩が当たらないように移しましょ";
        } else if (rein.Color_Count == 0 && taimatu_red.Color_red == 1 && Ice_blue.Color_blue == 1)
        {
            text.text = "氷の柱を少し溶けたみたいね！出てきた青で何かできないかな？";
        } else if (kaeru_red.Color_red == 1 && rein.Color_Count == 0 && mizu_blue.Color_blue == 0)
        {
            text.text = "何かで岩を押し出せるかもしれないわ！探してみましょう！";
        }else if (iwa.kaeru ==0 && rein.Color_Count ==0 && mizu_blue.Color_blue==1) {
            //else if内の条件文Kaeru_red.Color_red ==0をiwa.kaeru ==0に変更
            text.text = "ツタが引っかかってるみたい…どうにかしてツタをどかせないかしら？";
    
        }
        else if (iwa.kaeru == 1 && mizu_blue.Color_blue == 1){
            text.text = "氷の柱がどかせたわね！右奥に向かえばもうすぐ遺跡よ";
        }
        else
        {
            text.text = "クリスタルの赤色で何かできないかな？";
        }
    }
    
}
