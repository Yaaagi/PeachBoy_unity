using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snake : MonoBehaviour
{
    public GameObject timeUp;

    // Start is called before the first frame update
    void Start()
    {
        timeUp = GameObject.Find("Time");
    }
    private string objName;
    public float snakev = 0.02f;

    private float a = 0.05f;
    public int y = 0;
    public int b = 5;

    // Update is called once per frame
    void Update()
    {
        //制限時間内だけ動ける
        if (timeUp.GetComponent<TimeCount>().isTimeUp == false)
        {
            y += b;
            if (y == 80)
            {
                a = -0.05f;
                b = -5;
            }
            if (y == -80)
            {
                a = 0.05f;
                b = 5;
            }
            transform.Translate(-snakev, a, 0);

            if (transform.position.x < -10.0f || transform.position.x > 15.0f)
            {
                Destroy(gameObject);
            }
        }

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        objName = col.gameObject.name;
        //肉が当たったら逃げる
        if (objName == "肉(Clone)")
        {
            snakev = -1.0f;
        }
        //団子が当たったら突進する
        if (objName == "団子(Clone)")
        {
            snakev = 1.0f;
        }
        //桃太郎に当たったら消える
        if (objName == "桃太郎")
        {
            Destroy(this.gameObject);
        }
    }
}
