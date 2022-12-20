using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatewind : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    [SerializeField] float maxspeed;
    float i;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        i = i + 0.1f;
        speed = Mathf.Lerp(speed,Random.Range(-360,360), 0.01f);
        gameObject.transform.Rotate(0, speed/maxspeed, 0);
    }
}
