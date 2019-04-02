using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsBackButton : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        //Returns to Home Screen
        if (Input.anyKeyDown || Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("HomeScreen");

            //FindObjectOfType<AudioManager>().Play("buttonSound");
        }
    }
}
