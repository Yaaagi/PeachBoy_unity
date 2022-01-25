using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToSampleScene : MonoBehaviour
{
    public static string nowScene = "NotNowScene";

    private float step_time;    // 経過時間カウント用

    // Start is called before the first frame update
    void Start()
    {
        step_time = 0.0f;       // 経過時間初期化
        nowScene = "NowScene";
    }

    // Update is called once per frame
    void Update()
    {
        // 経過時間をカウント
        step_time += Time.deltaTime;

        // 5秒後に画面遷移（resultへ移動）
        if (step_time >= 2.0f)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
