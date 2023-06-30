using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CenterofMass : MonoBehaviour
{
    public Vector3 CenterOfMass2;

    protected Rigidbody r;
    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Rigidbody>();
        r.centerOfMass = CenterOfMass2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

