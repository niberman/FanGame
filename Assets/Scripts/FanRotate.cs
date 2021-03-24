using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanRotate : MonoBehaviour
{
    GameObject rotatingFan;

    // Update is called once per frame
    void Update()
    {
        if (SelectionManager.selectedObject != null && SelectionManager.selectedObject.gameObject != this.gameObject)
            return;

        if (Input.GetKeyDown(KeyCode.T))
            transform.Rotate(0, 0, -45);

        if (Input.GetKeyDown(KeyCode.R))
            transform.Rotate(0, 0, 45);
    }
}
