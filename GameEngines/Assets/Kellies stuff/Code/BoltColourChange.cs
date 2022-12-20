using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoltColourChange : MonoBehaviour
{
    public ParticleSystem Particle;

    void Update()
    {
        Color[] colors = { new Color(0,1,0,1), new Color(1,0,0,1), new Color(1,1,1,1), new Color(0,0,1,1),  new Color(1,1,0,1), new Color(0, 0, 0, 1)};
        int lengthOfColors = colors.Length; 
        
        
        int rndColor = UnityEngine.Random.Range (0, lengthOfColors);
        Particle.startColor = gameObject.GetComponent<Renderer>().material.color  = colors[rndColor];
    }
}
