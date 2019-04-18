using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMScript : MonoBehaviour
{
    //declare BGM object
    public static AudioSource BGM;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void Awake()
    {

    }

    private void Update()
    {
        //Keep menu BGM between screens, not between game scenes, like game over, etc
        if (SwitchBGM.trackSelect == 0)
        {
            DontDestroyOnLoad(this.gameObject);


        }
        else if (SwitchBGM.trackSelect >= 1)
        {
            Destroy(this.gameObject);
            return;
        }
    }

}
