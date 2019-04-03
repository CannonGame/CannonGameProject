using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectDifficultyButtons : MonoBehaviour
{
    // Fields
    public static int difficultySetting = 0;
    public static int completedWaves;

    // Loads Easy Mode Wave 1. Changes static variables to adjust difficulty.
    public void EasyButton()
    {
        difficultySetting = 1;
        completedWaves = 0;
        SceneManager.LoadScene("Easy Wave 1");
        EnemyFire.randomMin = 6f;
        EnemyFire.randomMax = 10f;
        EnemyFire.projectileSpeed = 3f;
        EnergyBar.currentEnergy = 100f;
        EnergyBar.maxEnergy = 200f;
        EnergyBar.damage = 10f;
        EnergyBar.heal = 50f;
    }

    // Loads Medium Mode Wave 1.
    public void MediumButton()
    {
        difficultySetting = 2;
        completedWaves = 0;
        SceneManager.LoadScene("Medium Wave 1");
        EnemyFire.randomMin = 2f;
        EnemyFire.randomMax = 5f;
        EnemyFire.projectileSpeed = 4f;
        EnergyBar.maxEnergy = 175f;
        EnergyBar.currentEnergy = 44f;
        EnergyBar.damage = 12f;
        EnergyBar.heal = 10f;

    }

    // Loads Hard Mode Wave 1.
    public void HardButton()
    {
        difficultySetting = 3;
        completedWaves = 0;
        SceneManager.LoadScene("Hard Wave 1");
        EnemyFire.randomMin = 1f;
        EnemyFire.randomMax = 4f;
        EnemyFire.projectileSpeed = 4.5f;
        EnergyBar.currentEnergy = 0f;
        EnergyBar.maxEnergy = 150f;
        EnergyBar.damage = 15f;
        EnergyBar.heal = 10f;
    }

    // Loads Endless Mode Wave 1.
    public void EndlessButton()
    {
        difficultySetting = 4;
        completedWaves = 0;
        SceneManager.LoadScene("Endless Wave 1");
        EnemyFire.randomMin = 2f;
        EnemyFire.randomMax = 6f;
        EnemyFire.projectileSpeed = 3.5f;
        EnergyBar.currentEnergy = 0f;
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
