using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    void LoadScene()
    {
        SceneManager.LoadScene("Main");
        Debug.Log("button clicked");
    }
}
