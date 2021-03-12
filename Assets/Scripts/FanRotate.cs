﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanRotate : MonoBehaviour
{
    GameObject rotatingFan;
    public float rotateSpeed;
    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.R))
            transform.Rotate(Vector3.forward * rotateSpeed * Time.deltaTime);
        
        if (Input.GetKeyDown(KeyCode.T))
            transform.Rotate(Vector3.back * 200 * Time.deltaTime);
        
    }
}

