using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class powerUpScript : MonoBehaviour
{
    public float powerTime = 0;
    float initialSpeed, initialSpeed1;
    float initialHealth;

    public Image img;
    public Sprite defaultImg;
    public Sprite health, shield, speed;

    public Slider healthSlider;

    public SpriteRenderer shieldImgRenderer;
    public CapsuleCollider2D shieldCollider;

    public MovePlusRotate SpeedScript;
    public speedFast_PowerUp speedFast;

    private void Start()
    {
        initialSpeed = SpeedScript.moveSpeed;   //for PC
        initialSpeed1 = speedFast.moveSpeed; //for mobile
    }

    private void Update()
    {
        if (powerTime > 0)
        {
            powerTime -= Time.fixedDeltaTime;
        }
        else
        {
            img.sprite = defaultImg;
            shieldImgRenderer.enabled = false;
            shieldCollider.enabled = false;
            SpeedScript.moveSpeed = initialSpeed;
            speedFast.moveSpeed = initialSpeed1;
        }

        if (shieldCollider.enabled == true)
        {
            healthSlider.value = initialHealth;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Powerup")
        {
            int randomPowerUp = Random.Range(0, 3);
            if (randomPowerUp == 0) Health_PowerUp();
            else if (randomPowerUp == 1) Shield_PowerUp();
            else Speed_PowerUp();
        }
    }

    public void Health_PowerUp()
    {
        powerTime = 4f;
        img.sprite = health;
        if (healthSlider.value <= healthSlider.maxValue - 3)
        {
            healthSlider.value += 3;
        }  
        else
        {
            healthSlider.value = 10;
        }
    }

    public void Shield_PowerUp()
    {
        powerTime = 7f;
        initialHealth = healthSlider.value;
        img.sprite = shield;
        shieldImgRenderer.enabled = true;
        shieldCollider.enabled = true;
    }

    public void Speed_PowerUp()
    {
        powerTime = 7f;
        img.sprite = speed;
        SpeedScript.moveSpeed += 2;
        speedFast.moveSpeed += 2;
    }
    
}
