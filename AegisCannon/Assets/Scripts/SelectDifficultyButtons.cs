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

        //FindObjectOfType<AudioManager>().Play("Button Sound");
    }

    // Loads Medium Mode Wave 1.
    public void MediumButton()
    {
        SceneManager.LoadScene("Medium Wave 1");

        //FindObjectOfType<AudioManager>().Play("Button Sound");
    }

    // Loads Hard Mode Wave 1.
    public void HardButton()
    { 
        SceneManager.LoadScene("Hard Wave 1");

       // FindObjectOfType<AudioManager>().Play("Button Sound");
    }

    // Loads Endless Mode Wave 1.
    public void EndlessButton()
    {
        SceneManager.LoadScene("Endless Wave 1");

        //FindObjectOfType<AudioManager>().Play("Button Sound");
    }

    //When Home button is hit it takes you to the home screen
    public void HomeButtonClick()
    {
        SceneManager.LoadScene("HomeScreen");

        //FindObjectOfType<AudioManager>().Play("Button Sound");
    }
}
