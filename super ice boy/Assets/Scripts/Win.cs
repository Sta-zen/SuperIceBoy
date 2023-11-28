using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    public GameObject WinMenu;

    void Start()
    {

    }

    void Update()
    {
        if (ScoreScript.scoreValue == 13)
        {
            WinMen();
        }
    }
    public void WinMen()
    {
        WinMenu.SetActive(true);
        Time.timeScale = 0f;
    }
    public void CloseWinMen()
    {
        WinMenu.SetActive(false);
        Time.timeScale = 1f;
    }
}

