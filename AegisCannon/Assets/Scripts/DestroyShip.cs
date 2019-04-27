using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyShip : MonoBehaviour
{
    Animator animator;
    public GameObject energyCircle;
    //SFX object - DH
    SFXscript destroyEnemyShip;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        destroyEnemyShip = GameObject.FindObjectOfType(typeof(SFXscript)) as SFXscript;
    }
    // Method to destroy ships on pulse wave impact.
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "ShieldCircle")
        {
            EnemyFire.shipAlive = false;
            animator.Play("EnemyDie");
            Debug.Log("HIT");
            Destroy(gameObject, .5f);
            //Play SFX - DH
            destroyEnemyShip.PlayBoom3();
        }
    }
}
