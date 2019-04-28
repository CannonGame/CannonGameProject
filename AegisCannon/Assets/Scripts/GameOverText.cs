using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverText : MonoBehaviour
{
    // Fields 
    Text gameOverText;

    // Start is called before the first frame update
    void Start()
    {
        // Clears the text
        gameOverText = gameObject.GetComponent<Text>();
        gameOverText.text = "";
        
        // Displays stats
        if(SelectDifficultyButtons.difficultySetting == 4)
        {
            gameOverText.text = "Survived: " + GameTimer.endOfGameTimer + System.Environment.NewLine + 
                "Waves Survived: " + SelectDifficultyButtons.completedWaves + System.Environment.NewLine + "Best Streak: " + ColonyCollision.bestHitStreak;
        }
        else
        {
            gameOverText.text = "Time: " + GameTimer.endOfGameTimer + System.Environment.NewLine + 
                "Waves Count: " + SelectDifficultyButtons.completedWaves + System.Environment.NewLine + "Best Streak: " + ColonyCollision.bestHitStreak;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
