using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColonyCollision : MonoBehaviour
{
    //Add Sprite Renderer
    void OnAwake()
    {
        SpriteRenderer sprRend = gameObject.AddComponent<SpriteRenderer>() as SpriteRenderer;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Runs when an object (enemy bullet) collides with the colony. Health drops 1. Colony turns red temporarily.
    void OnTriggerEnter2D(Collider2D col)
    {
        //Debug.Log("HIT");
        gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("SpaceColonyHit");
        gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("SpaceColony");

    }
}
