using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BringBGM2 : MonoBehaviour
{
    public static bool isLoad2 = false;

    

    // Start is called before the first frame update
    void Start()
    {
        


        if (isLoad2 == true)
        { // すでにロードされていたら
            Destroy(this.gameObject); // 自分自身を破棄して終了
            return;
        }
        isLoad2 = true; // ロードされていなかったら、フラグをロード済みに設定する
        DontDestroyOnLoad(this.gameObject);
    }

    public void StopMainSound()
    {
        isLoad2 = false;
        Destroy(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
