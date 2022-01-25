using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController2 : MonoBehaviour
{
    public GameObject rank;
    public static string playerRank;
    GameObject resultRankText;

    public GameObject dog;
    GameObject resultDogText;
    int dogcount = Counter.dogCount1;

    public GameObject monkey;
    GameObject resultMonkeyText;
    int monkeycount = Counter.monkeyCount1;

    public GameObject kiji;
    GameObject resultKijiText;
    int kijicount = Counter.kijiCount1;

    

    public void ResultDog()
    {
        this.resultDogText.GetComponent<Text>().text = "×" + dogcount;
    }

    public void Dog()
    {
        dog.SetActive(true);
    }

    public void ResultMonkey()
    {
        this.resultMonkeyText.GetComponent<Text>().text = "×" + monkeycount;
    }

    public void Monkey()
    {
        monkey.SetActive(true);
    }

    public void ResultKiji()
    {
        this.resultKijiText.GetComponent<Text>().text = "×" + kijicount;
    }

    public void Kiji()
    {
        kiji.SetActive(true);
    }

    public void ResultRank()
    {
        if (dogcount == 0 && monkeycount == 0 && kijicount == 0)
        {
            playerRank = "F";
        }
        if (dogcount==10 && monkeycount==10 && kijicount == 0)
        {
            playerRank = "S";
        }
        if ((dogcount + monkeycount + kijicount) >= 20 && (dogcount+monkeycount+kijicount) <= 29)
        {
            playerRank = "A";
        }
        if ((dogcount + monkeycount + kijicount) >= 10 && (dogcount + monkeycount + kijicount) <= 19)
        {
            playerRank = "B";
        }
        if ((dogcount + monkeycount + kijicount) >= 1 && (dogcount + monkeycount + kijicount) <= 9)
        {
            playerRank = "C";
        }

        this.resultRankText.GetComponent<Text>().text = playerRank;

    }

    public void Rank()
    {
        this.rank.GetComponent<Text>().text = "ランク";
    }

    // Start is called before the first frame update
    void Start()
    {
        this.resultDogText = GameObject.Find("ResultDog");
        this.dog = GameObject.Find("犬2");
        this.resultMonkeyText = GameObject.Find("ResultMonkey");
        this.monkey = GameObject.Find("さる1");
        this.resultKijiText = GameObject.Find("ResultKiji");
        this.kiji = GameObject.Find("きじ1");

        dog.SetActive(false);
        monkey.SetActive(false);
        kiji.SetActive(false);
       

        this.rank = GameObject.Find("Rank");
        this.resultRankText = GameObject.Find("ResultRank");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
