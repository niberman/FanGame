using System.Collections;
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
    //action creates a delegate, and an instance of a delegate
    //a delegate is a variable that you can assign function(s) to

    [ShowInInspector]
    public static GameMode gameMode = GameMode.editMode;
    public static event Action<GameMode> toggleGameMode;
    [SerializeField] GameObject portalPrefab;
    [SerializeField] GameObject fanPrefab;
    public GameObject[] level;
    public int levelNumber;
    public GameObject currentLevel;

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

        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    ToggleGameMode();
        //}

        //if(Input.GetKeyDown())
    }

    [Button]
    public void SwitchLevel()
    {

        if (currentLevel != null)
        {
            Destroy(currentLevel);
        }

        currentLevel = Instantiate(level[levelNumber]);
        levelNumber++;

        Debug.Log(level[levelNumber]);

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

