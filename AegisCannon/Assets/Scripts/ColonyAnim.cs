﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColonyAnim : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        anim.Play("ShieldDamage1");
    }
}
