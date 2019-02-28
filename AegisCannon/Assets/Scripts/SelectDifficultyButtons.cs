using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectDifficultyButtons : MonoBehaviour
{
    // Loads Easy Mode Wave 1.
    public void EasyButton()
    {

        SceneManager.LoadScene("Easy Wave 1");

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
}
