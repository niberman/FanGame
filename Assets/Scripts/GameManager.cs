using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Sirenix.OdinInspector;

public class GameManager : MonoBehaviour
{
    [ShowInInspector]
    public static GameMode gameMode = GameMode.editMode;
    public static event Action<GameMode> toggleGameMode;
    //action creates a delegate, and an instance of a delegate
    //a delegate is a variable that you can assign function(s) to

    
    public GameObject fanPrefab;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && GameManager.gameMode == GameMode.editMode)
        {
            Instantiate(fanPrefab, new Vector3(3, 3, 0), Quaternion.identity);
        }
    }

    [Button]
    private void ToggleGameMode()
    {
        if (toggleGameMode != null)
        {
            if (gameMode == GameMode.editMode)
                gameMode = GameMode.playMode;
            else
                gameMode = GameMode.editMode;

            toggleGameMode.Invoke(gameMode);
        }

    }
}


public enum GameMode
{
    editMode,
    playMode
}
