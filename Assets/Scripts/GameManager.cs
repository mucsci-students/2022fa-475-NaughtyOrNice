using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Future code for Level Switching
        /*
        if (playerScore == 3)
        {
            if(scene == "PingLevel2" || scene == "PingLevel3")
            {
                SceneManager.LoadScene(scene);
                aiScore = 0;
                playerScore = 0;
            }
            else
            {
                timer.GetComponent<PingTimer>().beatGame = true;
                timer.GetComponent<PingTimer>().WinDisplay();
                aiScore = 0;
                playerScore = 0;
                Time.timeScale = 0.0f;
            }
        }
        if (aiScore == 3)
        {
            SceneManager.LoadScene("MainMenu");
            aiScore = 0;
            playerScore = 0;
        }
        */
    }
}
