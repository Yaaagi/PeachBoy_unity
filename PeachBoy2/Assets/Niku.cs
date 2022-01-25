using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Niku : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private string objName;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0.2f, 0, 0);

        if (transform.position.x > 10.0f)
        {
            Destroy(gameObject);
        }

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        objName = col.gameObject.name;
        if (objName != "桃太郎")
        {
            Destroy(this.gameObject);
        }
    }

    
}
