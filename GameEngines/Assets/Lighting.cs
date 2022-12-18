using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.UI;

public class Lighting : MonoBehaviour
{
    public Material newMat;
    public Slider slider;
    public Toggle tog;
  
    public Material sky;
    public Slider skyder;

    public GameObject thunderbolt;
    public GameObject lightinging;
    public Toggle thunderOn;
    public Toggle lighteningOn;

    private void Start()
    {
        newMat = GetComponent<MeshRenderer>().sharedMaterial;
    }

    public void Update()
    {
        //clouds
        newMat.SetFloat("_CloudsPower", slider.value);
        if (tog.isOn)
        {
            newMat.SetColor("_Color", Color.white);
        }
        else
        {
            newMat.SetColor("_Color", Color.grey);
        }

        //Sky
        sky.SetFloat("_AtmosphereThickness", skyder.value);
        
        //Thunder and lightning
        
        if(thunderOn.isOn)
        {
            thunderbolt.SetActive(true);
        }
        else
        {
            thunderbolt.SetActive(false);
        }

        if (lighteningOn.isOn)
        {
            lightinging.SetActive(true);
        }
        else
        {
            lightinging.SetActive(false);
        }
        
        
    }
}
