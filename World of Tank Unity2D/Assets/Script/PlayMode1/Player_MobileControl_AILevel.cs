using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_MobileControl_AILevel : MonoBehaviour
{
    public Rigidbody2D playerRB;
    public Transform firePoint;
    public GameObject firePrefab;
    public Slider bulletSlider;

    public speedFast_PowerUp speedScript;
    public AudioSource fireSound;

    public float rotateSpeed;
    public float moveSpeed;
    public float fireForce;

    Vector2 forward;

    bool keyPressedCheck;
    bool rotateWhere;
    bool enableFire;

    void Fire()
    {
        fireSound.Play();
        GameObject fireBall = Instantiate(firePrefab, firePoint.position, Quaternion.identity);
        Rigidbody2D rb = fireBall.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * fireForce, ForceMode2D.Impulse);
    }

    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        moveSpeed = speedScript.moveSpeed;
    }

    void Update()
    {
        //Setting Speed
        moveSpeed = speedScript.moveSpeed;
        //

        //Rotate
        if (keyPressedCheck == false)
        {
            if (rotateWhere == false)
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
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(Input.touchCount - 1);
            Vector3 touch_pos = Camera.main.ScreenToWorldPoint(touch.position);

            if (touch.phase == TouchPhase.Began)
            {
                keyPressedCheck = true;
                //Fire Check
                if (bulletSlider.value < 1)
                {
                    enableFire = false;
                }
                if (bulletSlider.value >= 1)
                {
                    enableFire = true;
                }
                if (enableFire == true)
                {
                    Fire(); //Fire
                    bulletSlider.value -= 1;
                }
                //
            }

            if (touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Stationary)
            {
                playerRB.MovePosition(playerRB.position + forward * moveSpeed * Time.fixedDeltaTime);
                transform.Rotate(0f, 0f, 0f);
            }
            else
            {
                playerRB.MovePosition(playerRB.position + Vector2.zero);
            }

            if (touch.phase == TouchPhase.Ended)
            {
                keyPressedCheck = false;

                //Rotate clock or anticlock
                if (rotateWhere == false) rotateWhere = true;
                else rotateWhere = false;
            }
        }
        //
    }
}
