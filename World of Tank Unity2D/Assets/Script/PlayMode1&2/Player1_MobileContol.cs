using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player1_MobileContol : MonoBehaviour
{
    public Transform playerPos;
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
    bool AllowToMove;

    void Fire()
    {
        fireSound.Play();
        GameObject fireBall = Instantiate(firePrefab, firePoint.position, Quaternion.identity);
        Rigidbody2D rb = fireBall.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * fireForce, ForceMode2D.Impulse);
    }

    public void onPressBTN()
    {
        AllowToMove = true;
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

    public void onReleaseBTN()
    {
        AllowToMove = false;
        playerRB.MovePosition(playerRB.position + Vector2.zero);
        keyPressedCheck = false;

        //Rotate clock or anticlock
        if (rotateWhere == false) rotateWhere = true;
        else rotateWhere = false;
    }

    void Start()
    {
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
                playerPos.transform.Rotate(0f, 0f, rotateSpeed * Time.fixedDeltaTime);
            else
                playerPos.transform.Rotate(0f, 0f, -rotateSpeed * Time.fixedDeltaTime);
        }
        //
        
        //Movement
        forward = new Vector2(playerPos.transform.right.x, playerPos.transform.right.y);
        //
        if(AllowToMove == true)
        {
            playerRB.MovePosition(playerRB.position + forward * moveSpeed * Time.fixedDeltaTime);
            playerPos.transform.Rotate(0f, 0f, 0f);
        }
        else
        {
            playerRB.MovePosition(playerRB.position + Vector2.zero);
        }
    }
}
