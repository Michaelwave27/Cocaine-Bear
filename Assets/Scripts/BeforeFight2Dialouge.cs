using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BeforeFight2Dialouge : MonoBehaviour
{
    public GameObject CocaineTrail;
    public GameObject StartFight;
    public Text myText;
    bool seen1 = false;
    bool seen2 = false;
    bool seen3 = false;
    bool seen4 = false;
    bool spawnCocaine = false;
    // Start is called before the first frame update
    void Start()
    {
        StartFight.SetActive(false);
        myText.text = "You adventure further into the forest.";
    }

    void Spawn()
    {
        if (spawnCocaine == false)
        {
            CocaineTrail.GetComponent<Renderer>().sortingOrder = 5;
            spawnCocaine = true;
        }

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Z) && seen3 == true && seen4 == false)
        {
            myText.text = "ITS A COW AND HERE HE COMES!!!";
            seen4 = true;
            StartFight.SetActive(true);
        }

        if (Input.GetKeyUp(KeyCode.Z) && seen2 == true && seen3 == false)
        {
            myText.text = "However this time, it's not a deer...";
            seen3 = true;
        }
        if (Input.GetKeyUp(KeyCode.Z) && seen1 == true && seen2 == false)
        {
            myText.text = "You ready up for another upcomcing battle with an animal high on cocaine.";
            seen2 = true;
        }
        if (Input.GetKeyUp(KeyCode.Z) && seen1 == false)
        {
            myText.text = "Just then you notice more cocaine on the ground.";
            Spawn();
            seen1 = true;

        }


    }
}
