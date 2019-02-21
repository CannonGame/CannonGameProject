using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // This will lead to the Main Menu Scene once implemented.
        if (Input.anyKeyDown || Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("Level Select");
        }
    }
}