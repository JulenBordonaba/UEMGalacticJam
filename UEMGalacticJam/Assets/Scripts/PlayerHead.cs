using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHead : MonoBehaviour
{
    [SerializeField]
    private SkinnedMeshRenderer playerMesh;
    [SerializeField]
    private float changeVelocity;
    private bool sound = false;
    public AudioSource increase;
    public AudioSource decrease;

    [HideInInspector]
    public float atractionForce;

    private SphereCollider coll;

    float radius;
    float y;

    private void Start()
    {
        coll = GetComponent<SphereCollider>();
        radius = coll.radius;
        y = coll.center.y;
    }
    // Update is called once per frame
    void Update()
    {
        UpdateBlendShapes();
    }

    private void UpdateBlendShapes()
    {
        atractionForce = playerMesh.GetBlendShapeWeight(0);

        float input = Input.GetAxisRaw("Vertical");

        //coll.radius = (atractionForce * 0.1f) * radius;
        //coll.center = new Vector3(coll.center.x, y + atractionForce * 0.1f, coll.center.z);

        if (input == 1 && sound == false && atractionForce != 100 && !decrease.isPlaying)
        {
            sound = true;
            increase.Play(0);
        } else if (input == 0 && sound == true)
        {
            sound = false;
        }else if (input == -1 && sound == false && atractionForce != 0 && !increase.isPlaying)
        {
            decrease.Play(0);
            
            sound = true;
            
        }

        atractionForce += input * changeVelocity * Time.deltaTime;

        atractionForce = Mathf.Clamp(atractionForce, 0, 10);

        playerMesh.SetBlendShapeWeight(0, atractionForce);
    }
}