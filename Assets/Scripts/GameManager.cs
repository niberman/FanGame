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
    private List<GameObject> _currentFans = new List<GameObject>();
    private List<GameObject> _currentPortals = new List<GameObject>();
    public SpriteRenderer dollar;


    void Start()
    {
        levelNumber = 0;
        SwitchLevel();
    }

    private void Update()
    {
        //currentLevel = level[levelNumber];

        //spawns fan on f
        if (Input.GetKeyDown(KeyCode.F) && GameManager.gameMode == GameMode.editMode)
        {
            GameObject fan = Instantiate(fanPrefab, new Vector3(3, 3, 0), Quaternion.identity);
            fan.transform.SetParent(currentLevel.transform);
            _currentFans.Add(fan);
        }

        //spawns portal on a
        if (Input.GetKeyDown(KeyCode.A) && GameManager.gameMode == GameMode.editMode)
        {
            GameObject portal = Instantiate(portalPrefab, new Vector3(3, 3, 0), Quaternion.identity);
            portal.transform.SetParent(currentLevel.transform);
            _currentPortals.Add(portal);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            ToggleGameMode();
        }

        if (Input.GetKeyDown(KeyCode.Q)) //only for debugging
        {
            SwitchLevel();
        }

        if (dollar == null)
            dollar = GameObject.FindGameObjectWithTag("Player").GetComponent<SpriteRenderer>();

        if (dollar != null && !dollar.isVisible)
        {
            RestartLevel();
        }
    }

    [Button]
    public void RestartLevel()
    {
        if (currentLevel != null)
        {
            levelNumber--;
            Destroy(currentLevel);
            currentLevel = Instantiate(level[levelNumber]);
            levelNumber++;
        }

    }

    [Button]
    public void SwitchLevel()
    {

        if (currentLevel != null)
        {
            Destroy(currentLevel);

        }
        gameMode = GameMode.editMode;
        //toggleGameMode.Invoke(gameMode);
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

