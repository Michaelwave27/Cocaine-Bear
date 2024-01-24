using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FountainDialouge : MonoBehaviour
{
    public Text text;
    public GameObject all;
    public GameObject some;
    public GameObject none;
    bool seen1 = false;
    bool seen2 = false;
    bool seen3 = false;
    bool next = false;
    bool option1 = false;
    bool option2 = false;   
    bool option3 = false;

    public void All()
    {
        all.SetActive(false);
        some.SetActive(false);
        none.SetActive(false);
        Character1.instance.money = 0;
        Character1.instance.health = Character1.instance.maxHealth;
        text.text = "You throw all your gold into the fountain and you feel a refreshing feeling.";
        option1 = true;
    }

    public void Some()
    {
        all.SetActive(false);
        some.SetActive(false);
        none.SetActive(false);
        Character1.instance.money = Character1.instance.money / 2;
        Character1.instance.health += Character1.instance.maxHealth / 2;
        if (Character1.instance.health > Character1.instance.maxHealth)
        {
            Character1.instance.health = Character1.instance.maxHealth;
        }
        text.text = "You throw some of your gold into the fountain and you feel a refreshing feeling.";
        option2 = true;
    }
    public void None()
    {
        all.SetActive(false);
        some.SetActive(false);
        none.SetActive(false);
        text.text = "I'm sorry but your just not intelligent I have to say...";
        option3 = true;
    }

    void Start()
    {
        all.SetActive(false);
        some.SetActive(false);
        none.SetActive(false);
        text.text = "You come across a fountain glowing with light.";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z) && next == true) 
        {
            SceneManager.LoadScene("BeforeFinal", LoadSceneMode.Single);
        }
        if (Input.GetKeyUp(KeyCode.Z) && option3 == true)
        {
            text.text = "Feeling awful and stupid, you continue forward";
            next = true;
        }

        if (Input.GetKeyUp(KeyCode.Z) && option2 == true)
        {
            text.text = "Feeling refreshed, you continue forward";
            next = true;
        }

        if (Input.GetKeyUp(KeyCode.Z) && option1 == true)
        {
            text.text = "Feeling super refreshed, you continue forward";
            next = true;
        }

        if (Input.GetKeyUp(KeyCode.Z) && seen2 == true && seen3 == false)
        {
            text.text = "How much gold do you throw in?";
            all.SetActive(true);
            some.SetActive(true);
            none.SetActive(true);
            seen3 = true;
        }

        if (Input.GetKeyUp(KeyCode.Z) && seen1 == true && seen2 == false)
        {
            text.text = "It's probably wise to use some gold in case the developers run out of time to create future uses for it.";
            seen2 = true;
        }

        if (Input.GetKeyUp(KeyCode.Z) && seen1 == false)
        {
            text.text = "You see a sign instructing you to throw gold in return of health.";
            seen1 = true;
        }
    }
}
