using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCenterofMass : MonoBehaviour
{
    public Vector3 com;
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        com = new Vector3(0,0,0);
        rb.centerOfMass = com;
    }

    // Update is called once per frame
    void Update()
    {
        rb.centerOfMass = com;
    }
}
