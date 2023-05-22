using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mute : MonoBehaviour
{
    [SerializeField] AudioSource bgm1;

    [SerializeField] AudioSource bgm2;

    [SerializeField] AudioSource sfx;

    [SerializeField] Toggle toggle;

   
    void Awake()
    {
        toggle.isOn = false;
    }
    void Update()
    {
        if (toggle.isOn)
        {
            bgm1.mute = true;
            bgm2.mute = true;
            sfx.mute = true;
        }

        else
        {
            bgm1.mute = false;
            bgm2.mute = false;
            sfx.mute = false;
        }
            
    }
}
