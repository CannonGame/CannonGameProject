using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyShip : MonoBehaviour
{
    Animator animator;
    public GameObject energyCircle;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "ShieldCircle")
        {
            animator.Play("EnemyDie");
            Debug.Log("HIT");
            Destroy(gameObject, .5f);
        }
    }
}
