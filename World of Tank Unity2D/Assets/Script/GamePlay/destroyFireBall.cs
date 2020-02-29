﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyFireBall : MonoBehaviour
{
    public GameObject blastPrefab;

    void Update()
    {
        Destroy(gameObject, 0.5f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "FireBall" || collision.collider.tag == "Player" || collision.collider.tag == "walls" || collision.collider.tag == "bushes" || collision.collider.tag == "stones")
        {
            GameObject blastEffect = Instantiate(blastPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
            Destroy(blastEffect, 0.5f);
        }
    }
}