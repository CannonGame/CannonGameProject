using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldCollision : MonoBehaviour
{
    // Fields
    public static bool shield = false;
    float timer = 0.5f;
    float delay = 0.5f;

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
        //Debug.Log("Blocked");
        shield = true;
        timer = delay;
    }
}
