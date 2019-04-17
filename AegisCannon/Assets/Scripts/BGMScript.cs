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
   //control the number of active BGM managers
    //public static BGMScript instance = null;
    //public static BGMScript Instance
    //{
    //    get { return instance; }
    //}

    private void Awake()
    {
        //if the instance doesnt exist, destroy it? might have to re-think this spot
        //if (instance != null && instance != this)
        //{
        //    Destroy(this.gameObject);
        //}
        //else
        //{
        //    instance = this;
        //}


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
