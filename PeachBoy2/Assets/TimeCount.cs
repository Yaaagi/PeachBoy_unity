using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCount : MonoBehaviour
{
    //カウントダウン
    public float countdown;

    public bool isTimeUp;


    // Start is called before the first frame update
    void Start()
    {
        countdown = 65.0f;
        isTimeUp = false;
    }
    

    //時間を表示するText型の変数
    public Text timeText;

    

    // Update is called once per frame
    void Update()
    {
        int p = Player.playerhp;
        //時間をカウントダウンする
        countdown -= Time.deltaTime;

        //時間を表示する
        timeText.text = "残り" + countdown.ToString("f1") + "秒";

        //countdownが0以下になったとき
        if (countdown <= 0)
        {
            
            isTimeUp = true;
            timeText.text = "残り" + "0.0" + "秒";
        }
        if (p==0)
        {
            Destroy(gameObject);
        }


    }
}
