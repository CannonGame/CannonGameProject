using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectDifficultyButtons: MonoBehaviour
{
    // Loads Easy Mode Wave 1. Changes static variables to adjust difficulty.
    public void EasyButton()
    {
        //added line to change active song. -DH
        SwitchBGM.trackSelect = 2;
        SceneManager.LoadScene("Easy Wave 1");
        EnemyFire.randomMin = 5f;
        EnemyFire.randomMax = 10f;
        EnemyFire.projectileSpeed = 3f;
        EnergyBar.maxHealth = 200f;
        EnergyBar.currentEnergy = 100f;
        EnergyBar.maxEnergy = 200f;
        EnergyBar.damage = 10f;
        EnergyBar.heal = 100f;
        
    }

    // Loads Medium Mode Wave 1.
    public void MediumButton()
    {
        //same deal here.
        SwitchBGM.trackSelect = 2;
        SceneManager.LoadScene("Medium Wave 1");
        EnemyFire.randomMin = 4f;
        EnemyFire.randomMax = 8f;
        EnemyFire.projectileSpeed = 4f;
        EnergyBar.maxHealth = 175f;
        EnergyBar.maxEnergy = 175f;
        EnergyBar.currentEnergy = 44f;
        EnergyBar.damage = 12f;
        EnergyBar.heal = 10f;
        
    }

    // Loads Hard Mode Wave 1.
    public void HardButton()
    {
        SwitchBGM.trackSelect = 2;
        SceneManager.LoadScene("Hard Wave 1");
        EnemyFire.randomMin = 3f;
        EnemyFire.randomMax = 7f;
        EnemyFire.projectileSpeed = 4.5f;
        EnergyBar.maxHealth = 150f;
        EnergyBar.currentEnergy = 0f;
        EnergyBar.maxEnergy = 150f;
        EnergyBar.damage = 15f;
        EnergyBar.heal = 10f;
    }

    // Loads Endless Mode Wave 1.
    public void EndlessButton()
    {
        SwitchBGM.trackSelect = 2;
        SceneManager.LoadScene("Endless Wave 1");
        EnemyFire.randomMin = 5f;
        EnemyFire.randomMax = 10f;
        EnemyFire.projectileSpeed = 3.5f;
        EnergyBar.maxHealth = 200f;
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
