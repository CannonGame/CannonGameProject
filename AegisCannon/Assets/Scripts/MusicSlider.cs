using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicSlider : MonoBehaviour
{
    //Creates objects
    public Slider musicVolume;
    public AudioSource myMusic;
    public AudioSource myMusic1;
    public AudioSource myMusic2;
    public float volume = 1f;

    // Sets Volume from PlayerPrefs on Start
    void Start()
    {
        musicVolume.value = PlayerPrefs.GetFloat("Music Volume");
    }
    // Update is called once per frame Sets Music Volume from saved PlayerPrefs
    void Update()
    {
        myMusic.volume = musicVolume.value;
        myMusic1.volume = musicVolume.value;
        myMusic2.volume = musicVolume.value;
    }

    //Method to update volume with music slider
    public void ChangeMusicVolume(float volume)
    {
        volume = this.volume;
        volume = musicVolume.value;
        PlayerPrefs.SetFloat("Music Volume", volume);
        PlayerPrefs.Save();
    }
}
