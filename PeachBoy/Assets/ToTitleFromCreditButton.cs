using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ToTitleFromCreditButton : MonoBehaviour
{
    public GameObject stopSound2;

    // Start is called before the first frame update
    void Start()
    {
        stopSound2 = GameObject.Find("Audio Source");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ClickStartButton()
    {
        SceneManager.LoadScene("PeachBoy_Title");
        stopSound2.GetComponent<BringBGM3>().StopMainSound2();
    }
}
