using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheetah : MonoBehaviour
{
    public GameObject timeUp;

    // Start is called before the first frame update
    void Start()
    {
        timeUp = GameObject.Find("Time");
    }
    private string objName;
    public float cheetahv = 0.15f;

    // Update is called once per frame
    void Update()
    {
        //制限時間内だけ動ける
        if (timeUp.GetComponent<TimeCount>().isTimeUp == false)
        {
            transform.Translate(-cheetahv, 0, 0);

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
            cheetahv = -1.0f;
        }
        //団子が当たったら突進する
        if (objName == "団子(Clone)")
        {
            cheetahv = 1.0f;
        }
        //桃太郎に当たったら消える
        if (objName == "桃太郎")
        {
            Destroy(this.gameObject);
        }
    }
}
