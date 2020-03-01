using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setBulletLimit : MonoBehaviour
{
    public int MaxBulletLimit;
    public Slider s1, s2;

    float timerate = 4f;

    void Start()
    {
        s1.maxValue = MaxBulletLimit;
        s1.value = s1.maxValue;

        s2.maxValue = MaxBulletLimit;
        s2.value = s2.maxValue;
    }

    void Update()
    {
        if (s1.value < s1.maxValue)
        {
            s1.value += Time.deltaTime / timerate;
        }

        if (s2.value < s2.maxValue)
        {
            s2.value += Time.deltaTime / timerate;
        }
    }

}
