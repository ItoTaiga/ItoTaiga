using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kaihatu : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Keypad0))
        {
            SceneManager.LoadScene("Taitoru");
        }
        else if (Input.GetKeyDown(KeyCode.Keypad1))//開発コード
        {
            SceneManager.LoadScene("puroro_gu");
        }
        else if (Input.GetKeyDown(KeyCode.Keypad2))//開発コード
        {
            SceneManager.LoadScene("Story1");
        }
        else if (Input.GetKeyDown(KeyCode.Keypad3))//開発コード
        {
            SceneManager.LoadScene("Stage1");
        }
        else if (Input.GetKeyDown(KeyCode.Keypad4))//開発コード
        {
            SceneManager.LoadScene("Story3");
        }
        else if (Input.GetKeyDown(KeyCode.Keypad5))//開発コード
        {
            SceneManager.LoadScene("Stage_serect");
        }
        else if (Input.GetKeyDown(KeyCode.Keypad6))//開発コード
        {
            SceneManager.LoadScene("Story4");
        }
        else if (Input.GetKeyDown(KeyCode.Keypad7))//開発コード
        {
            SceneManager.LoadScene("Stage2");
        }
        else if (Input.GetKeyDown(KeyCode.Keypad8))//開発コード
        {
            SceneManager.LoadScene("Story5");
        }
        else if (Input.GetKeyDown(KeyCode.Keypad9))//開発コード
        {
            SceneManager.LoadScene("Stage_serect 2");
        }
        else if (Input.GetKeyDown(KeyCode.Q))//開発コード
        {
            SceneManager.LoadScene("Story6");
        }
        else if (Input.GetKeyDown(KeyCode.W))//開発コード
        {
            SceneManager.LoadScene("Stage3");
        }
        else if (Input.GetKeyDown(KeyCode.E))//開発コード
        {
            SceneManager.LoadScene("Story_END");
        }
        else if (Input.GetKeyDown(KeyCode.R))//開発コード
        {
            SceneManager.LoadScene("END");
        }
    }
}
