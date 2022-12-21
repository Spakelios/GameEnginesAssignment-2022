using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBox : MonoBehaviour
{
    public GameObject menu, menu2, menu3, rain, snow;

    public void Menu1()
    {
         menu.SetActive(true);
         menu2.SetActive(false);
         menu.SetActive(false);
         rain.SetActive(false);
         snow.SetActive(false);
    }

    public void Menu2()
    {
        menu.SetActive(false);
        menu2.SetActive(true);
        menu3.SetActive(false);
        rain.SetActive(false);
        snow.SetActive(false);
        
    }

    public void Menu3()
    {
        menu.SetActive(false);
        menu2.SetActive(false);
        menu3.SetActive(true);
        rain.SetActive(true);
        snow.SetActive(false);
        
    }

    public void snows()
    {
        snow.SetActive(true);
    }


}
