using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHead : MonoBehaviour
{
    [SerializeField]
    private SkinnedMeshRenderer playerMesh;
    [SerializeField]
    private float changeVelocity;

    [HideInInspector]
    public float atractionForce;
    
    // Update is called once per frame
    void Update()
    {
        UpdateBlendShapes();
    }

    private void UpdateBlendShapes()
    {
        atractionForce = playerMesh.GetBlendShapeWeight(0);

        float input = Input.GetAxisRaw("Vertical");

        atractionForce += input * changeVelocity * Time.deltaTime;

        atractionForce = Mathf.Clamp(atractionForce, 0, 100);

        playerMesh.SetBlendShapeWeight(0, atractionForce);
    }
}