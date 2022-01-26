using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BringBGM3 : MonoBehaviour
{
    public static bool isLoad3 = false;

    // Start is called before the first frame update
    void Start()
    {
        if (isLoad3 == true)
        { // すでにロードされていたら
            Destroy(this.gameObject); // 自分自身を破棄して終了
            return;
        }
        isLoad3 = true; // ロードされていなかったら、フラグをロード済みに設定する
        DontDestroyOnLoad(this.gameObject);
    }

    public void StopMainSound2()
    {
        isLoad3 = false;
        Destroy(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
