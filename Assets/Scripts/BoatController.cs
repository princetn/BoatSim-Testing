using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BoatController : MonoBehaviour
{
    public float ForceFactor = 5000;
    public float rotation = 0.1f;
    private Rigidbody BoatRb;
    // Start is called before the first frame update
    void Start()
    {
        BoatRb = this.gameObject.GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W))
        {
            Vector3 forward = - BoatRb.transform.up;
            BoatRb.transform.Rotate(-rotation * Vector3.forward);
            BoatRb.AddForce(ForceFactor * forward, ForceMode.Force);
           
        }
        else if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.W))
        {
            Vector3 forward = - BoatRb.transform.up;

            BoatRb.transform.Rotate(rotation * Vector3.forward);
            BoatRb.AddForce(ForceFactor * forward, ForceMode.Force);

        }
        else if (Input.GetKey(KeyCode.W))
        {
            Vector3 forward = - BoatRb.transform.up;

            BoatRb.AddForce(ForceFactor * forward,ForceMode.Force);
        }
    }
}
