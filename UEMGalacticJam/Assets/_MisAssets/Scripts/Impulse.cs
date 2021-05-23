using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impulse : MonoBehaviour
{
    public Rigidbody rigidbody;
    public float impulse = 1.0f;
    Vector3 InitialPos;
    public float ndeimpulsos = 0.0f;

    Vector3 NewPos;
    float Distance;
    Vector3 Direction;
    Vector3 TargetPosition;
    


    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        InitialPos = transform.position;
      
        if (Input.GetMouseButtonDown(0) && ndeimpulsos > 0)
        {
            MouseToWorldPosition();
            ndeimpulsos--;

           
            
        }
        
    }
   

    public Vector3 MouseToWorldPosition()
    {
        Plane m_plane = new Plane(-Vector3.forward, Vector3.zero);
        Ray ray2 = Camera.main.ScreenPointToRay(Input.mousePosition);
        float enter = 0.0f;
        if (m_plane.Raycast(ray2, out enter))
        {
            Vector3 hitPoint = ray2.GetPoint(enter);
            NewPos = hitPoint - InitialPos;
            Distance = NewPos.magnitude;
            Direction = NewPos / Distance;
            rigidbody.AddForce(impulse * Direction.x, impulse * Direction.y, impulse * Direction.z, ForceMode.VelocityChange);
            
            return hitPoint;
            
        }
        return Vector3.zero;
    }

}
