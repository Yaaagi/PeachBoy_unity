using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public GameObject stopSound;

    // Start is called before the first frame update
    void Start()
    {
        stopSound = GameObject.Find("Audio Source");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickStartButton()
    {
        SceneManager.LoadScene("Start");
        stopSound.GetComponent<BringBGM>().StopSound();
    }
}
