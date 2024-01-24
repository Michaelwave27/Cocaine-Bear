using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class BeforeFinalDialouge : MonoBehaviour
{
    public Text text;
    public GameObject fight;
    bool seen1 = false;
    bool seen2 = false;
    bool seen3 = false;
    bool seen4 = false;
    bool seen5 = false;

    public void Fight()
    {
        SceneManager.LoadScene("FinalFight", LoadSceneMode.Single);
    }
    // Start is called before the first frame update
    void Start()
    {
        fight.SetActive(false);
        text.text = "You continue walking, ignoring the sudden change in style around you.";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Z) && seen4 == true && seen5 == false)
        {
            text.text = "It's time for the final dance...";
            seen5 = true;
            fight.SetActive(true);
        }

        if (Input.GetKeyUp(KeyCode.Z) && seen3 == true && seen4 == false)
        {
            text.text = "You prepare yourself.";
            seen4 = true;
        }

        if (Input.GetKeyUp(KeyCode.Z) && seen2 == true && seen3 == false)
        {
            text.text = "It's the Bear high on cocaine!!!!!!!";
            seen3 = true;
        }

        if (Input.GetKeyUp(KeyCode.Z) && seen1 == true && seen2 == false)
        {
            text.text = "It's him.";
            seen2 = true;
        }

        if (Input.GetKeyUp(KeyCode.Z) && seen1 == false)
        {
            text.text = "You instantly stop in your tracks as you spot something in the distance.";
            seen1 = true;
        }
    }
}
