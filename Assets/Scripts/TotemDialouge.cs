using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TotemDialouge : MonoBehaviour
{
    public Text myText;
    public GameObject Ares;
    public GameObject Athena;
    public GameObject Hygieia;
    bool seen1 = false;
    bool seen2 = false;
    bool seen3 = false;
    bool next = false;

    public void AresButton()
    {
        Ares.SetActive(false);
        Athena.SetActive(false);
        Hygieia.SetActive(false);
        int randomAttack = Random.Range(8, 20);
        Character1.instance.attack += randomAttack;
        myText.text = $"You worship the Ares totem and suddenly gain {randomAttack} attack.";
        next = true;
    }
    public void AthenaButton()
    {
        Ares.SetActive(false);
        Athena.SetActive(false);
        Hygieia.SetActive(false);
        int randomDefense = Random.Range(3,8);
        Character1.instance.defense += randomDefense;
        myText.text = $"You worship the Athena totem and suddenly gain {randomDefense} defense.";
        next = true;
    }
    public void HygieiaButton()
    {
        Ares.SetActive(false);
        Athena.SetActive(false);
        Hygieia.SetActive(false);
        int randomHealth = Random.Range(30,60);
        Character1.instance.health += randomHealth;
        Character1.instance.maxHealth += randomHealth;
        myText.text = $"You worship the Hygieia totem and suddenly gain {randomHealth} health.";
        next = true;
    }
    // Start is called before the first frame update
    void Start()
    {
        Ares.SetActive(false);
        Athena.SetActive(false);
        Hygieia.SetActive(false);
        myText.text = "You stumble across multiple totems resembling Gods or Goddesses";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Z) && next == true)
        {
            myText.text = "";
            SceneManager.LoadScene("BeforeFight2", LoadSceneMode.Single);
        }

        if (Input.GetKeyUp(KeyCode.Z) && seen2 == true && seen3 == false)
        {
            Ares.SetActive(true);
            Athena.SetActive(true);
            Hygieia.SetActive(true);
            seen3 = true;
        }

        if (Input.GetKeyUp(KeyCode.Z) && seen1 == true && seen2 == false)
        {
            myText.text = "Which totem should you worship?";
            seen2 = true;
        }

        if (Input.GetKeyUp(KeyCode.Z) && seen1 == false)
        {
            myText.text = "You have a sudden temptation to worship one of the totems.";
            seen1 = true;
        }
    }
}
