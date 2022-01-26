using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    public GameObject enemyPrefab; //犬
    public GameObject enemyPrefab2; //さる
    public GameObject enemyPrefab3; //キジ
    public GameObject enemyPrefab4; //ライオン
    public GameObject enemyPrefab5; //チーター
    public GameObject enemyPrefab6; //ねこ
    public GameObject enemyPrefab7; //くま
    public GameObject enemyPrefab8; //ヘビ
    public GameObject enemyPrefab9; //ばあちゃん

    private float interval = 2.0f;
    private float timeElapsed = 0.0f;

    //ライオン
    private float intervalLion = 5.0f;
    private float timeElapsedLion = 0.0f;

    //チーター
    private float intervalCheetah = 10.0f;
    private float timeElapsedCheetah = 0.0f;

    //ねこ
    private float intervalCat = 6.0f;
    private float timeElapsedCat = 0.0f;

    //くま
    private float intervalBear = 10.0f;
    private float timeElapsedBear = 0.0f;

    //ヘビ
    private float intervalSnake = 6.0f;
    private float timeElapsedSnake = 0.0f;

    //ばあちゃん
    private float intervalGrandmother = 15.0f;
    private float timeElapsedGrandmother = 0.0f;

    public GameObject timeUp;
    private int countdog;
    private int countmonkey;
    private int countkiji;

    // Start is called before the first frame update
    void Start()
    {
        timeUp = GameObject.Find("Time");
        countdog = 0;
        countmonkey = 0;
        countkiji = 0;
    }

    
    
    
    Random r = new Random();

    // Update is called once per frame
    void Update()
    {
        //制限時間内だけオブジェクトを生成
        if (timeUp.GetComponent<TimeCount>().isTimeUp == false)
        {

            int randomValue1 = Random.Range(1, 4);
            int randomValue2 = Random.Range(1, 4);
            int randomValue3 = Random.Range(1, 3);
            int randomValue4 = Random.Range(1, 3);

            timeElapsed += Time.deltaTime;
            timeElapsedLion += Time.deltaTime;
            timeElapsedCheetah += Time.deltaTime;
            timeElapsedCat += Time.deltaTime;
            timeElapsedBear += Time.deltaTime;
            timeElapsedSnake += Time.deltaTime;
            timeElapsedGrandmother += Time.deltaTime;
            //犬
            if (timeElapsed >= interval && randomValue1 == 1 && countdog < 10)
            {
                timeElapsed = 0.0f;
                Vector3 randamPos = new Vector3(11, Random.Range(3.7f, -2.0f), 0);
                Instantiate(enemyPrefab, randamPos, Quaternion.identity);
                countdog = countdog + 1;
            }
            //さる
            if (timeElapsed >= interval && randomValue1 == 2 && countmonkey < 10)
            {
                timeElapsed = 0.0f;
                Vector3 randamPos = new Vector3(11, Random.Range(3.7f, -2.0f), 0);
                Instantiate(enemyPrefab2, randamPos, Quaternion.identity);
                countmonkey = countmonkey + 1;
            }
            //キジ
            if (timeElapsed >= interval && randomValue1 == 3 && countkiji < 10)
            {
                timeElapsed = 0.0f;
                Vector3 randamPos = new Vector3(11, Random.Range(3.7f, -2.0f), 0);
                Instantiate(enemyPrefab3, randamPos, Quaternion.identity);
                countkiji = countkiji + 1;
            }

            //ライオン
            if (timeElapsedLion >= intervalLion && randomValue2 == 1)
            {
                timeElapsedLion = 0.0f;
                Vector3 randamPos = new Vector3(11, Random.Range(3.7f, -2.0f), 0);
                Instantiate(enemyPrefab4, randamPos, Quaternion.identity);
            }

            //チーター
            if (timeElapsedCheetah >= intervalCheetah && randomValue3 == 1)
            {
                timeElapsedCheetah = 0.0f;
                Vector3 randamPos = new Vector3(11, Random.Range(3.7f, -2.0f), 0);
                Instantiate(enemyPrefab5, randamPos, Quaternion.identity);
            }

            //ねこ
            if (timeElapsedCat >= intervalCat && randomValue2 == 2)
            {
                timeElapsedCat = 0.0f;
                Vector3 randamPos = new Vector3(11, Random.Range(3.7f, -2.0f), 0);
                Instantiate(enemyPrefab6, randamPos, Quaternion.identity);
            }

            //くま
            if (timeElapsedBear >= intervalBear && randomValue3 == 2)
            {
                timeElapsedBear = 0.0f;
                Vector3 randamPos = new Vector3(11, Random.Range(3.7f, -2.0f), 0);
                Instantiate(enemyPrefab7, randamPos, Quaternion.identity);
            }

            //ヘビ
            if (timeElapsedSnake >= intervalSnake && randomValue2 == 3)
            {
                timeElapsedSnake = 0.0f;
                Vector3 randamPos = new Vector3(11, Random.Range(3.7f, -2.0f), 0);
                Instantiate(enemyPrefab8, randamPos, Quaternion.identity);
            }

            //ばあちゃん
            if (timeElapsedGrandmother >= intervalGrandmother && randomValue4 == 1)
            {
                timeElapsedGrandmother = 0.0f;
                Vector3 randamPos = new Vector3(11, Random.Range(3.7f, -2.0f), 0);
                Instantiate(enemyPrefab9, randamPos, Quaternion.identity);
            }

        }

    }
}
