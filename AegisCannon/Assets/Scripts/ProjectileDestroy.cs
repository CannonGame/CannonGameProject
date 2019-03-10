using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileDestroy : MonoBehaviour
{

    // Destroys Projectiles
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Shield" || col.gameObject.tag == "Colony")
        {
            Destroy(gameObject);
        }
    }
}
