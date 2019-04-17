using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SwitchBGM : MonoBehaviour
{
    //audio objects
    public AudioSource MenuBGM, BGM, LossBGM;

    //counter to decide what to play based on whether it's in menu or in game
    public static int trackSelect = 0;

    // Start is called before the first frame update
    void Start()
    {
        //play songs and make sure the others stop.
        if (trackSelect == 0) {
            MenuBGM.Play();
            LossBGM.Stop();
            BGM.Stop();
        }
        else if (trackSelect == 1) {
            MenuBGM.Stop();
            BGM.Stop();
            LossBGM.Play();
        }
        else if (trackSelect == 2) { 
            LossBGM.Stop();
            MenuBGM.Stop();
            BGM.Play();
    }
        }
 

    // Update is called once per frame
    void Update()
    {
                
    }



}
