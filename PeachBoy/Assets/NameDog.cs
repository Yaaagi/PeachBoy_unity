using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameDog : MonoBehaviour
{
    public GameObject timeUp;

    public GameObject counter;

    public GameObject sounddog;


    // Start is called before the first frame update
    void Start()
    {
        timeUp = GameObject.Find("Time");
        counter = GameObject.Find("DogCounter");
        sounddog = GameObject.Find("Dog Sound");
    }
    private string objName;
    public float dogv = 0.05f;
    private float a = 0.0f;


    

    // Update is called once per frame
    void Update()
    {
        //制限時間内だけ動ける
        if (timeUp.GetComponent<TimeCount>().isTimeUp == false)
        {
            transform.Translate(-dogv, -a, 0);

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
            dogv = -1.0f;
        }
        //団子が当たったら下に降りる
        if (objName == "団子(Clone)")
        {
            dogv = 0f;
            a = 1.0f;
            counter.GetComponent<Counter>().AttendDog();
            sounddog.GetComponent<DogSound>().SoundDog();
        }
        //桃太郎に当たったら消える
        if (objName == "桃太郎")
        {
            Destroy(this.gameObject);
        }
    }
}
