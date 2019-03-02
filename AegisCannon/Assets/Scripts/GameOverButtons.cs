using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOverButtons : MonoBehaviour
{
    // Starts current game over at wave 1.
    public void RetryButton()
    {

        SceneManager.LoadScene("Placeholder");

    }

    // Takes user to HomeScreen Scene.
    public void HomeButton()
    {

        SceneManager.LoadScene("HomeScreen");

    }

    // Exits game.
    public void ExitButton()
    {

        Application.Quit();

    }
}
