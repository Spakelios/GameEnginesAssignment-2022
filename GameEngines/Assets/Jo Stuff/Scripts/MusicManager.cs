using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicManager : MonoBehaviour
{
    private AudioSource MusicPlayer;
    private AudioSource cloud;
    private AudioSource rain;
    private AudioSource snow;
    private AudioSource thunder;

    public Toggle rainToggle;
    public Toggle thunderToggle;
    public Toggle lightningToggle;
    public Toggle snowToggle;
    private void Start()
    {
        MusicPlayer = GameObject.FindWithTag("MusicPlayer").GetComponent<AudioSource>();
        cloud = GameObject.FindWithTag("CloudMusic").GetComponent<AudioSource>();
        rain = GameObject.FindWithTag("RainMusic").GetComponent<AudioSource>();
        snow = GameObject.FindWithTag("SnowMusic").GetComponent<AudioSource>();
        thunder = GameObject.FindWithTag("ThunderMusic").GetComponent<AudioSource>();
        MusicPlayer.Play(); 

    }

    // Update is called once per frame
    private void Update()
    {

        if (!MusicPlayer.isPlaying)
        {
            MusicPlayer.Play();
        }
        
        if (rainToggle.isOn)
        {
                MusicPlayer.clip = rain.clip;
        }
        
        else if (thunderToggle.isOn || lightningToggle.isOn)
        {
                MusicPlayer.clip = thunder.clip;
        }
        
        
         else if (snowToggle.isOn)
         {
             MusicPlayer.clip = snow.clip;
         }
        

        else
        {
            MusicPlayer.clip = cloud.clip;
        }
            
    }
}
