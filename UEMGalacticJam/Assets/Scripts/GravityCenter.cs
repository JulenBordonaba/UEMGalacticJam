using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SphereCollider))]
public class GravityCenter : MonoBehaviour
{
    public float force;

    [SerializeField]
    private float radius;

    private SphereCollider sphereCollider;

    private void Awake()
    {
        sphereCollider = GetComponent<SphereCollider>();

        sphereCollider.radius = radius / transform.lossyScale.x;
    }
    
}
