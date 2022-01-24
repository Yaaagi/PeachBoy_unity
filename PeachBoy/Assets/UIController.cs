using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    
    GameObject gameOverText;
    GameObject gameFinishText;
    GameObject gameOverMenu;

    


    public void GameOver()
    {
        this.gameOverText.GetComponent<Text>().text = "GameOver";
    }

    public void GameFinish ()
    {
        this.gameFinishText.GetComponent<Text>().text = "GameFinish";
    }
    public void GameOverMenu ()
    {
        gameOverMenu.SetActive(true);
    }

    

    // Start is called before the first frame update
    void Start()
    {
        this.gameOverText = GameObject.Find("GameOver");
        this.gameFinishText = GameObject.Find("GameFinish");
        this.gameOverMenu = GameObject.Find("Panel (1)");

        gameOverMenu.SetActive(false);
        
    }
    

    // Update is called once per frame
    void Update()
    {
        

    }
}
