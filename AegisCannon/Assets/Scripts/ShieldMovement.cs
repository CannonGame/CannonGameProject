using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldMovement : MonoBehaviour
{
    //Fields    
    float inputX;
    const int moveSpeed = -200;

    // Update is called once per frame
    void Update()
    {
        // Adjust shield when phone is moved
        inputX = Input.acceleration.x;
        //Debug.Log(inputX);

        if (inputX < 0)
        {
            transform.RotateAround(Vector3.zero, Vector3.forward, (inputX * moveSpeed) * Time.deltaTime);
        }
        if (inputX > 0)
        {
            transform.RotateAround(Vector3.zero, Vector3.forward, (inputX * moveSpeed) * Time.deltaTime);
        }
    }
}
