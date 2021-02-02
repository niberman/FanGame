using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanDemo : MonoBehaviour
{
    float fanStrength = 10.0f;


    private void OnTriggerEnter2D(Collider2D other)
    {
        Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
        if (rb == null)
            return;
        rb.AddForce(-transform.right * fanStrength, ForceMode2D.Impulse);
    }

    
}
