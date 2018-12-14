using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Taitoru_modoru : MonoBehaviour {
    //初期タイム指定
    public float time = 600;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //タイムを1秒に1ずつ減らしていく
        time -= Time.deltaTime;


        //Stage内でキー操作を行った場合はタイムをリセットする
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            time = 600;
        }

        //タイムのマイナスは表示しない
        if (time < 0) time = 0;
        if (time == 0)
        {
            //関数ikouを呼び出す
            ikou();
        }

        //ESCキーでタイトルに戻る
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ikou();
        }

    }

    void ikou()
    {
        //タイトルに移行
        SceneManager.LoadScene("Taitoru");

    }
}
