using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BringBGM : MonoBehaviour
{
    public static bool isLoad = false;


    // Start is called before the first frame update
    void Start()
    {


        if (isLoad==true)
        { // すでにロードされていたら
            Destroy(this.gameObject); // 自分自身を破棄して終了
            return;
        }
        isLoad = true; // ロードされていなかったら、フラグをロード済みに設定する
        DontDestroyOnLoad(this.gameObject);

    }

    public void StopSound()
    {
        Destroy(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
}
