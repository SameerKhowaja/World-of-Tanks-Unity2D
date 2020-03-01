using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot_FacePlayer : MonoBehaviour
{
    public Transform Player;
    public Rigidbody2D rb;

    float rotateTime;

    private void Update()
    {
        rotateTime -= Time.deltaTime;
        if (rotateTime <= 0)
        {
            //For Angle Changing
            Vector2 lookDir = Player.transform.position - transform.position;
            float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
            rb.rotation = angle;

            rotateTime = 0.5f;
        }

    }
}
