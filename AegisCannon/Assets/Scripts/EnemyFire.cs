using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour
{
    // Can tweak the public floats inside of Unity in the inspector.
    Animator animator;
    public float delay = 1.5f;
    public static float randomMin = 3f;
    public static float randomMax = 4f;
    public static float projectileSpeed = 3f;
    public Transform shipTransform;
    public Rigidbody2D projectileBody;
    public bool preparingToFire = false;
    public bool firing = false;
    public bool shouldFire = true;
    public int enemyShipFire;
    public static bool shipAlive = true;
    //Object to play shot SFX - DH
    public SFXscript playShot;

    // Start is called before the first frame update. Gets Animator Component and Starts infinite Coroutine to make enemies fire.
    void Start()
    {
        animator = GetComponent<Animator>();
        StartCoroutine(StartFire());
        playShot = GameObject.FindObjectOfType(typeof(SFXscript)) as SFXscript;
    }

    // Method to make enemies fire a projectile upwards relative to their position.
    void FireShot()
    {
        Rigidbody2D projectile1 = Instantiate(projectileBody, shipTransform.position, shipTransform.rotation);
        projectile1.velocity = transform.up * projectileSpeed;
        playShot.PlayEnemyFire();
    }
    // Called once per frame. Checks which enemy ship was assigned to fire. Sets all other enemy ships to not fire.
    void Update()
    {
        if (enemyShipFire == 0 && shipAlive)
        {
            GameObject.Find("EnemyShip").GetComponent<EnemyFire>().firing = true;
            GameObject.Find("EnemyShip (1)").GetComponent<EnemyFire>().firing = false;
            GameObject.Find("EnemyShip (2)").GetComponent<EnemyFire>().firing = false;
            GameObject.Find("EnemyShip (3)").GetComponent<EnemyFire>().firing = false;
        }
        if (enemyShipFire == 1 && shipAlive)
        {
            GameObject.Find("EnemyShip (1)").GetComponent<EnemyFire>().firing = true;
            GameObject.Find("EnemyShip").GetComponent<EnemyFire>().firing = false;
            GameObject.Find("EnemyShip (2)").GetComponent<EnemyFire>().firing = false;
            GameObject.Find("EnemyShip (3)").GetComponent<EnemyFire>().firing = false;
        }
        if (enemyShipFire == 2 && shipAlive )
        {
            GameObject.Find("EnemyShip (2)").GetComponent<EnemyFire>().firing = true;
            GameObject.Find("EnemyShip").GetComponent<EnemyFire>().firing = false;
            GameObject.Find("EnemyShip (1)").GetComponent<EnemyFire>().firing = false;
            GameObject.Find("EnemyShip (3)").GetComponent<EnemyFire>().firing = false;
        }
        if (enemyShipFire == 3 && shipAlive)
        {
            GameObject.Find("EnemyShip (3)").GetComponent<EnemyFire>().firing = true;
            GameObject.Find("EnemyShip").GetComponent<EnemyFire>().firing = false;
            GameObject.Find("EnemyShip (2)").GetComponent<EnemyFire>().firing = false;
            GameObject.Find("EnemyShip (1)").GetComponent<EnemyFire>().firing = false;
        }
    }

     /* Infinitely runs this coroutine. Waits a random amount of time, sets the Animator component bool "Firing" to true if the ships shouldFire bool is true and firing bool is true. 
        Triggers the blinking animation. Waits duration of the variable delay and sets the "Firing" bool to false to turn off the animation. Then calls FireShot to make enemy fire a projectile.
        sets preparingToFire, firing, and shouldFire to false, waits random amount of time, then sets shouldFire back to true. This way we can control multiple ships with this one script*/
    public IEnumerator StartFire()
    {
        while (true && shipAlive)
        {
            if (shouldFire)
            {
                enemyShipFire = Random.Range(0, 4);
                Debug.Log(enemyShipFire);
                yield return new WaitForSeconds(Random.Range(randomMin, randomMax));
                preparingToFire = true;
                if (preparingToFire && firing)
                {
                    animator.SetBool("Firing", true);
                    yield return new WaitForSeconds(delay);
                    animator.SetBool("Firing", false);
                    FireShot();
                    firing = false;
                    shouldFire = false;
                    preparingToFire = false;
                    yield return new WaitForSeconds(2);
                    shouldFire = true;
                }
            }
        }
    }
}
