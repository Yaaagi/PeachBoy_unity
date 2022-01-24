using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public static int dogCount1;
    public static int monkeyCount1;
    public static int kijiCount1;


    public void AttendDog()
    {
        dogCount1 += 1; 
    }

    public void AttendMonkey()
    {
        monkeyCount1 += 1;
    }

    public void AttendKiji()
    {
        kijiCount1 += 1;
    }

    // Start is called before the first frame update
    void Start()
    {      
        dogCount1 = 0;
        monkeyCount1 = 0;
        kijiCount1 = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
