using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    public Text gameTimerText;
    float gameTimer=0f;



    //Makes timer persist through scenes.
    public void Awake()
    {
        DontDestroyOnLoad(this);

        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }
    }

    //Creates Timer
    void Update(){
        gameTimer += Time.deltaTime;

        // Creates variables for seconds, minutes and hours
        int seconds = (int)(gameTimer % 60);
        int minutes = (int)(gameTimer / 60) % 60;
        int hours = (int)(gameTimer / 3600) % 24;

        // Formats timer to hours : minutes : seconds
        string timerString = string.Format("{0:0}:{1:00}:{2:00}", hours, minutes, seconds);
        gameTimerText.text = timerString;
    }
}
