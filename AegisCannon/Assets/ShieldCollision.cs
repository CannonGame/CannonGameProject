using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Runs when an object (enemy bullet) collides with the shield. Shield gets charged. Colony turns turqiose temporarily.
    void OnTriggerEnter2D(Collider2D col)
    {
        //Debug.Log("BLOCKED");
    }
}
