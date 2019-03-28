using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
    public static float maxHealth;

    // Sets max energy and health. Sets current energy and health to max. Adjusts slider according to percentage.
    void Start()
    {
        energyBar.value = CalculateEnergy();
        currentHealth = maxHealth;
        healthBar.value = CalculateHealth();
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
    void DamageHealth(float damage)
    {
        currentHealth -= damage;

        if(currentHealth <= 0)
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
            DamageHealth(damage);
        }
    }
}
