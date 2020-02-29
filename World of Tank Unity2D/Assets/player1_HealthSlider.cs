using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player1_HealthSlider : MonoBehaviour
{
    public Slider Slider_Player1;
    public GameObject blastPrefab;
    public GameResults gr_func;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "FireBall")
        {
            Slider_Player1.value -= 1;
        }
    }

    private void Update()
    {
        if(Slider_Player1.value <= 0)
        {
            GameObject blastEffect = Instantiate(blastPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
            Destroy(blastEffect, 1f);

            gr_func.disableMovements();
            string playerwin = "Player 2";
            gr_func.PlayerWon(playerwin);
        }
    }
}
