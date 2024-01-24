using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class VictoryScript : MonoBehaviour
{
    public Text myText;
    public Boss enemy;
    public Player player;
    bool seen1 = false;
    bool seen2 = false;
    bool seen3 = false;
    bool seen4 = false;
    bool seen5 = false;

    private void Start()
    {
        myText.text = $"Congratulations!!! You beat {enemy.name}!!!";
    }
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Z) && seen5 == true)
        {
            if(Character1.instance.wins == 1)
            {
                SceneManager.LoadScene("GetPotion", LoadSceneMode.Single);
            }
            else if (Character1.instance.wins == 2)
            {
                SceneManager.LoadScene("Fountain",LoadSceneMode.Single);
            }
            Debug.Log(Character1.instance.attack);
            Debug.Log(Character1.instance.health);
        }
        if (Input.GetKeyUp(KeyCode.Z) && seen3 == true && seen4 == false)
        {
            myText.text = "After admiring your own strength, you remember that the Bear is still out there therefore you head deeper into the forest...";
            seen5 = true;
        }
        if (Input.GetKeyUp(KeyCode.Z) && seen2 == true && seen3 == false)
        {
            int randomDefense = Random.Range(1, 4);
            Character1.instance.defense += randomDefense;
            myText.text = $"You also gained {randomDefense} defense!!!";
            seen3 = true;
        }
        if (Input.GetKeyUp(KeyCode.Z) && seen1 == true && seen2 == false)
        {
            int randomAttack = Random.Range(5, 12);
            Character1.instance.attack += randomAttack;
            myText.text = $"With new fighting experience, you also gained {randomAttack} attack!!!";
            seen2 = true ;
        }

        if (Input.GetKeyUp(KeyCode.Z) && seen1 == false)
        {
            int randomCoins = Random.Range(5, 15);
            Character1.instance.money += randomCoins;
            myText.text = $"The {enemy.name} for no reason dropped {randomCoins} coins!!!";
            seen1 = true;

        }


    }
}
