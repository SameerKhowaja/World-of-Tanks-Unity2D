using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlusRotate : MonoBehaviour
{
    public Rigidbody2D playerRB;
    public KeyCode keycode;

    public float rotateSpeed;
    public float moveSpeed;

    Vector2 forward;

    bool keyPressedCheck;
    bool rotateWhere;

    private void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        //Rotate
        if(keyPressedCheck == false)
        {
            if(rotateWhere == false)
            {
                transform.Rotate(0f, 0f, rotateSpeed * Time.fixedDeltaTime);
            }
            else
            {
                transform.Rotate(0f, 0f, -rotateSpeed * Time.fixedDeltaTime);
            }
            
        }
        //

        //Movement
        forward = new Vector2(transform.right.x, transform.right.y);
        if (Input.GetKeyDown(keycode))
        {
            keyPressedCheck = true;
        }
        if (Input.GetKey(keycode))
        {
            //playerMove
            playerRB.MovePosition(playerRB.position + forward * moveSpeed * Time.fixedDeltaTime);
            transform.Rotate(0f, 0f, 0f);
        }
        else
        {
            playerRB.MovePosition(playerRB.position + Vector2.zero);
        }
        if (Input.GetKeyUp(keycode))
        {
            keyPressedCheck = false;

            //Rotate clock or anticlock
            if(rotateWhere == false) rotateWhere = true;
            else rotateWhere = false;
        }
        //

    }

}