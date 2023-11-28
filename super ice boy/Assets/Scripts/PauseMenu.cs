using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public Win Win;
    private void Awake()
    {
        Win = GetComponent<Win>();
    }
    public Loose Loose;
    private void Awake2()
    {
        Loose = GetComponent<Loose>();
    }

    public bool PauseGame;
    public GameObject Pause;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            if (PauseGame)
            {
                Resume();
            }
            else
            {
                MenuPause();
            }
    }

    public void Resume()
    {
        Pause.SetActive(false);
        Time.timeScale = 1f;
        PauseGame = false;
    }

    public void MenuPause()
    {
        Pause.SetActive(true);
        Time.timeScale = 0f;
        PauseGame = true;
    }
    public void LoadMenu()
    {
        ScoreScript.scoreValue = 0;
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
        Loose.CloseLooseMen();
        Win.CloseWinMen();
    }
    public void RestartLevel()
    {
        ScoreScript.scoreValue = 0;
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
    }
}

