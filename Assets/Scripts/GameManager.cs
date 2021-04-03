﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Sirenix.OdinInspector;

public enum GameMode
{
    editMode,
    playMode
}

public class GameManager : MonoBehaviour
{
    [ShowInInspector]
    public static GameMode gameMode = GameMode.editMode;
    public static event Action<GameMode> toggleGameMode;
    //action creates a delegate, and an instance of a delegate
    //a delegate is a variable that you can assign function(s) to

    public GameObject portalPrefab;
    public GameObject fanPrefab;

    void Start()
    {
        //fanPrefab = GameObject.FindGameObjectWithTag("Fan");
        //portalPrefab = GameObject.FindGameObjectWithTag("Portal");
    }
    private void Update()
    {
        //spawns fan on f
        if (Input.GetKeyDown(KeyCode.F) && GameManager.gameMode == GameMode.editMode)
        {
            Instantiate(fanPrefab, new Vector3(3, 3, 0), Quaternion.identity);
        }

        //spawns portal on a
        if (Input.GetKeyDown(KeyCode.A) && GameManager.gameMode == GameMode.editMode)
        {
            Instantiate(portalPrefab, new Vector3(3, 3, 0), Quaternion.identity);
        }

        //supposed to delete object from scene
        //if (Input.GetKeyDown(KeyCode.Backspace) && GameManager.gameMode == GameMode.editMode)
        //{
        //    Destroy(GameObject.FindObjectOfType<Selectable>());

        //    Debug.Log("backspace");
        //}
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

