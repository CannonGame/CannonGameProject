using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Blink : MonoBehaviour
{

    // UI Element To Toggle
    public MaskableGraphic imageToToggle;

    public float interval = 1f;
    public float startDelay = 0.5f;
    public bool currentState = true;
    public bool defaultState = true;
    bool isBlinking = false;


    void Start()
    {
        imageToToggle.enabled = defaultState;
        StartBlink();
    }

    // Method to make button blink.
    public void StartBlink()
    {
        
        if (isBlinking)
            return;

        if (imageToToggle != null)
        {
            isBlinking = true;
            InvokeRepeating("ToggleState", startDelay, interval);
        }

    }

    public void ToggleState()
    {
        imageToToggle.enabled = !imageToToggle.enabled;

    }

}
