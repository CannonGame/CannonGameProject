using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SFXSlider : MonoBehaviour
{
    public Slider SFXVolume;
    public AudioSource mySFX;
    public AudioSource mySFX1;
    public AudioSource mySFX2;

    // Update is called once per frame
    void Update()
    {
        mySFX.volume = SFXVolume.value;
        mySFX1.volume = SFXVolume.value;
        mySFX2.volume = SFXVolume.value;
    }
}
