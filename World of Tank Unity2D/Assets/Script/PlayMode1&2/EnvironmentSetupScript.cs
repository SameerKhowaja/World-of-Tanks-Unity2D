using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentSetupScript : MonoBehaviour
{
    public Transform[] Points;
    public GameObject[] objectsPrefabs;

    int RandomObjectChoose;

    private void Start()
    {
        for (int i=0; i<Points.Length; i++)
        {
            RandomObjectChoose = Random.Range(0, objectsPrefabs.Length);
            Instantiate(objectsPrefabs[RandomObjectChoose], Points[i].position, Quaternion.identity);
        }
    }
}
