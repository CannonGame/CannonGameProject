using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOverButtons : MonoBehaviour
{
    //switch BGM to Game Over Music - DH
    private void Start()
    {
        SwitchBGM.trackSelect = 1;
    }
    // Starts current game over at wave 1.
    public void RetryButton()
    {
        SceneManager.LoadScene("Placeholder");
    }

    // Takes user to HomeScreen Scene.
    public void HomeButton()
    {
        SwitchBGM.trackSelect = 0;
        SceneManager.LoadScene("HomeScreen");
    }

    // Exits game.
    public void ExitButton()
    {
        Application.Quit();
    }
}
