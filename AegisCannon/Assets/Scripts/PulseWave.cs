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
            SelectDifficultyButtons.completedWaves++;

            // Calls new waves of increased difficulty until boss fight is reached

            if (SelectDifficultyButtons.completedWaves != 15 && SelectDifficultyButtons.difficultySetting != 4)
            {
                if (SelectDifficultyButtons.difficultySetting == 1)
                {
                    yield return new WaitForSeconds(1.5f);
                    EnemyFire.randomMin -=  ((float)SelectDifficultyButtons.completedWaves * 0.075f);
                    //Debug.Log(EnemyFire.randomMin);
                    //Debug.Log(SelectDifficultyButtons.difficultySetting);
                    //Debug.Log(SelectDifficultyButtons.completedWaves);
                    EnemyFire.randomMax -= ((float)SelectDifficultyButtons.completedWaves * 0.075f);
                    //Debug.Log(EnemyFire.randomMax);
                    EnemyFire.projectileSpeed = 3f;
                    EnergyBar.currentEnergy = 100f;
                    EnergyBar.maxEnergy = 200f;
                    if (SelectDifficultyButtons.completedWaves > 4)
                    {
                        EnergyBar.currentEnergy = 50f;
                        if (SelectDifficultyButtons.completedWaves > 9)
                        {
                            EnergyBar.currentEnergy = 25f;
                        }
                    }
                    EnergyBar.damage = 20f;
                    EnergyBar.heal = 20f;
                    SceneManager.LoadScene("Easy Wave 1");
                }
                if (SelectDifficultyButtons.difficultySetting == 2)
                {
                    yield return new WaitForSeconds(1.5f);
                    EnemyFire.randomMin -= ((float)SelectDifficultyButtons.completedWaves * 0.085f);
                    //Debug.Log(EnemyFire.randomMin);
                    //Debug.Log(SelectDifficultyButtons.difficultySetting);
                    //Debug.Log(SelectDifficultyButtons.completedWaves);
                    EnemyFire.randomMax -= ((float)SelectDifficultyButtons.completedWaves * 0.085f);
                    //Debug.Log(EnemyFire.randomMax);
                    EnemyFire.projectileSpeed = 3f;
                    EnergyBar.currentEnergy = 50f;
                    EnergyBar.maxEnergy = 200f;
                    if (SelectDifficultyButtons.completedWaves > 4)
                    {
                        EnergyBar.currentEnergy = 25f;
                        if (SelectDifficultyButtons.completedWaves > 9)
                        {
                            EnergyBar.currentEnergy = 0f;
                        }
                    }
                    EnergyBar.damage = 25f;
                    EnergyBar.heal = 25f;
                    SceneManager.LoadScene("Medium Wave 1");
                }
                if (SelectDifficultyButtons.difficultySetting == 3)
                {
                    yield return new WaitForSeconds(1.5f);
                    EnemyFire.randomMin -= ((float)SelectDifficultyButtons.completedWaves * 0.1f);
                    //Debug.Log(EnemyFire.randomMin);
                    //Debug.Log(SelectDifficultyButtons.difficultySetting);
                    //Debug.Log(SelectDifficultyButtons.completedWaves);
                    EnemyFire.randomMax -= ((float)SelectDifficultyButtons.completedWaves * 0.1f);
                    //Debug.Log(EnemyFire.randomMax);
                    EnemyFire.projectileSpeed = 3f;
                    EnergyBar.currentEnergy = 0f;
                    EnergyBar.maxEnergy = 200f;
                    if (SelectDifficultyButtons.completedWaves > 4)
                    {
                        EnergyBar.damage = 30f;
                        EnergyBar.heal = 20f;
                        if (SelectDifficultyButtons.completedWaves > 9)
                        {
                            EnergyBar.damage = 35f;
                            EnergyBar.heal = 15f;
                        }
                    }
                    SceneManager.LoadScene("Hard Wave 1");
                }
            }
            // Boss level
            if (SelectDifficultyButtons.completedWaves >= 15 && SelectDifficultyButtons.difficultySetting != 4)
            {
                // Boss level stuff goes here
            }
            // Endless Waves
            if (SelectDifficultyButtons.difficultySetting == 4)
            {
                yield return new WaitForSeconds(1.5f);
                EnemyFire.randomMin = 1f;
                //Debug.Log(EnemyFire.randomMin);
                //Debug.Log(SelectDifficultyButtons.difficultySetting);
                Debug.Log(SelectDifficultyButtons.completedWaves);
                EnemyFire.randomMax -= ((float)SelectDifficultyButtons.completedWaves * 0.1f);
                if (EnemyFire.randomMax <= 1.5f)
                {
                    EnemyFire.randomMax = 1.5f;
                    EnemyFire.randomMin = 0.5f;
                }
                Debug.Log(EnemyFire.randomMax);
                EnemyFire.projectileSpeed = 3f;
                EnergyBar.currentEnergy = 0f;
                if (SelectDifficultyButtons.completedWaves % 5 == 0)
                {
                    EnergyBar.maxEnergy += 25f;
                }
                Debug.Log(EnergyBar.maxEnergy);
                EnergyBar.damage = 25f;
                EnergyBar.heal = 25f;
                SceneManager.LoadScene("Endless Wave 1");
            }
        }
    }
}
