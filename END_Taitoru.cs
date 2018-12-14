using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class END_Taitoru : MonoBehaviour {



    // Use this for initialization
    void Start () {
		
	}

    void Update()
    {

        //Sキーを押した場合
        if (Input.GetKeyDown(KeyCode.S))
        {
            //Scene関数を呼び出す
            Scene();
        }
    }

    void Scene()
    {
        //タイトルシーンへ遷移
        SceneManager.LoadScene("Taitoru");
    }
}
