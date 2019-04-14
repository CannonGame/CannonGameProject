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

    // Update is called once per frame
    void Update()
    {
        myMusic.volume = musicVolume.value;
        myMusic1.volume = musicVolume.value;
        myMusic2.volume = musicVolume.value;
    }
}
