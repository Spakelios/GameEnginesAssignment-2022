using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainbowRain : MonoBehaviour
{
    private ParticleSystem rain;
    private ParticleSystem.ColorOverLifetimeModule color;

    void Start()
    {
        rain = GameObject.FindWithTag("Rain").GetComponent<ParticleSystem>();
        color = rain.colorOverLifetime;


    }

    // Update is called once per frame
    void Update()
    {

    }
}
