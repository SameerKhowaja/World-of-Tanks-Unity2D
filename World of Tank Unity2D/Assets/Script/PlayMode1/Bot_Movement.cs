using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot_Movement : MonoBehaviour
{
    public float speed;
    public float stoppingDistance;
    public float retreatDistance;
    public bool AllowToShoot;

    public Transform Player;
    public Rigidbody2D rb;

    public Bot_Rotate bot_RotateScript;

    private void Update()
    {
        if ((Vector2.Distance(transform.position, Player.transform.position) > stoppingDistance))
        {
            transform.position = Vector2.MoveTowards(transform.position, Player.transform.position, speed * Time.fixedDeltaTime);
            bot_RotateScript.enabled = false;
            AllowToShoot = false;
        }
        else if ((Vector2.Distance(transform.position, Player.transform.position) < stoppingDistance) && (Vector2.Distance(transform.position, Player.transform.position) > retreatDistance))
        {
            transform.position = this.transform.position;   //Be on its same position
            bot_RotateScript.rotateSpeed *= -1; //Reverse Spin
            bot_RotateScript.enabled = true;
            AllowToShoot = true;
        }
    }

}
