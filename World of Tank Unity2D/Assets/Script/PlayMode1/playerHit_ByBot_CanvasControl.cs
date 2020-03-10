using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerHit_ByBot_CanvasControl : MonoBehaviour
{
    public Slider Player_Health;
    public GameResults gr;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "FireBall")
        {
            Player_Health.value -= 1;
        }

        if (Player_Health.value <= 0)
        {
            gr.PlayerWon("AI-Bot");
            Destroy(gameObject);
        }
    }
}
