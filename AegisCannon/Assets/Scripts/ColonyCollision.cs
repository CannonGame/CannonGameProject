using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColonyCollision : MonoBehaviour
{
    // Fields
    public Sprite spaceColony;
    public Sprite spaceColonyHit;
    public Sprite shieldCharge;
    float timer = 0.25f;
    float delay = 0.25f;
    public static int bestHitStreak = 0;
    Animator anim;
    bool isHit = false;
    //SFX Object - DH
    SFXscript shieldHit, colonyHit;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        shieldHit = GameObject.FindObjectOfType(typeof(SFXscript)) as SFXscript;
        colonyHit = GameObject.FindObjectOfType(typeof(SFXscript)) as SFXscript;
    }

    // Update is called once per frame
    void Update()
    {
        // If shield is true change colony to turqoise
        if (ShieldCollision.shield)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = shieldCharge;
            anim.Play("ShieldCharge");
            //play SFX - DH
            shieldHit.shieldCollision.Play();
        }

        // When colony changes, start timer
        if(this.gameObject.GetComponent<SpriteRenderer>().sprite == spaceColonyHit || 
            this.gameObject.GetComponent<SpriteRenderer>().sprite == shieldCharge || isHit)
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
        if (EnergyBar.currentHealth > 0)
        {
            //Debug.Log("HIT");
            this.gameObject.GetComponent<SpriteRenderer>().sprite = spaceColonyHit;
            timer = delay;
            anim.Play("ColonyDamage");
            isHit = true;
            Debug.Log("Ship has been hit");
            if (ShieldCollision.hitStreak > bestHitStreak)
            {
                bestHitStreak = ShieldCollision.hitStreak;
            }
            ShieldCollision.hitStreak = 0;
            //play SFX - DH
            colonyHit.PlayBoom3();

        }
    }


}
