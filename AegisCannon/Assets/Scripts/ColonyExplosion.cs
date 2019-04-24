using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColonyExplosion : MonoBehaviour
{
    // Fields
    private Animator anim;
    public static bool playAnimation = false;

    // Start is called before the first frame update. Gets Animator Component and Starts infinite Coroutine to make enemies fire.
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // Runs animation if Colony health reaches zero and animation has not played
        if (EnergyBar.currentHealth <= 0)
        {
            playAnimation = true;
            if (playAnimation)
            {
                //anim.SetTrigger("Destroy");
                playAnimation = false;
                anim.Play("ColonyExplosion");

            }
        }
    }
}