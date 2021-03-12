using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class FanMovementController : MonoBehaviour
{

    private Vector3 screenPoint;
    private Vector3 offset;

    void OnMouseDown()
    {
        if (ModeManager.gameMode == GameMode.playMode)
            return;

        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);

        offset = gameObject.transform.position -
            Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));

    }

    void OnMouseDrag()
    {
        if (ModeManager.gameMode == GameMode.playMode)
            return;

        Vector2 curScreenPoint = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

        Vector2 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        transform.position = curPosition;

    }

}