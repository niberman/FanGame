using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation : MonoBehaviour
{
    public GameObject portal;
    private GameObject player;
    private bool canPortal = true;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && canPortal == true)
            portal.GetComponent<Teleportation>().StartCooldown();
        player.GetComponent<Rigidbody2D>().position = portal.transform.position;
    }

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    IEnumerator Cooldown()
    {
        yield return new WaitForSeconds(1.0f);
        canPortal = true;
    }

    public void StartCooldown()
    {
        canPortal = false;
        StartCoroutine(Cooldown());
    }
}
