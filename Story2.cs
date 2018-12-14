using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Story2 : MonoBehaviour {

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
        textbox2.text = "あ！リンゴの芽がある！";
        audioSource.PlayOneShot(sound01);


        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));
        yield return null;
        audioSource.Stop();

        anima2.Kesu();
        anima.Dasu();
        textbox2.text = " ";
        yield return new WaitForSeconds(0.1f);
        textbox.text = "そういえばお腹すいちゃったな";
        audioSource.PlayOneShot(sound02);

        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));
        yield return null;
        audioSource.Stop();

        anima2.Kesu2();
        anima.Kesu();
        textbox.text = " ";
        yield return new WaitForSeconds(0.1f);
        textbox2.text = "ねえ試しに色を移してリンゴと　赤を取ってみましょ？";
        audioSource.PlayOneShot(sound03);


        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));
        yield return null;
        audioSource.Stop();

        textbox2.text = "赤は後で必要になりそうだしね";
        audioSource.PlayOneShot(sound04);

        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));
        yield return null;
        audioSource.Stop();

        anima2.Kesu();
        anima.Kesu2();

        textbox2.text = "　";
        yield return new WaitForSeconds(0.1f);
        textbox.text = "色を移してリンゴなんてできるの？";
        audioSource.PlayOneShot(sound05);


        yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space));
        yield return null;
        audioSource.Stop();

        anima2.Kesu2();
        anima.Kesu();
        textbox.text = " ";
        yield return new WaitForSeconds(0.1f);
        textbox2.text = "ふふっ私が教えてあげるって 言ったでしょ？";
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
        SceneManager.LoadScene("Stage1");//次のシーンへの移行
    }
}
