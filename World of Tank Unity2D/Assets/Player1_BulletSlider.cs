using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player1_BulletSlider : MonoBehaviour
{
    public KeyCode keycode;
    public Slider bulletSlider;

    public fireBalls fb;

    void Update()
    {
        if (bulletSlider.value < 1)
        {
            fb.enabled = false;
        }

        if (bulletSlider.value >= 1)
        {
            fb.enabled = true;
        }

        if (Input.GetKeyDown(keycode) && bulletSlider.value >= 1)
        {
            bulletSlider.value -= 1;
        }

    }

}
