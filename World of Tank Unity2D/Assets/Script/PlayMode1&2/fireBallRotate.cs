using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireBallRotate : MonoBehaviour
{
    public float rotateSpeed;

    private void Update()
    {
        transform.Rotate(0f, 0f, rotateSpeed * Time.fixedDeltaTime);
    }
}
