using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

   public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Settings()
    {
        SceneManager.LoadScene(3);
    }

    public void MoreOptions()
    {
        SceneManager.LoadScene(4);
    }

    public void Controlls()
    {
        SceneManager.LoadScene(2);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Nextbutton()
    {
        SceneManager.LoadScene(5);
    }

    public void NextButtonagain()
    {
        SceneManager.LoadScene(6);

    }

    public void Spritesbyme()
    {
        SceneManager.LoadScene(7);
    }

    public void UnusedSprites()
    {
        SceneManager.LoadScene(8);
    }
}
