using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColonyCollision : MonoBehaviour
{
    // Fields
    public Sprite spaceColony;
    public Sprite spaceColonyHit;
    public Sprite shieldCharge;
    float timer = 0.5f;
    float delay = 0.5f;

    // Update is called once per frame
    void Update()
    {
        // If shield is true change colony to turqoise
        if (ShieldCollision.GetShield())
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = shieldCharge;
        }

        // When colony changes, start timer
        if(this.gameObject.GetComponent<SpriteRenderer>().sprite == spaceColonyHit || 
            this.gameObject.GetComponent<SpriteRenderer>().sprite == shieldCharge)
        {
            timer -= Time.deltaTime;
        }

        // When timer is less than or equal to zero, change colony back
        if(timer <= 0)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = spaceColony;
            timer = delay;
        }
    }

    //When an enemy bullet collides with colony, health is lost and colony flashes red.
    void OnTriggerEnter2D(Collider2D col)
    {
        //Debug.Log("HIT");
        this.gameObject.GetComponent<SpriteRenderer>().sprite = spaceColonyHit;
        timer = delay;
    }


}
