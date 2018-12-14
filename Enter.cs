using UnityEngine;

public class Enter : MonoBehaviour {
   [RuntimeInitializeOnLoadMethod]
    static void Init()
    {
        Screen.SetResolution(1920, 1080, true);
        //ゲーム中のマウスカーソル非表示
        Cursor.visible = false;
        //       //Debug.Log("Init");
    }
}
