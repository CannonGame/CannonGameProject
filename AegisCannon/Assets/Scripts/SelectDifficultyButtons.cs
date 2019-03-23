﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectDifficultyButtons: MonoBehaviour
{
    // Loads Easy Mode Wave 1. Changes static variables to adjust difficulty.
    public void EasyButton()
    {
        SceneManager.LoadScene("Easy Wave 1");
        EnemyFire.randomMin = 5f;
        EnemyFire.randomMax = 10f;
        EnemyFire.projectileSpeed = 3f;
        EnergyBar.maxHealth = 200f;
        EnergyBar.maxEnergy = 200f;
        EnergyBar.damage = 10f;
        EnergyBar.heal = 10f;
    }

    // Loads Medium Mode Wave 1.
    public void MediumButton()
    {
        SceneManager.LoadScene("Medium Wave 1");
        EnemyFire.randomMin = 4f;
        EnemyFire.randomMax = 8f;
        EnemyFire.projectileSpeed = 4f;
        EnergyBar.maxHealth = 175f;
        EnergyBar.maxEnergy = 175f;
        EnergyBar.damage = 12f;
        EnergyBar.heal = 10f;

    }

    // Loads Hard Mode Wave 1.
    public void HardButton()
    { 
        SceneManager.LoadScene("Hard Wave 1");
        EnemyFire.randomMin = 3f;
        EnemyFire.randomMax = 7f;
        EnemyFire.projectileSpeed = 4.5f;
        EnergyBar.maxHealth = 150f;
        EnergyBar.maxEnergy = 150f;
        EnergyBar.damage = 15f;
        EnergyBar.heal = 10f;
    }

    // Loads Endless Mode Wave 1.
    public void EndlessButton()
    {
        SceneManager.LoadScene("Endless Wave 1");
        EnemyFire.randomMin = 5f;
        EnemyFire.randomMax = 10f;
        EnemyFire.projectileSpeed = 3.5f;
        EnergyBar.maxHealth = 200f;
        EnergyBar.maxEnergy = 200f;
        EnergyBar.damage = 10f;
        EnergyBar.heal = 10f;
    }

    //When Home button is hit it takes you to the home screen
    public void HomeButtonClick()
    {
        SceneManager.LoadScene("HomeScreen");
    }
}
