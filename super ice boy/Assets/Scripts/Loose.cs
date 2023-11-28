using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loose : MonoBehaviour
{
    public GameObject LooseMenu;

    void Start()
    {

    }

    void Update()
    {

    }
    public  void LooseMen()
    {
        LooseMenu.SetActive(true);
        Time.timeScale = 0f;
    }
    public  void CloseLooseMen()
    {
        LooseMenu.SetActive(false);
        Time.timeScale = 1f;
    }
}

