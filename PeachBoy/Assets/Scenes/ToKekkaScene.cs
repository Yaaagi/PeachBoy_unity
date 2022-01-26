using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ToKekkaScene : MonoBehaviour
{
    private float step_time;    // 経過時間カウント用

    // Start is called before the first frame update
    void Start()
    {
        

        step_time = 0.0f;       // 経過時間初期化

        
    }

    // Update is called once per frame
    void Update()
    {
        string rank = UIController2.playerRank;

        // 経過時間をカウント
        step_time += Time.deltaTime;

        // 5秒後に画面遷移（resultへ移動）
        if (step_time >= 13.0f)
        {
            if (rank == "S")
            {
                SceneManager.LoadScene("RankS");
            }
            if (rank == "A")
            {
                SceneManager.LoadScene("RankA");
            }
            if (rank == "B")
            {
                SceneManager.LoadScene("RankB");
            }
            if (rank == "C")
            {
                SceneManager.LoadScene("RankC");
            }
            if (rank == "F")
            {
                SceneManager.LoadScene("RankF");
            }
        }

    }
}
