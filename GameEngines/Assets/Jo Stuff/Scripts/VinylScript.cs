using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VinylScript : MonoBehaviour
{
    public Transform vinyl;
    private AudioSource music;
    private AudioClip musicClip;
    private float[] samples;
    private float[] smoothed;

    public int frameSize = 512;
    public float scale;

    private float average;
    private float lerpedAverage;
    private float sum;
    
    private void Start()
    {
        music = GameObject.FindWithTag("MusicPlayer").GetComponent<AudioSource>();
        musicClip = music.clip;
        samples = new float[frameSize];
        smoothed = new float[frameSize];
    }
    
    
    private void Update()
    {
        music.GetOutputData(samples, 0);
        sum = 0;

        for (int i = 0; i < frameSize; i++)
        {
            float s = Mathf.Abs(samples[i] * scale);
            smoothed[i] = Mathf.Lerp(smoothed[i], s, Time.deltaTime);
            sum += Mathf.Abs(samples[i]);
        }

        average = sum / frameSize;
        lerpedAverage = Mathf.Lerp(lerpedAverage, average, Time.deltaTime * 4);

        vinyl.localScale = new Vector3(lerpedAverage, lerpedAverage, lerpedAverage) * scale;
        vinyl.Rotate(Vector3.up, lerpedAverage * 4, Space.World);
    }
}
