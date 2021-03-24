using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAnimControl : MonoBehaviour
{
    public float rotateSpeed;
    private void Update()
    {
        if(ModeManager.gameMode == GameMode.playMode)
            transform.Rotate(0, 0, rotateSpeed * Time.deltaTime);
    }
}
