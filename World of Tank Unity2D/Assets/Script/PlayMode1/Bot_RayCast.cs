using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot_RayCast : MonoBehaviour
{
    public float distance;

    public Bot_Movement bot_MovementScript;
    public Bot_Rotate bot_RotateScript;
    public Bot_Shoot bot_ShootScript;

    void Start()
    {
        Physics2D.queriesStartInColliders = false;
    }

    void Update()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.right, distance);
        if (hitInfo.collider != null)
        {
            if (hitInfo.collider.CompareTag("Player") || hitInfo.collider.CompareTag("shield"))
            {
                Debug.DrawLine(transform.position, hitInfo.point, Color.red);
                bot_MovementScript.enabled = true;
                bot_RotateScript.enabled = false;

                // Shooting Permission
                if(bot_MovementScript.AllowToShoot == true) bot_ShootScript.enabled = true;
                else bot_ShootScript.enabled = false;
            }
            else
            {
                Debug.DrawLine(transform.position, transform.position + transform.right * distance, Color.green);
                bot_MovementScript.enabled = false;
                bot_RotateScript.enabled = true;
                bot_ShootScript.enabled = false;
            }
        }
        else
        {
            Debug.DrawLine(transform.position, transform.position + transform.right * distance, Color.green);
            bot_MovementScript.enabled = false;
            bot_RotateScript.enabled = true;
            bot_ShootScript.enabled = false;
        }
    }
}
