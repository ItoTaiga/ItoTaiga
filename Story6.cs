using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Story6 : MonoBehaviour {

    GameObject Hukidashi;
    GameObject Hukidashi2;
    //音声ファイル格納用変数
    public AudioClip sound01;
    public AudioClip sound02;
    public AudioClip sound03;
    public AudioClip sound04;
    public AudioClip sound05;
    private AudioSource audioSource;


    [SerializeField] UnityEngine.UI.Text textbox;
    [SerializeField] UnityEngine.UI.Text textbox2;

    IEnumerator Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        Hukidashi = GameObject.Find("Image");
        Hukidashi.GetComponent<Anima>();
        Anima anima = Hukidashi.GetComponent<Anima>();

        Hukidashi2 = GameObject.Find("Image2");
        Hukidashi2.GetComponent<Anima2>();
        Anima2 anima2 = Hukidashi2.GetComponent<Anima2>();


        textbox.text = "　　　　　";
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));
        yield return null;

        //最初にレインが話す場合
        anima.Dasu();
        yield return new WaitForSeconds(0.1f);
        textbox.text = "ここに虹の石が置かれてる　台座があるはずなんだけれど";
        audioSource.PlayOneShot(sound01);

        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));
        yield return null;
        audioSource.Stop();


        //レインから魔女1
        anima2.Dasu();
        anima.Kesu();
        textbox.text = " ";
        yield return new WaitForSeconds(0.1f);
        textbox2.text = "うーん…";
        audioSource.PlayOneShot(sound02);

        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));
        yield return null;
        audioSource.Stop();

        textbox2.text = "爆発でどっかいちゃったかな～？";
        audioSource.PlayOneShot(sound03);

        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));
        yield return null;
        audioSource.Stop();

        //魔女からレインに代わる場合2
        anima2.Kesu();
        anima.Kesu2();
        textbox2.text = " ";
        yield return new WaitForSeconds(0.1f);
        textbox.text = "そんな…どうすれば…";
        audioSource.PlayOneShot(sound04);

        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));
        yield return null;
        audioSource.Stop();

        //レインから魔女
        anima2.Kesu2();
        anima.Kesu();
        textbox.text = " ";
        yield return new WaitForSeconds(0.1f);
        textbox2.text = "大丈夫よ、方法はあるはず　 私も考えるわ";
        audioSource.PlayOneShot(sound05);

        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));
        yield return null;
        Scene();

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
        SceneManager.LoadScene("Stage3");//次のシーンへの移行
    }
}
