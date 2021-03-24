using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class SelectionManager : MonoBehaviour
{
    [ShowInInspector]
    public static Selectable selectedObject;

    Selectable RayCastToMouse()
    {
        
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

        if (hit.collider != null && hit.transform.GetComponent<Selectable>())
        {
            Debug.Log("success");
            return hit.transform.GetComponent<Selectable>();
        }
        return null;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            selectedObject = RayCastToMouse();
        }
    }
}

