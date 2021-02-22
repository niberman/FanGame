using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class CollToggle : MonoBehaviour
{
    
    [SerializeField] BoxCollider2D dragColl;
    [SerializeField] BoxCollider2D pushColl;

    private void OnEnable()
    {
        GameManager.toggleGameMode += ToggleColldiers;
    }

    private void OnDisable()
    {
        GameManager.toggleGameMode -= ToggleColldiers;
    }

    [Button]
    void ToggleColldiers(GameMode gameMode)
    {
        pushColl.enabled = !dragColl.enabled;
        dragColl.enabled = !pushColl.enabled;
    }
}
