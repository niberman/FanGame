using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FanPush : MonoBehaviour
{

    [SerializeField] float fanStrength = 10.0f;
    private GameObject hat;
    private GameObject fan;

   
   // Vector3 playerPosition;
    Vector3 fanPosition;
    Vector3 pushVector;

    private void Start()
    {
        hat = GameObject.FindWithTag("Player");
        fan = this.gameObject;


        //  playerPosition = hat.transform.position;
        //  fanPosition = fan.transform.position;
        pushVector = Vector2.down;
    }

    public void OnTriggerEnter2D(Collider2D other)
    {

        Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
        if (rb == null)
            return;
        rb.AddForce(pushVector * fanStrength, ForceMode2D.Impulse);
    }
}

    
    













