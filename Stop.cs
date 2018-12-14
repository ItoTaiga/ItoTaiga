using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stop : MonoBehaviour {
    public GameObject Rain;

	// Use this for initialization
	void Start () {
        //Player_Script rein = Rain.GetComponent<Player_Script>();
        //Rigidbody2D rigid2D = Rain.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() { }

    public void Stop_Rain()
    {
            //Playerの動きを止める
            Player_Script rein = Rain.GetComponent<Player_Script>();
            Rigidbody2D rigid2D = Rain.GetComponent<Rigidbody2D>();
            rigid2D.velocity = new Vector2(0, rigid2D.velocity.y);
            rein.enabled = false;
        //Debug.Log("Stop");
            //3秒後に動けるようになるようにする
            Invoke("ReMove", 6.0f);
    }

    void ReMove()
    {
        Player_Script rein = Rain.GetComponent<Player_Script>();
        rein.enabled = true;
    }
}
