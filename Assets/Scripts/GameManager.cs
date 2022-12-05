using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject naughty;
    public GameObject nice;
    // Temporary reference to current scene
    public Scene currentScene;
    // Gets the current scene's name
    public string sceneName;

    void Start()
    {
        currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
        naughty = GameObject.FindGameObjectWithTag("naughty");
        nice = GameObject.FindGameObjectWithTag("nice");
    }

    void Update()
    {
        if (naughty == null && nice == null)
        {
            if (sceneName == "LVL1")
            {
                SceneManager.LoadScene("LVL2");
                naughty = GameObject.FindGameObjectWithTag("naughty");
                nice = GameObject.FindGameObjectWithTag("nice");
            }
            else if (sceneName == "LVL2")
            {
                SceneManager.LoadScene("LVL3");
                naughty = GameObject.FindGameObjectWithTag("naughty");
                nice = GameObject.FindGameObjectWithTag("nice");
            }
            else if (sceneName == "LVL3")
            {
                SceneManager.LoadScene("final");
            }
        }
    }
}
