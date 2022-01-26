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

    public GameObject sounddon;
    public GameObject soundjan;

    bool One;
    bool One2;
    bool One3;
    bool One4;
    bool One5;
    bool One6;
    bool One7;

    // Start is called before the first frame update
    void Start()
    {
        soundjan = GameObject.Find("Jan Sound");
        sounddon = GameObject.Find("Don Sound");
        One = true;
        One2 = true;
        One3 = true;
        One4 = true;
        One5 = true;
        One6 = true;
        One7 = true;
    }

    // Update is called once per frame
    void Update()
    {
        

        //時間をカウントダウンする
        countdown2 += Time.deltaTime;

        //時間を表示する
        //timeText2.text =  countdown2.ToString("f1") + "秒経過";

        if (countdown2 >= 2)
        {
            GameObject.Find("Canvas").GetComponent<UIController2>().Dog();
            if (One)
            {
                sounddon.GetComponent<DonSound>().SoundDon();
                One = false;
            }
            
        }

        if (countdown2 >= 3)
        {
            GameObject.Find("Canvas").GetComponent<UIController2>().ResultDog();
            if (One2)
            {
                sounddon.GetComponent<DonSound>().SoundDon();
                One2 = false;
            }
        }

        if (countdown2 >= 4)
        {
            GameObject.Find("Canvas").GetComponent<UIController2>().Monkey();
            if (One3)
            {
                sounddon.GetComponent<DonSound>().SoundDon();
                One3 = false;
            }
        }

        if (countdown2 >= 5)
        {
            GameObject.Find("Canvas").GetComponent<UIController2>().ResultMonkey();
            if (One4)
            {
                sounddon.GetComponent<DonSound>().SoundDon();
                One4 = false;
            }
        }

        if (countdown2 >= 6)
        {
            GameObject.Find("Canvas").GetComponent<UIController2>().Kiji();
            if (One5)
            {
                sounddon.GetComponent<DonSound>().SoundDon();
                One5 = false;
            }
        }

        if (countdown2 >= 7)
        {
            GameObject.Find("Canvas").GetComponent<UIController2>().ResultKiji();
            if (One6)
            {
                sounddon.GetComponent<DonSound>().SoundDon();
                One6 = false;
            }
        }

        if (countdown2 >= 8)
        {
            GameObject.Find("Canvas").GetComponent<UIController2>().Rank();
        }

        if (countdown2 >= 10)
        {
            GameObject.Find("Canvas").GetComponent<UIController2>().ResultRank();
            if (One7)
            {
                soundjan.GetComponent<JanSound>().SoundJan();
                One7 = false;
            }
            
        }

       
    }


}
