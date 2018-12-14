using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Story1 : MonoBehaviour {
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

        anima2.Dasu();
        yield return new WaitForSeconds(0.1f);
        textbox2.text = "お～い！ちょっと待って～！";
        audioSource.PlayOneShot(sound01);


        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));
        yield return null;
        audioSource.Stop();
        textbox2.text = "ちょっとキミ、1人で色を全部戻せると思っているの？";
        audioSource.PlayOneShot(sound02);


        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));
        yield return null;
        audioSource.Stop();
        anima2.Kesu();
        anima.Dasu();

        textbox2.text = " ";
        yield return new WaitForSeconds(0.1f);
        textbox.text = "…あなたは誰？";
        audioSource.PlayOneShot(sound03);

        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));
        yield return null;
        audioSource.Stop();
        anima2.Kesu2();
        anima.Kesu();

        textbox.text = " ";
        yield return new WaitForSeconds(0.1f);
        textbox2.text = "私は魔女だよ。キミに協力してって王様から言われたんだ。　色々教えてあげるよ。";
        audioSource.PlayOneShot(sound04);

        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));
        yield return null;
        audioSource.Stop();
        anima2.Kesu();
        anima.Kesu2();

        textbox2.text = "　";
        yield return new WaitForSeconds(0.1f);
        textbox.text = "そうだったんだ。確かに何も分からないまま出てきちゃったな…。";
        audioSource.PlayOneShot(sound05);


        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));
        yield return null;
        audioSource.Stop();
        textbox.text = "それじゃ、これからよろしく　　おねがいします。";
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

    void Scene(){
        SceneManager.LoadScene("Stage1_Taitoru");//Sutory2からStage1_Taitoruに変更
    }
}
