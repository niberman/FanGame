using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FanPush : MonoBehaviour
{

    public float fanStrength = 10.0f;
    public GameObject hat;
    public GameObject fan;

   
    Vector3 playerPosition;
    Vector3 fanPosition;
    Vector3 pushVector;

    private void Start()
    {
        playerPosition = hat.transform.position;
        fanPosition = fan.transform.position;
        pushVector = playerPosition - fanPosition;
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        //other.transform.position += pushVector * Time.deltaTime * fanStrength;

        Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
        if (rb == null)
            return;
        rb.AddForce(pushVector * fanStrength, ForceMode2D.Impulse);
    }
}

    
    













