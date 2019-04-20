using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaveCounter : MonoBehaviour
{
    public Text waveCounter;
    private int currentWave = SelectDifficultyButtons.completedWaves + 1;
    
    // Displays Current Wave
    void Start()
    {
        waveCounter.text = "Wave: " + currentWave;
    }

}
