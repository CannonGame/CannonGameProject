using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Internal;

public class BestTimeScript : MonoBehaviour
{
    // Variables created
    public Text timerText;
    public Text bestTime;
    private float startTime;
    private bool finished = false;

    // Creates and displays best time
    void GameFinished()
    {
        float t = Time.time - startTime;
        if (t < PlayerPrefs.GetFloat ("Best Time", float.MaxValue))
        {
            PlayerPrefs.SetFloat("Best Time", t);
            bestTime.text = t.ToString();
            PlayerPrefs.Save();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        bestTime.text = PlayerPrefs.GetFloat("Best Time", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        // Timer
        float t = Time.time - startTime;
        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");
        timerText.text = minutes + ":" + seconds;
        
        // Checks to see if the player finished the game
        GameFinished();
    }
}
