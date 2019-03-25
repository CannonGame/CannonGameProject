using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldMovement : MonoBehaviour
{
    //Fields
    const int leftRotateSpeed = 120;
    const int rightRotateSpeed = -120;
    
    // Update is called once per frame
    void Update()
    {
        // Adjust shield when phone is moved
        if (Input.acceleration.x < 0)
        {
            transform.RotateAround(Vector3.zero, Vector3.forward, leftRotateSpeed * Time.deltaTime);
        }
        if (Input.acceleration.x > 0)
        {
            transform.RotateAround(Vector3.zero, Vector3.forward, rightRotateSpeed * Time.deltaTime);
        }
    }
}
