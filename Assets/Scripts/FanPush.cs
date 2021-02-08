using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FanDemo : MonoBehaviour
{ 
    
    public float fanStrength = 10.0f;
    public GameObject hat;
    public GameObject fan;


    public void Start()
    {
        public Vector2 playerPosition = hat.transform.position;
        public Vector2 fanPosition = fan.transform.position;
        public Vector2 fanPush = playerPosition - fanPosition;
    }


    public void OnTriggerEnter2D(Collider2D other)
    {

        Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
        if (rb == null)
            return;
        rb.AddForce(transform.fanPush * fanStrength, ForceMode2D.Impulse);
    }

}











