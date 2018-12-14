using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Story7 : MonoBehaviour {

    GameObject Hukidashi;
    GameObject Hukidashi2;
    public GameObject Shiro;
    //音声ファイル格納用変数
    public AudioClip sound01;
    public AudioClip sound02;
    public AudioClip sound03;
    public AudioClip sound04;
    public AudioClip sound05;
    public AudioClip sound06;
    public AudioClip sound07;
    public AudioClip sound08;
    public AudioClip sound09;
    public AudioClip sound10;
    public AudioClip sound11;
    public AudioClip sound12;
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

        Shiro.SetActive(false);
        textbox.text = "　　　　　";
        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));
        yield return null;

        //最初にレインが話す場合
        anima.Dasu();
        yield return new WaitForSeconds(0.1f);
        textbox.text = "あった…";
        audioSource.PlayOneShot(sound01);

        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));
        yield return null;
        audioSource.Stop();

        //レインから魔女1
        anima2.Dasu();
        anima.Kesu();
        textbox.text = " ";
        yield return new WaitForSeconds(0.1f);
        textbox2.text = "伝説では聞いていたけれどまさか地下にあるとはね…";
        audioSource.PlayOneShot(sound02);

        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));
        yield return null;
        audioSource.Stop();

        textbox2.text = "さあその杖を使ってみて";
        audioSource.PlayOneShot(sound03);

        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));
        yield return null;
        audioSource.Stop();

        //魔女からレインに代わる場合2
        anima2.Kesu();
        anima.Kesu2();
        textbox2.text = " ";
        yield return new WaitForSeconds(0.1f);
        textbox.text = "あれ…";
        audioSource.PlayOneShot(sound04);

        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));
        yield return null;
        audioSource.Stop();


        //レインから魔女
        anima2.Kesu2();
        anima.Kesu();
        textbox.text = " ";
        yield return new WaitForSeconds(0.1f);
        textbox2.text = "ありゃ、やっぱり魔力が足りないか、キミは魔法使いじゃないしね";
        audioSource.PlayOneShot(sound05);

        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));
        yield return null;
        audioSource.Stop();

        textbox2.text = "私も力を貸すわ。さぁいくよ！";
        audioSource.PlayOneShot(sound06);

        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));
        yield return null;
        audioSource.Stop();

        anima2.Kesu();
        textbox2.text = " ";
        Shiro.SetActive(true);
        

        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));
        yield return null;


        //魔女からレインに代わる場合2
        
        anima.Kesu2();
        textbox2.text = " ";
        yield return new WaitForSeconds(0.1f);
        textbox.text = "魔法使えたんだね";
        audioSource.PlayOneShot(sound07);

        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));
        yield return null;
        audioSource.Stop();


        //レインから魔女
        anima2.Kesu2();
        anima.Kesu();
        textbox.text = " ";
        yield return new WaitForSeconds(0.1f);
        textbox2.text = "王様の息子だからって失礼ね魔女だって言ってるじゃない。";
        audioSource.PlayOneShot(sound08);

        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));
        yield return null;
        audioSource.Stop();

        //魔女からレインに代わる場合2
        anima2.Kesu();
        anima.Kesu2();
        textbox2.text = " ";
        yield return new WaitForSeconds(0.1f);
        textbox.text = "ふふっ、冗談だよ。";
        audioSource.PlayOneShot(sound09);

        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));
        yield return null;
        audioSource.Stop();
        textbox.text = "本当にありがとう。あなたが　いなかったらもうこの景色は見れなかったと思う";
        audioSource.PlayOneShot(sound10);

        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));
        yield return null;
        audioSource.Stop();

        //レインから魔女
        anima2.Kesu2();
        anima.Kesu();
        textbox.text = " ";
        yield return new WaitForSeconds(0.1f);
        textbox2.text = "お褒めの言葉光栄ですわ。　レイン王子。";
        audioSource.PlayOneShot(sound11);

        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));
        yield return null;
        audioSource.Stop();

        //魔女からレインに代わる場合2
        anima2.Kesu();
        anima.Kesu2();
        textbox2.text = " ";
        yield return new WaitForSeconds(0.1f);
        textbox.text = "さぁ城に戻ろうか";
        audioSource.PlayOneShot(sound12);

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
        SceneManager.LoadScene("END");//次のシーンへの移行シーンができ次第Endingに変更
    }
}
