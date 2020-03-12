using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPowerups : MonoBehaviour
{
    public GameObject powerupPrefab;
    public Transform[] points;

    float startTime = 15f;

    private void Update()
    {
        startTime -= Time.fixedDeltaTime;
        if(startTime <= 0)
        {
            int randomPoint = Random.Range(0, points.Length);
            Instantiate(powerupPrefab, points[randomPoint].position, Quaternion.identity);
            startTime += 15;
        }
    }
}
