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
    public AudioSource fireSound;

    public void PlayBTN()
    {
        fireSound.Play();
        playmode_Canvas.enabled = true;
    }

    public void QuitBTN()
    {
        fireSound.Play();
        Application.Quit();
    }

    public void PlayMode2BTN()
    {
        fireSound.Play();
        SceneManager.LoadScene("PlayMode2");
    }

    public void PlayMode1BTN()
    {
        fireSound.Play();
        SceneManager.LoadScene("PlayMode1");
    }

    public void HelpBTN()
    {
        fireSound.Play();
        helpButtonImage.enabled = true;
        helpImage.enabled = true;
        helpBTN.enabled = true;
        Helptext.enabled = true;
    }

    public void CloseHelpBTN()
    {
        fireSound.Play();
        helpButtonImage.enabled = false;
        helpImage.enabled = false;
        helpBTN.enabled = false;
        Helptext.enabled = false;
    }

    public void CloseBTN()
    {
        fireSound.Play();
        playmode_Canvas.enabled = false;
    }

}
