using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public GameObject[] panels;
    void Start()
    {
        Time.timeScale = 0f;
    }

    public void gameStart()
    {
        panels[0].SetActive(false);
    }public void gameFreeze()
    {
        Time.timeScale = 0f;
    }
    public void gameContun()
    {
        Time.timeScale = 1f;
    }
    public void gameExit()
    {
        Application.Quit();
    }

    public void gameMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public bool gamePaused = false;

    public void gamepauseTrue()
    {
        gamePaused = true;
    }
    public void gamepauseFalse()
    {
        gamePaused = false;
    }
}
