using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanRotate : MonoBehaviour
{
    GameObject rotatingFan;
    
    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.Z))
            transform.Rotate(Vector3.forward * 200 * Time.deltaTime);

        if (Input.GetKey(KeyCode.C))
            transform.Rotate(Vector3.back * 200 * Time.deltaTime);

    }
}

