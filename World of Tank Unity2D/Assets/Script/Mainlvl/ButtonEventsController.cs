using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonEventsController : MonoBehaviour
{
    public Canvas playmode_Canvas;

    public void PlayBTN()
    {
        playmode_Canvas.enabled = true;
    }

    public void QuitBTN()
    {
        Application.Quit();
    }

    public void PlayMode2BTN()
    {
        SceneManager.LoadScene("PlayMode2");
    }

    public void PlayMode1BTN()
    {
        SceneManager.LoadScene("PlayMode1");
    }

    public void CloseBTN()
    {
        playmode_Canvas.enabled = false;
    }

}
