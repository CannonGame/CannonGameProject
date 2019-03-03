using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreenButtons : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //When Home button is hit it takes you to the home screen
    public void HomeButtonClick()
    {
        SceneManager.LoadScene("HomeScreen");
    }

    //When Exit button is hit it exits the gamen
    public void ExitButtonClick()
    {
        Application.Quit();
    }
}
