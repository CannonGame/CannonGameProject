﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VictoryText : MonoBehaviour
{
    // Fields 
    Text gameOverText;

    // Start is called before the first frame update
    void Start()
    {
        // Clears the text
        gameOverText = gameObject.GetComponent<Text>();
        gameOverText.text = "";       
        gameOverText.text = "Time: " + GameTimer.endOfGameTimer + System.Environment.NewLine +
                "Waves Count: " + SelectDifficultyButtons.completedWaves + System.Environment.NewLine + 
                "Best Streak: " + ColonyCollision.bestHitStreak;
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}