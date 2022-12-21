using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snowController : MonoBehaviour
{
    // Start is called before the first frame update
    [Range(0,1)] public float snowQuantity;
    ParticleSystem snow;
    bool color;
    void Start()
    {
        snow = gameObject.GetComponent<ParticleSystem>();
        color = false;
    }

    // Update is called once per frame
    void Update()
    {
        var emission = snow.emission;
        emission.rateOverTime = snowQuantity*600;
    }

    public void toggleColor()
    {
        if(color == false)
        {
            var col = snow.colorBySpeed;
            color = true;
            col.enabled = true;
        }else
            if (color == true)
        {
            var col = snow.colorBySpeed;
            color = false;
            col.enabled = false;
        }
    }
}
