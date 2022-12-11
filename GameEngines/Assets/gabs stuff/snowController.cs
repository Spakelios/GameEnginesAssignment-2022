using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snowController : MonoBehaviour
{
    // Start is called before the first frame update
    [Range(0,1)] public float snowQuantity;
    ParticleSystem snow;
    void Start()
    {
        snow = gameObject.GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        var emission = snow.emission;
        emission.rateOverTime = snowQuantity*600;
    }
}
