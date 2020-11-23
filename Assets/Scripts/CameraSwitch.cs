using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public Camera FpvCam;
    public Camera FixedCam;
    private bool camSwitch = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.C))
        {
            camSwitch = !camSwitch;
        }
        FpvCam.enabled = ! camSwitch;
        FixedCam.enabled = camSwitch;
    }
}
