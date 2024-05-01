using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pausemenu : MonoBehaviour
{

    [SerializeField] GameObject pauseMenu;
    bool isPaused = false;

    public GameObject mobileControlls;

    private void Start()
    {
        isPaused = false;
    }

    private void Update()
    {
        if (isPaused == true)
        {
            mobileControlls.SetActive(false);
        }
        else
        {
            mobileControlls.SetActive(true);
        }
    }

    public void Pause()
    {
        isPaused = true;
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        isPaused = false;
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void backtoMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void restart()
    {
        isPaused = true;
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }
}
