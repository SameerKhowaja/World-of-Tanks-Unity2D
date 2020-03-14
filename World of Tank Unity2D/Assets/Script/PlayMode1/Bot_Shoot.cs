using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot_Shoot : MonoBehaviour
{
    public Transform firePoint;
    public GameObject firePrefab;

    public Bot_Rotate bot_RotateScript;
    public AudioSource fireSound;

    public float fireForce;
    float fireTime = 0.2f;

    void Update()
    {
        fireTime -= Time.fixedDeltaTime;
        if(fireTime <= 0)
        {
            fireSound.Play();
            GameObject fireBall = Instantiate(firePrefab, firePoint.position, Quaternion.identity);
            Rigidbody2D rb = fireBall.GetComponent<Rigidbody2D>();
            rb.AddForce(firePoint.up * fireForce, ForceMode2D.Impulse);
            bot_RotateScript.rotateSpeed *= -1; //Reverse Spin
            fireTime = Random.Range(0.2f, 0.4f);
        }

    }
}
