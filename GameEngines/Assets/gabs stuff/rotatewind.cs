using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rotatewind : MonoBehaviour
{
    // Start is called before the first frame update
    [Range(0, 50)] public float speed;
    public Slider windzone;
    public WindZone wind;
    [SerializeField] float maxspeed;
    float i;
    void Start()
    {
        wind = gameObject.GetComponent<WindZone>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        i = i + 0.1f;
        speed = Mathf.Lerp(speed,Random.Range(-360,360), windzone.value);
        gameObject.transform.Rotate(0, speed/maxspeed, 0);
        
    }
}
