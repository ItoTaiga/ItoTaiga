using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour {

    private AudioSource sound01;
    private AudioSource sound02;
    private AudioSource sound03;
    private AudioSource sound04;
    public GameObject Magic;


    void Start () {
        AudioSource[] audioSources = GetComponents<AudioSource>();
        sound01 = audioSources[0];
        sound02 = audioSources[1];
        sound03 = audioSources[2];
        sound04 = audioSources[3];
    }
    /*
        // Update is called once per frame
        void Update () {

        }*/

    public void Colorsound()
    {
        sound01.PlayOneShot(sound01.clip);
    }

    public void Jumpsound()
    {
        sound02.PlayOneShot(sound02.clip);
    }

    public void Groundsound()
    {
        sound03.PlayOneShot(sound03.clip);
    }

    public void Dashsound()
    {
        sound04.PlayOneShot(sound04.clip);
    }

    public void Endsound()
    {
        sound01.Stop();
        sound02.Stop();
        sound03.Stop();
        sound04.Stop();
    }

    public void Magical()
    {
//        //Debug.Log("Magic");
        Player_Color magic = Magic.GetComponent<Player_Color>();
        magic.Magic_ON();
    }
}
