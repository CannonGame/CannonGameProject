using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SFXscript : MonoBehaviour
{
    //audio objects
    public AudioSource enemyFire, lowHealth, boom1, boom2, boom3, shieldCollision, shieldCharged;

    //Shot sfx
    public void PlayEnemyFire()
    {
        enemyFire.Play();
    }

    public void PlayLowHealth()
    {
        lowHealth.Play();
    }

    public void PlayBoom1()
    {
        boom1.Play();
    }

    public void PlayBoom2()
    {
        boom2.Play();
    }
    public void PlayBoom3()
    {
        boom3.Play();
    }
    public void PlayShieldCollision()
    {
        shieldCollision.Play();
    }
    public void PlayShieldCharge()
    {
        shieldCharged.Play();
    }

    // Start is called before the first frame update. Gets volume for audio files from player prefs
    void Start()
    {
        enemyFire.volume = PlayerPrefs.GetFloat("SFX volume");
        lowHealth.volume = PlayerPrefs.GetFloat("SFX volume");
        boom1.volume = PlayerPrefs.GetFloat("SFX volume");
        boom2.volume = PlayerPrefs.GetFloat("SFX volume");
        boom3.volume = PlayerPrefs.GetFloat("SFX volume");
        shieldCollision.volume = PlayerPrefs.GetFloat("SFX volume");
        shieldCharged.volume = PlayerPrefs.GetFloat("SFX volume");
        Debug.Log(PlayerPrefs.GetFloat("SFX volume"));
    }

    // Update is called once per frame. Updates volume in player prefs
    void Update()
    {
        enemyFire.volume = PlayerPrefs.GetFloat("SFX volume");
        lowHealth.volume = PlayerPrefs.GetFloat("SFX volume");
        boom1.volume = PlayerPrefs.GetFloat("SFX volume");
        boom2.volume = PlayerPrefs.GetFloat("SFX volume");
        boom3.volume = PlayerPrefs.GetFloat("SFX volume");
        shieldCollision.volume = PlayerPrefs.GetFloat("SFX volume");
        shieldCharged.volume = PlayerPrefs.GetFloat("SFX volume");
        Debug.Log(PlayerPrefs.GetFloat("SFX volume"));
    }


}
