using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PulseWave : MonoBehaviour
{
    Animator animator;
    bool animationPlayed = false;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        StartCoroutine(EnergyCheck());
    }

    IEnumerator EnergyCheck()
    {
        if (EnergyBar.currentHealth == EnergyBar.maxHealth && !animationPlayed)
        {
            animationPlayed = true;
            yield return new WaitForSeconds(4);
            animator.Play("PulseWave");
            yield return new WaitForSeconds(.4f);
            animator.enabled = false;
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
        }
    }
}
