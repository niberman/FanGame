using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FanPush : MonoBehaviour
{

    public float fanStrength = 10.0f;
    public GameObject hat;
    public GameObject fan;


    public void Start()
    {
         Vector2 playerPosition = hat.transform.position;
         Vector2 fanPosition = fan.transform.position;
         Vector2 pushVector = playerPosition - fanPosition;  
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        gameObject.transform.position += pushVector * Time.deltaTime * fanStrength;

        //Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
        //if (rb == null)
        //    return;
        //rb.AddForce(pushVector * fanStrength, ForceMode2D.Impulse);
    }
}

    
    













