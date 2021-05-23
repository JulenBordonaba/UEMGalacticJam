using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour
{
    [SerializeField]
    private PlayerHead head;
    [SerializeField]
    private List<GravityCenter> centersInArea;
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        centersInArea = new List<GravityCenter>();
    }

    private void FixedUpdate()
    {
        //print(AtractionForce);
        rb.AddForce(AtractionForce*(head.atractionForce/50f));
    }

    private Vector3 AtractionForce
    {
        get
        {
            Vector3 finalForce = Vector3.zero;
            foreach (GravityCenter gc in centersInArea)
            {
                Vector3 direction = rb.transform.position - gc.transform.position;
                float distance = direction.magnitude;

                float forceMagnitude = -gc.force / distance;

                Vector3 force = direction.normalized * forceMagnitude;
                finalForce += force;
            }
            return finalForce;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        GravityCenter gc;
        if((gc=other.gameObject.GetComponent<GravityCenter>())!=null)
        {
            if(!centersInArea.Contains(gc))
            {
                centersInArea.Add(gc);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        GravityCenter gc;
        if ((gc = other.gameObject.GetComponent<GravityCenter>()) != null)
        {
            if (centersInArea.Contains(gc))
            {
                centersInArea.Remove(gc);
            }
        }
    }


}
