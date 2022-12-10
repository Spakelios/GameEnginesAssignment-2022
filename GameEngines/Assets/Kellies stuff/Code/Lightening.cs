using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightening : MonoBehaviour
{
    public float offMin = 10f;
    public float offMAX = 60f;
    public float onMin = 0.25f;
    public float onMax = 0.8f;

    public Light light;
    public AudioClip[] thunderSounds;
    public AudioSource audioSource;

    void Start()
    {
        StartCoroutine("Lightning");
    }

    IEnumerator Lightning()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(offMin, offMAX));
            light.enabled = true;
            
            StartCoroutine("SoundFX");
            yield return new WaitForSeconds(Random.Range(offMin, onMax));
            light.enabled = false;

        }

    }

    IEnumerator SoundFX()
    {
        yield return new WaitForSeconds(Random.Range(.25f, 1.75f));
        audioSource.PlayOneShot(thunderSounds[Random.Range(0, thunderSounds.Length)]);
    }
}
