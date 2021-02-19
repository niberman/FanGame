using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    bool editMode;
    //BoxCollider2D boxColl;
    public GameObject fanDown;

    // Start is called before the first frame update
    void Start()
    {
        editMode = true; 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            fanDown.GetComponent<BoxCollider2D>().enabled = false;
            Debug.Log("boxColl should be turned off");
        }
    }
}
