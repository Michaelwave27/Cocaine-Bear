using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckDeath : MonoBehaviour
{
    void Update()
    {
        if(Character1.instance.health <= 0)
        {
            if (Character1.instance.wins == 2)
            {
                SceneManager.LoadScene("DeathFinal", LoadSceneMode.Single);
            }
            else
            {
                SceneManager.LoadScene("Death", LoadSceneMode.Single);
            }
        }
    }
}
