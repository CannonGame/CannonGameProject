using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PulseWave : MonoBehaviour
{
    Animator animator;
    bool animationPlayed = false;
    AudioSource audio;
    public AudioClip pulse;
    public AudioClip charge;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    // Constantly checks if Energy Shield is at max. If it is, calls coroutine.
    void FixedUpdate()
    {
        StartCoroutine(EnergyCheck());
    }

    //Coroutine to check if energyshield is full and if so, sets animationPlayed bool to true so it will only be called once in FixedUpdate. Calls animations and sounds.
    IEnumerator EnergyCheck()
    {
        if (EnergyBar.currentHealth == EnergyBar.maxHealth && !animationPlayed)
        {
            animationPlayed = true;
            audio = GetComponent<AudioSource>();
            audio.clip = charge;
            audio.Play();
            yield return new WaitForSeconds(4);
            audio = GetComponent<AudioSource>();
            audio.clip = pulse;
            audio.Play();
            animator.Play("PulseWave");
            audio.Play();
            yield return new WaitForSeconds(.4f);
            animator.enabled = false;
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
        }
    }
}
