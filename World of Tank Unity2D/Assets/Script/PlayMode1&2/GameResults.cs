using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameResults : MonoBehaviour
{
    public Canvas resultCanvas;
    public Text wonText;

    public fireBalls fb1, fb2;
    public MovePlusRotate pm1, pm2;

    public void PlayerWon(string Winner_Name)
    {
        resultCanvas.enabled = true;
        wonText.text = Winner_Name;
    }

    public void disableMovements()
    {
        pm1.enabled = fb1.enabled = false;
        pm2.enabled = fb2.enabled = false;
    }

    public void RestartBTN()
    {
        SceneManager.LoadScene("PlayMode1");
    }

    public void MainMenuBTN()
    {
        SceneManager.LoadScene("Main");
    }

    public void QuitBTN()
    {
        Application.Quit();
    }
}
