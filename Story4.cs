using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Story4 : MonoBehaviour {

    GameObject Hukidashi;
    GameObject Hukidashi2;
    //音声ファイル格納用変数
    public AudioClip sound01;
    public AudioClip sound02;
    public AudioClip sound03;
    public AudioClip sound04;
    public AudioClip sound05;
    public AudioClip sound06;
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
        textbox.text = "うっここは寒いね…";
        audioSource.PlayOneShot(sound01);

        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));
        yield return null;
        audioSource.Stop();

        //レインから魔女1
        anima2.Dasu();
        anima.Kesu();
        textbox.text = " ";
        yield return new WaitForSeconds(0.1f);
        textbox2.text = "そうね、出来るだけ早くここを　抜けましょ";
        audioSource.PlayOneShot(sound02);

        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));
        yield return null;
        audioSource.Stop();

        textbox2.text = "おっと…";
        audioSource.PlayOneShot(sound03);

        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));
        yield return null;
        audioSource.Stop();

        //魔女からレインに代わる場合2
        anima2.Kesu();
        anima.Kesu2();
        textbox2.text = " ";
        yield return new WaitForSeconds(0.1f);
        textbox.text = "氷の柱が邪魔して     通れないね…";
        audioSource.PlayOneShot(sound04);

        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));
        yield return null;
        audioSource.Stop();

        //レインから魔女
        anima2.Kesu2();
        anima.Kesu();
        textbox.text = " ";
        yield return new WaitForSeconds(0.1f);
        textbox2.text = "でも遺跡に向かうにはここを　　通るしかないのよね";
        audioSource.PlayOneShot(sound05);

        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));
        yield return null;
        audioSource.Stop();

        textbox2.text = "どうにかしてこの柱をどかしましょ";
        audioSource.PlayOneShot(sound06);

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
        SceneManager.LoadScene("Stage2");//次のシーンへの移行
    }
}
