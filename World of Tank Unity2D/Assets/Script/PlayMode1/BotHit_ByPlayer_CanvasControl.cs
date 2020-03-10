using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotHit_ByPlayer_CanvasControl : MonoBehaviour
{
    public Slider Enemy_Health;
    public GameResults gr;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "FireBall")
        {
            Enemy_Health.value -= 1;
        }

        if(Enemy_Health.value <= 0)
        {
            gr.PlayerWon("Player");
            Destroy(gameObject);
        }
    }
}
