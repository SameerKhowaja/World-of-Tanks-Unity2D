using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonEventsController : MonoBehaviour
{
    public Canvas playmode_Canvas;
    public Image helpImage, helpButtonImage;
    public Button helpBTN;
    public Text Helptext;

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

    public void HelpBTN()
    {
        helpButtonImage.enabled = true;
        helpImage.enabled = true;
        helpBTN.enabled = true;
        Helptext.enabled = true;
    }

    public void CloseHelpBTN()
    {
        helpButtonImage.enabled = false;
        helpImage.enabled = false;
        helpBTN.enabled = false;
        Helptext.enabled = false;
    }

    public void CloseBTN()
    {
        playmode_Canvas.enabled = false;
    }

}
