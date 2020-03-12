using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy_powerupTime : MonoBehaviour
{
    float destroyTime = 10f;

    void Update()
    {
        destroyTime -= Time.fixedDeltaTime;
        if(destroyTime <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
