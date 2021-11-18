using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bal : MonoBehaviour
{
    public int teamBluescore = 0;

    public int teamRedscore = 0; 

    Rigidbody _rigitbody;

    void Start()
    {
        _rigitbody = GetComponent<Rigidbody>();
    }

    void OntriggerEnter(Collider other)
    {
       Vector3 startPoint = new Vector3 (0, 1, 0);

       if(other.tag == "BlueGoal")
       {
         teamRedscore += 1;
       }

       if(other.tag == "RedGoal")
       {
         teamBluescore += 1;
       }
     transform.position = startPoint;
     _rigitbody.velocity = Vector3.zero;
     _rigitbody.angularVelocity = Vector3.zero;

    }
    
        
    
}
