using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Script : MonoBehaviour
{

    public float speed = 4f; //歩くスピード
    private Rigidbody2D rigid2D;
    public Animator anim;
    public float flap = 100f;
    bool Jump = false;
    


    //bool Walk = false;
    //bool Color = false;
    //private AudioSource sound01;
    // private AudioSource sound02;
    //   private AudioSource sound03;


    void Start()
    {
        //各コンポーネントをキャッシュしておく
        //anim = GetComponent<Animator>();
        rigid2D = GetComponent<Rigidbody2D>();
        /*
        AudioSource[] audioSources = GetComponents<AudioSource>();
        //sound01 = audioSources[0];
        //sound02 = audioSources[1];
        sound03 = audioSources[2];
        */
    }

    void Update()
    {

        /*       
        
               if (Input.GetKeyDown("space") && !Jump)
               {
                   sound02.PlayOneShot(sound02.clip);
                   rigid2D.AddForce(Vector2.up * flap);
                   Jump = true;
                   //taiki->jump
                   anim.SetBool("Jump", true);
               }
       //*/

        //左キー：-1、右キー：1
        float x = Input.GetAxisRaw("Horizontal");
        //左か右かを入力したら
        if (x != 0)
        {
            //入力方向へ移動
            rigid2D.velocity = new Vector2(x * speed, rigid2D.velocity.y);
            //localScale.xを-1にすると画像が反転する
            Vector2 temp = transform.localScale;
            temp.x = -x;
            transform.localScale = temp;
            //taiki->walk
            anim.SetBool("Dash", true);
            //左も右も入力されていなかったら
        }
        else
        {
            //横移動の速度を０にしてピタっととまるようにする
            rigid2D.velocity = new Vector2(0, rigid2D.velocity.y);
            //walk->taiki
            anim.SetBool("Dash", false);
        }

        Player_Color player = GetComponent<Player_Color>();

        if (player.hit != null)
        {
            Debug.Log("Stay");
            //色を移す     
            if (Input.GetKeyDown(KeyCode.Space) && !Jump)
            {
                Debug.Log("Color");
                Stop_Rain();
                anim.SetBool("Color", true);
            }
            else
            {
                anim.SetBool("Color", false);
            }
        }

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        ////Debug.Log("Enter");
        if (other.gameObject.CompareTag("Ground"))
        {
            if (Jump == true)
            {
                //sound03.PlayOneShot(sound03.clip);
                anim.SetBool("Jump", false);
                anim.SetBool("Fall", false);
                anim.SetBool("OnGround", true);
                Jump = false;
            }
        }
    }

    public void Fall_A()
    {
        anim.SetBool("OnGround", false);
        anim.SetBool("Jump", false);
        anim.SetBool("Fall", true);
        Jump = true;
    }

    /*void OnTriggerStay2D(Collider2D other)
    {
        //色を移す
        if (Input.GetKeyDown(KeyCode.X))
        {
            //Debug.Log("Color");
            anim.SetBool("Color", true);
            sound01.PlayOneShot(sound01.clip);
        }
        else
        {
            anim.SetBool("Color", false);
        }

    }*/





    void ReMove()
    {
        enabled = true;
    }

    public void Stop_Rain()
    {
        //Playerの動きを止める
        rigid2D.velocity = new Vector2(0, rigid2D.velocity.y);
        enabled = false;

        //3秒後に動けるようになるようにする
        Invoke("ReMove", 2.0f);

        //anim.SetBool("Color", false);

    }

}











