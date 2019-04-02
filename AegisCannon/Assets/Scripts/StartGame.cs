using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using System;

public class StartGame : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        // This will lead to the Main Menu Scene once implemented.
        if (Input.anyKeyDown || Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("HomeScreen");

            //FindObjectOfType<AudioManager>().Play("Button Sound");
        }
    }
}