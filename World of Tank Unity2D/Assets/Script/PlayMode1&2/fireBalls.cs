using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireBalls : MonoBehaviour
{
    public Transform firePoint;
    public GameObject firePrefab;
    public KeyCode keycode;

    public float fireForce;

    void Update()
    {
        if (Input.GetKeyDown(keycode))
        {
            GameObject fireBall = Instantiate(firePrefab, firePoint.position, Quaternion.identity);
            Rigidbody2D rb = fireBall.GetComponent<Rigidbody2D>();
            rb.AddForce(firePoint.up * fireForce, ForceMode2D.Impulse);
        }
    }
}
