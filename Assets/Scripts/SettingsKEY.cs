using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SomeScript : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Settings", LoadSceneMode.Additive);
        }
        
        if (Input.GetKeyDown(KeyCode.X))
        {
            SceneManager.UnloadSceneAsync("Settings");
        }
    }
}