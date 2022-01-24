using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCount2 : MonoBehaviour
{
    public float countdown2 = 0.0f;

    //時間を表示するText型の変数
    public Text timeText2;

    public bool isTimeUp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //時間をカウントダウンする
        countdown2 += Time.deltaTime;

        //時間を表示する
        timeText2.text =  countdown2.ToString("f1") + "秒経過";

        if (countdown2 >= 2)
        {
            GameObject.Find("Canvas").GetComponent<UIController2>().Dog();
        }

        if (countdown2 >= 3)
        {
            GameObject.Find("Canvas").GetComponent<UIController2>().ResultDog();
        }

        if (countdown2 >= 4)
        {
            GameObject.Find("Canvas").GetComponent<UIController2>().Monkey();
        }

        if (countdown2 >= 5)
        {
            GameObject.Find("Canvas").GetComponent<UIController2>().ResultMonkey();
        }

        if (countdown2 >= 6)
        {
            GameObject.Find("Canvas").GetComponent<UIController2>().Kiji();
        }

        if (countdown2 >= 7)
        {
            GameObject.Find("Canvas").GetComponent<UIController2>().ResultKiji();
        }

        if (countdown2 >= 8)
        {
            GameObject.Find("Canvas").GetComponent<UIController2>().Rank();
        }

        if (countdown2 >= 10)
        {
            GameObject.Find("Canvas").GetComponent<UIController2>().ResultRank();
        }

       
    }


}
