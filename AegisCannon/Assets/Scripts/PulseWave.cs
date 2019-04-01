using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PulseWave : MonoBehaviour
{
    // Fields
    private Animator animator;
    bool animationPlayed = false;
    private AudioSource audio;
    public AudioClip pulse;
    public AudioClip charge;
    public int completedWaves = 0;

    public Animator Animator { get => animator; set => animator = value; }
    public AudioSource Audio { get => audio; set => audio = value; }

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
            Audio = GetComponent<AudioSource>();
            Audio.clip = charge;
            Audio.Play();
            yield return new WaitForSeconds(4);
            Audio = GetComponent<AudioSource>();
            Audio.clip = pulse;
            Audio.Play();
            animator.Play("PulseWave");
            Audio.Play();
            yield return new WaitForSeconds(.4f);
            animator.enabled = false;
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            completedWaves += 1;

            if (completedWaves != 15)
            {
                yield return new WaitForSeconds(1.5f);
                SceneManager.LoadScene("Easy Wave 1");
                EnemyFire.randomMin = 3f;
                EnemyFire.randomMax = 6f;
                EnemyFire.projectileSpeed = 3f;
                EnergyBar.currentEnergy = 100f;
                EnergyBar.maxEnergy = 200f;
                EnergyBar.damage = 10f;
                EnergyBar.heal = 100f;
            }
        }
    }
}
