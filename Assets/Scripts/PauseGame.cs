using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class PauseGame : MonoBehaviour
{
    public static bool paused = false;
    public GameObject pauseMenu;
    public FirstPersonController FPC;

    void Start()
    {
        paused = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (paused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        AudioListener.pause = false;
        pauseMenu.SetActive(false);
        Time.timeScale = 1.0f;
        FPC.ChangeSensitivity(2.0f, 2.0f);
        FPC.ToggleCursor(true);
        paused = false;
    }

    void Pause()
    {
        AudioListener.pause = true;
        pauseMenu.SetActive(true);
        Time.timeScale = 0.0f;
        FPC.ChangeSensitivity(0.0f, 0.0f);
        FPC.ToggleCursor(false);
        paused = true;
    }

    public void LoadMenu()
    {
        AudioListener.pause = false;
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
