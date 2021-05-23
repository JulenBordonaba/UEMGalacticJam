using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Rotate : MonoBehaviour
{
    public float velocidad = 1.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate (new Vector3 (0f, 0f, velocidad*10)* Time.deltaTime) ;
        
    }
}
