﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnergyBar : MonoBehaviour
{
    public Slider energyBar;
    public Slider healthBar;
    public static float currentEnergy;
    public static float maxEnergy; 
    public static float damage = 5f;
    public static float heal = 5f;
    public static float currentHealth;
    public static float maxHealth = 100;
    public GameObject energyCircle;

    // Sets max energy and health. Sets current energy and health to max. Adjusts slider according to percentage.
    void Start()
    {
        energyBar.value = CalculateEnergy();
        currentHealth = maxHealth;
        healthBar.value = CalculateHealth();
        energyCircle.SetActive(false);
    }

    // Checks for energy shield level.
    void FixedUpdate()
    {        
        TriggerWin();
        TriggerLoss();
    }

    // Deals damage to energy shield. Does not allow energy shield to go below zero.
    void DamageShield(float damage)
    {
        currentEnergy -= damage;

        if(currentEnergy <= 0)
        {
            currentEnergy = 0;
        }

        energyBar.value = CalculateEnergy();
    }

    // Deals damage to health if there is no energy shield left. Does not allow to go below zero.
    void DamageHealth()
    {
        if (SelectDifficultyButtons.difficultySetting == 1)
        {
            currentHealth -= (maxHealth / 4);
        }
        else if (SelectDifficultyButtons.difficultySetting == 3) 
        {
            currentHealth -= (maxHealth / 2);
        }
        else
        {
            currentHealth -= (maxHealth / 3);
        }

        if (currentHealth <= 0)
        {
            currentHealth = 0;
        }

        healthBar.value = CalculateHealth();
    }

    // Method to heal shield if projectile collides with shield. Does not allow to go over max.
    public void HealShield(float heal)
    {
        currentEnergy += heal;

        if(currentEnergy > maxEnergy)
        {
            currentEnergy = maxEnergy; 
        }

        energyBar.value = CalculateEnergy();
    }

    // Converts the shield into a percentage to adjust the slider according to the percentage left.
    public float CalculateEnergy()
    {
        return currentEnergy / maxEnergy;
    }

    // Converts the health into a percentage to adjust the slider according to the percentage left.
    float CalculateHealth()
    {
        return currentHealth / maxHealth;
    }

    // If collision occurs with the colony damage shield, if no shield left damage health.
    void OnTriggerEnter2D(Collider2D col)
    {
        if(currentEnergy > 0)
        {
            DamageShield(damage);
        }
        else
        {
            DamageHealth();
        }
    }
    // Method to check if energy bar is at max and enables the energy circle if so.
    void TriggerWin()
    {
        if(currentEnergy == maxEnergy)
        {
            energyCircle.SetActive(true);
            GameObject.Find("PlayerShield").transform.localScale = new Vector3(0, 0, 0);
            FindObjectOfType<ShakeBehaviour>().TriggerShake();

        }
    }
    // Method to check if current health drops to zero and calls game over screen if it is
    void TriggerLoss()
    {
        if (currentHealth <= 0)
        {
            if (SelectDifficultyButtons.difficultySetting == 4)
            {
                SceneManager.LoadScene("EndlessOver");
            }
            else
            {
                SceneManager.LoadScene("GameOver");
            }
        }
    }
}
