using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followind : MonoBehaviour
{
    public GameObject whotofollow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = whotofollow.transform.position;
    }
}
