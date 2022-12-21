using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class snow : MonoBehaviour
{
    public Toggle snows;
    public GameObject snow2;

    public void Update()
    {
        if (snows.isOn)
        {
            snow2.SetActive(true);
        }
        else 
        {
            snow2.SetActive(false);
        }
    }

}
