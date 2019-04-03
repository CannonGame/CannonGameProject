using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // Leads to Main Menu after a delay
        if (Input.anyKeyDown || Input.GetMouseButtonDown(0))
        {
            Invoke("SceneDelay", 1);
        }
    }

    void SceneDelay()
    {
        SceneManager.LoadScene("HomeScreen");
    }
}