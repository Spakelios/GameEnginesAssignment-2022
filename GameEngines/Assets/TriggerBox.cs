using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBox : MonoBehaviour
{
    public GameObject menu, menu2, menu3;

    public void Menu1()
    {
         menu.SetActive(true);
         menu2.SetActive(false);
         menu.SetActive(false);
    }

    public void Menu2()
    {
        menu.SetActive(false);
        menu2.SetActive(true);
        menu3.SetActive(false);
    }

    public void Menu3()
    {
        menu.SetActive(false);
        menu2.SetActive(false);
        menu3.SetActive(true);
    }
    

}
