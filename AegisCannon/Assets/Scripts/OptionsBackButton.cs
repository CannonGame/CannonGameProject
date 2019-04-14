using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsBackButton : MonoBehaviour
{

    public void BackButton()
    {
        SceneManager.LoadScene("HomeScreen");
    }
}
