using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectDifficultyButtons: MonoBehaviour
{
    // Loads Easy Mode Wave 1. Changes static variables to adjust difficulty.
    public void EasyButton()
    {
        SceneManager.LoadScene("Wave 1");
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
    }

    // Loads Hard Mode Wave 1.
    public void HardButton()
    { 
        SceneManager.LoadScene("Hard Wave 1");
    }

    // Loads Endless Mode Wave 1.
    public void EndlessButton()
    {
        SceneManager.LoadScene("Endless Wave 1");
    }

    //When Home button is hit it takes you to the home screen
    public void HomeButtonClick()
    {
        SceneManager.LoadScene("HomeScreen");
    }
}
