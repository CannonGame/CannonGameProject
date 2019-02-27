using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Script for Home Screen Button Interactions

public class HomeScreenButtonClicks : MonoBehaviour
{
    // When the Start button is hit, the SelectDifficulty scene is loaded.
    public void StartButtonClick()
    {
        SceneManager.LoadScene("SelectDifficulty");
        //Test with Start Screen until other scenes are ready
        //SceneManager.LoadScene("StartScreen");
    }

    // When the Options button is hit, the Options scene is loaded.
    public void OptionsButtonClick()
    {
        SceneManager.LoadScene("Options");
        //Test with Start Screen until other scenes are ready
        //SceneManager.LoadScene("StartScreen");
    }

    // When the Credits button is hit, the Credits scene is loaded.
    public void CreditsButtonClick()
    {
        SceneManager.LoadScene("Credits");
        //Test with Start Screen until other scenes are ready
        //SceneManager.LoadScene("StartScreen");
    }
}
