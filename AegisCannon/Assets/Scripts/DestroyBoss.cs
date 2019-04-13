using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyBoss : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    // Call animation and destroy boss TO BE IMPLEMENTED
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "ShieldCircle")
        {
            PulseWave.bossAlive = false;
            animator.Play("BossDie");
            Debug.Log("HIT");
            Destroy(gameObject, .5f);
            SceneManager.LoadScene("WinScreen");
        }
    }
}
