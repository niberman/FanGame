using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class LoadNextLevel : MonoBehaviour
{
    void OnEnable()
    {
        Button startButton = this.GetComponent<Button>();
        GameManager gm = FindObjectOfType<GameManager>();
        startButton.onClick.AddListener(() => gm.SwitchLevel());
    }


}
