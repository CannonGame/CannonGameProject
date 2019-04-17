using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMScript : MonoBehaviour
{
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
        //tried doing this to combat one of my multitude of issues
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
