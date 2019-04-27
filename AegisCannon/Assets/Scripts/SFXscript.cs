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

    // Start is called before the first frame update
    void Start()
    {

    }


}
