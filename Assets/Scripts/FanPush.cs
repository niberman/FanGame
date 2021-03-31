using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class FanPush : MonoBehaviour
{
    private float fanStrength = 75.0f;
    private GameObject money;
    private GameObject fan;

    // Vector3 playerPosition;
    Vector3 fanPosition;
    Vector3 pushVector;

    private void Start()
    {
        money = GameObject.FindWithTag("Player");
        fan = this.gameObject;
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        pushVector = this.transform.right;

        Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
        if (rb == null)
            return;
        rb.AddForce(pushVector * fanStrength, ForceMode2D.Impulse);
    }
}
















