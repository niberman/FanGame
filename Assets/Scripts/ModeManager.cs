﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Sirenix.OdinInspector;

public class ModeManager : MonoBehaviour
{
    
    private GameMode gameMode = GameMode.editMode;
    public static event Action<GameMode> toggleGameMode;
    //action creates a delegate, and an instance of a delegate
    //a delegate is a variable that you can assign function(s) to


    [Button]
    private void ToggleGameMode()
    {
        if (toggleGameMode != null)
        {
            toggleGameMode.Invoke(gameMode);
            
        }

    }
}

public enum GameMode
{
    editMode,
    playMode
}
