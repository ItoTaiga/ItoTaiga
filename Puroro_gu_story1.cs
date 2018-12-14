using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Puroro_gu_story1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    void Update()
    {

        if (Input.GetKeyDown("up"))
        {
            Scene();
        }
    }

    void Scene()
    {
        SceneManager.LoadScene("Story1");//次のシーンへの移行
    }
}
