using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAnimControl : MonoBehaviour
{
    public float rotateSpeed = 10.0f;

    private void FixedUpdate()
    {
        if(ModeManager.gameMode = GameMode.playMode)
            transform.Rotate(Vector3.forward * -rotateSpeed);
    }
}
