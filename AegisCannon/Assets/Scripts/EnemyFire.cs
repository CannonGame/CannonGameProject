using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour
{
    // Can tweak the public floats inside of Unity in the inspector.
    Animator animator;
    public float delay = 1.5f;
    public float randomMin = 3f;
    public float randomMax = 8f;
    public float projectileSpeed = 0f;
    public Transform shipTransform;
    public Rigidbody2D projectileBody;


    // Start is called before the first frame update. Gets Animator Component and Starts infinite Coroutine to make enemies fire.
    void Start()
    {
        animator = GetComponent<Animator>();
        StartCoroutine(StartFire());
    }


    // Method to make enemies fire a projectile upwards relative to their position.
    void FireShot()
    {
        Rigidbody2D projectile1 = Instantiate(projectileBody, shipTransform.position, shipTransform.rotation);
        projectile1.velocity = transform.up * projectileSpeed;
    }

     /* Infinitely runs this coroutine. Waits a random amount of time, sets the Animator component bool "Firing" to true, which triggers the blinking animation. Waits
        duration of the variable delay and sets the "Firing" bool to false to turn off the animation. Then calls FireShot to make enemy fire a projectile. */
    public IEnumerator StartFire()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(randomMin, randomMax));
            animator.SetBool("Firing", true);
            yield return new WaitForSeconds(delay);
            animator.SetBool("Firing", false);
            FireShot();
        }
    }
}
