using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanRotate : MonoBehaviour
{
    GameObject rotatingFan;
    public float rotateSpeed;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
            transform.Rotate(0, 0, -90);

        if (Input.GetKeyDown(KeyCode.R))
            transform.Rotate(0, 0, 90);
    }
}
