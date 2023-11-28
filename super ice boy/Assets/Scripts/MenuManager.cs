using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject LevelChoosing;
    public void Level_1()
    {
        SceneManager.LoadScene("Level_1");
    }
    public void ExitGane()
    {
        Application.Quit();
    }
    public void Choosing()
    {
        LevelChoosing.SetActive(true);
    }
    public void Back()
    {
        LevelChoosing.SetActive(false);
    }
}
