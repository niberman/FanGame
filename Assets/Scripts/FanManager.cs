using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FanManager : MonoBehaviour
{
    public GameObject fanLeft;
    public GameObject fanUp;
    public GameObject fanDown;
    public GameObject fanRight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            Instantiate(fanDown);
        else if (Input.GetKeyDown(KeyCode.Alpha2))
            Instantiate(fanUp);
        else if (Input.GetKeyDown(KeyCode.Alpha3))
            Instantiate(fanRight);
        else if (Input.GetKeyDown(KeyCode.Alpha4))
            Instantiate(fanLeft);
        else
            return;
    }
}
