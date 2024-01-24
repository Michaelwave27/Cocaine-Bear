using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GetPotionDialouge : MonoBehaviour
{
    public Text myText;
    public GameObject yesButton;
    public GameObject noButton;
    bool seen1 = false;
    bool seen2 = false;
    bool seen3 = false;
    bool seen4 = false;
    bool seen5 = false;
    bool seen6 = false;
    bool seen7 = false; 
    bool seen8 = false;
    bool seen9 = false;
    bool seen10 = false;

    // Start is called before the first frame update

    public void Yes()
    {   
        if (Character1.instance.money >= 5)
        {
            yesButton.SetActive(false); 
            noButton.SetActive(false);
            Character1.instance.inventory.Add("Potion");
            Character1.instance.money -= 5;
            myText.text = "The figure takes the gold and vanishes instantly, you gained a potion.";
            seen5 = true;
        }
        else
        {
            yesButton.SetActive(false);
            noButton.SetActive(false);
            myText.text = "You don't have enough gold...";
            seen6 = true;
        }
    }

    public void No()
    {
        yesButton.SetActive(false);
        noButton.SetActive(false);
        myText.text = "The figure frowns at you and unleashes a spell directly on you!";
        seen7 = true;
    }
    void Start()
    {
        yesButton.SetActive(false);
        noButton.SetActive(false);
        myText.text = "While walking through the forest you encounter a mysterious figure staring at you...";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Z) && seen10 == true)
        {
            SceneManager.LoadScene("Totem", LoadSceneMode.Single);
            Debug.Log(Character1.instance.health);
        }

        if (Input.GetKeyUp(KeyCode.Z) && seen9 == true && seen10 == false)
        {
            myText.text = "Wounded, You continue further";
            seen9 = false;
            seen10 = true;
        }

        if (Input.GetKeyUp(KeyCode.Z) && seen8 == true && seen9 == false)
        {
            myText.text = "Wounded, You continue further";
            seen8 = false;
            seen9 = true;
        }

        if (Input.GetKeyUp(KeyCode.Z) && seen7 == true)
        {
            myText.text = $"You suffer 25 damage leaving you with {Character1.instance.health -= 25} health!!!";
            seen7 = false;
            seen8 = true;
        }

        if (Input.GetKeyUp(KeyCode.Z) && seen6 == true)
        {

            yesButton.SetActive(true);
            noButton.SetActive(true);
            seen6 = false;
        }

        if (Input.GetKeyUp(KeyCode.Z) && seen5 == true)
        {
            SceneManager.LoadScene("Totem", LoadSceneMode.Single);
            Debug.Log(Character1.instance.inventory);
        }

        if (Input.GetKeyUp(KeyCode.Z) && seen3 == true && seen4 == false)
        {
            myText.text = "";
            yesButton.SetActive (true);
            noButton.SetActive (true);
            seen4 = true;
            
        }

        if (Input.GetKeyUp(KeyCode.Z) && seen2 == true && seen3 == false)
        {
            myText.text = "Do you buy a mysterious potion?";
            seen3 = true;
        }

        if (Input.GetKeyUp(KeyCode.Z) && seen1 == true && seen2 == false)
        {
            myText.text = "As you reach out to take it, they demand you give them 5 gold";
            seen2 = true;
        }

        if (Input.GetKeyUp(KeyCode.Z) && seen1 == false)
        {
            myText.text = "They offer you red potion claiming that it heals you";
            seen1 = true;

        }
    }
}
