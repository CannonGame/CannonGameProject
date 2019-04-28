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
    public AudioSource mySFX3;
    public AudioSource mySFX4;
    public AudioSource mySFX5;
    public AudioSource mySFX6;
    public string key = "SFX volume";
    public float volume = 1f;

    // Sets volume from player prefs on start.
    void Start()
    {
        SFXVolume.value = PlayerPrefs.GetFloat(key);
    }
    // Update is called once per frame. Updates volume in player prefs
    void Update()
    {
        mySFX.volume = SFXVolume.value;
        mySFX1.volume = SFXVolume.value;
        mySFX2.volume = SFXVolume.value;
        mySFX3.volume = SFXVolume.value;
        mySFX4.volume = SFXVolume.value;
        mySFX5.volume = SFXVolume.value;
        mySFX6.volume = SFXVolume.value;
    }

    // Method to change volume in player prefs
    public void ChangeVolume(float volume)
    {
        volume = this.volume;
        volume = SFXVolume.value;
        PlayerPrefs.SetFloat(key, volume);
        PlayerPrefs.Save();
    }
}
