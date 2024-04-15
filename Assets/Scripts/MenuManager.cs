using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    public void StartNew()
    {
        SceneManager.LoadScene(9);
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

    public void One()
    { 
        SceneManager.LoadScene(10);
    }

    public void two()
    {
        SceneManager.LoadScene(11);
    }

    public void three()
    {
        SceneManager.LoadScene(12);
    }

    public void four()
    {
        SceneManager.LoadScene(13);
    }

    public void five()
    {
        SceneManager.LoadScene(14);
    }

    public void six()
    {
        SceneManager.LoadScene(15);
    }

    public void seven()
    { 
        SceneManager.LoadScene(16);
    }

    public void eight()
    {
        SceneManager.LoadScene(17);
    }

    public void nine()
    { 
        SceneManager.LoadScene(18);
    }

    public void ten()
    {
        SceneManager.LoadScene(19);
    }

    public void eleven()
    { 
        SceneManager.LoadScene(20);
    }

    public void twelve()
    {
        SceneManager.LoadScene(21);
    }

    public void thirteen()
    {
        SceneManager.LoadScene(22);
    }

   public void fourteen()
    {
        SceneManager.LoadScene(23);
    }

    public void fifteen()
    {
        SceneManager.LoadScene(1);
    }
}
