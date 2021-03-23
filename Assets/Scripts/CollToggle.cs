using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class CollToggle : MonoBehaviour
{
    
    [SerializeField] CircleCollider2D dragColl;
    [SerializeField] BoxCollider2D pushColl;

    private void OnEnable()
    {
        ModeManager.toggleGameMode += ToggleColldiers;
        pushColl.enabled = false;
        dragColl.enabled = true;
    }

    private void OnDisable()
    {
        ModeManager.toggleGameMode -= ToggleColldiers;
    }

    [Button]
    void ToggleColldiers(GameMode gameMode)
    {
        pushColl.enabled = !pushColl.enabled;
        dragColl.enabled = !dragColl.enabled;
    }
}
