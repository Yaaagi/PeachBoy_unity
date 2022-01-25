using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameKiji : MonoBehaviour
{
    public GameObject timeUp;

    public GameObject counter;

    public GameObject soundkiji;

    // Start is called before the first frame update
    void Start()
    {
        timeUp = GameObject.Find("Time");
        counter = GameObject.Find("DogCounter");
        soundkiji = GameObject.Find("Kiji Sound");
    }
    private string objName;
    public float kijiv = 0.05f;
    private float a = 0.0f;

    

    // Update is called once per frame
    void Update()
    {
        //制限時間内だけ動ける
        if (timeUp.GetComponent<TimeCount>().isTimeUp == false)
        {
            transform.Translate(-kijiv, -a, 0);

            if (transform.position.x < -10.0f || transform.position.x > 15.0f || transform.position.y < -15.0f)
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
            kijiv = -1.0f;
        }
        //団子が当たったら下に降りる
        if (objName == "団子(Clone)")
        {
            kijiv = 0f;
            a = 1.0f;
            counter.GetComponent<Counter>().AttendKiji();
            soundkiji.GetComponent<KijiSound>().SoundKiji();
        }
        //桃太郎に当たったら消える
        if (objName == "桃太郎")
        {
            Destroy(this.gameObject);
        }
    }
}
