using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldCollision : MonoBehaviour
{
    // Fields
    public static bool shield = false;
    float timer = 0.25f;
    float delay = 0.25f;
    public static int hitStreak = 0;

    // Update is called once per frame
    void Update()
    {
        //Start timer
        if (shield)
        {
            timer -= Time.deltaTime;
        }

        //Reset timer and shield state
        if (timer <= 0)
        {
            shield = false;
            timer = delay;
        }
    }

    // When enemy bullet collides with shield, the shield is charged.
    void OnTriggerEnter2D(Collider2D col)
    {
        if (EnergyBar.currentHealth > 0)
        {
            //Debug.Log("Blocked");
            shield = true;
            timer = delay;
            hitStreak++;
        }
    }
}
