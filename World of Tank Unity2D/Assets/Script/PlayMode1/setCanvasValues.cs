using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setCanvasValues : MonoBehaviour
{
    public Slider Player_Health;
    public Slider Player_FireLimit;
    public Slider Enemy_Health;

    public int MaxBulletLimit;
    public int MaxHealth_Player;
    public int MaxHealth_Enemy;
    float timerate = 2f;

    void Start()
    {
        Player_FireLimit.maxValue = MaxBulletLimit;
        Player_FireLimit.value = Player_FireLimit.maxValue;

        Player_Health.maxValue = MaxHealth_Player;
        Player_Health.value = Player_Health.maxValue;

        Enemy_Health.maxValue = MaxHealth_Enemy;
        Enemy_Health.value = Enemy_Health.maxValue;
    }

    
    void Update()
    {
        if (Player_FireLimit.value < Player_FireLimit.maxValue)
        {
            Player_FireLimit.value += Time.deltaTime / timerate;
        }

    }
}
