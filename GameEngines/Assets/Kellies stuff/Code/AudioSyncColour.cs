using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSyncColour : MonoBehaviour
{
    private void Start()
    {
          GetComponent<ParticleSystem>();
    }

    void Update()
    {
      
        ParticleSystem.MinMaxGradient minMaxGradient;
        minMaxGradient = new ParticleSystem.MinMaxGradient (Color.cyan, Color.blue);
        minMaxGradient.mode = ParticleSystemGradientMode.RandomColor;
        print("it works");
        

    }
}
