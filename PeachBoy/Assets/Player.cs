using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject dango;
    public GameObject niku;
    private string objName;

    private Vector2 playerPos;

    public GameObject timeUp;

    public static int playerhp;

    
    public static int monkeyCount1;
    public static int kijiCount1;




    // Start is called before the first frame update
    void Start()
    {
        timeUp = GameObject.Find("Time");
        playerhp = 5;

        monkeyCount1 = 0;
        kijiCount1 = 0;
    }
    

    // 配列の定義（「複数のデータ」を入れることのできる「仕切り」付きの箱を作る）
    public GameObject[] playerIcons;
    public int destroyCount = 0;


    // Update is called once per frame
    void Update()
    {
        //制限時間内だけ動ける
        if (timeUp.GetComponent<TimeCount>().isTimeUp == false)
        {
            if (Input.GetKey("down"))
            {
                transform.Translate(0, -0.08f, 0);
                // 移動制限処理
                this.MovingRestrictions();
            }
            if (Input.GetKey("up"))
            {
                transform.Translate(0, 0.08f, 0);
                // 移動制限処理
                this.MovingRestrictions();
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(dango, transform.position, Quaternion.identity);
            }
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                Instantiate(niku, transform.position, Quaternion.identity);
            }
        }
        if (playerhp == 0)
        {
            GameObject.Find("Canvas").GetComponent<UIController>().GameOver();
            Destroy(gameObject);
            GameObject.Find("Canvas").GetComponent<UIController>().GameOverMenu();
            
        }
        if (timeUp.GetComponent<TimeCount>().isTimeUp == true)
        {
            GameObject.Find("Canvas").GetComponent<UIController>().GameFinish();
        }

    }

    //移動範囲の制限
    private void MovingRestrictions()
    {
        //変数に自分の今の位置を入れる
        this.playerPos = transform.position;

        //playerPos変数のxとyに制限した値を入れる
        //playerPos.xという値を-playerPosXClamp～playerPosXClampの間に収める
        this.playerPos.y = Mathf.Clamp(this.playerPos.y, -2.0f, 3.7f);

        transform.position = new Vector2(this.playerPos.x, this.playerPos.y);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        objName = col.gameObject.name;
        if (objName != "団子(Clone)" && objName != "肉(Clone)")
        {
            if (objName == "ばあちゃん(Clone)")
            {
                if (playerhp < 5)
                {
                    playerhp += 1;
                    destroyCount -= 1;

                    UpdatePlayerIcons();

                }

            }
            else
            {
                playerhp -= 1;
                destroyCount += 1;

                UpdatePlayerIcons();

            }
        }
    }

    void UpdatePlayerIcons()
    {
        // for文（繰り返し文）・・・まずは基本形を覚えましょう！
        for (int i = 0; i < playerIcons.Length; i++)
        {
            if (destroyCount <= i)
            {
                playerIcons[i].SetActive(true);
            }
            else
            {
                playerIcons[i].SetActive(false);
            }
        }
    }

}
