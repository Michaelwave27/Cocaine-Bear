using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class IntroStory : MonoBehaviour
{
    public GameObject CocaineTrail;
    public GameObject Note;
    public GameObject StartFight;
    public Text myText;
    bool seen1 = false;
    bool seen2 = false;
    bool seen3 = false;
    bool seen4 = false;
    bool seen5 = false;
    bool seen6 = false;
    bool seen7 = false;
    bool seen8 = false;
    bool spawnCocaine = false;
    // Start is called before the first frame update
    void Start()
    {
        StartFight.SetActive(false);
        myText.text = "You step foot into the forest and begin your adventure...";
    }

    void Spawn()
    {
        if (spawnCocaine == false)
        {
            CocaineTrail.GetComponent<Renderer>().sortingOrder = 5;
            spawnCocaine = true;
        }
        else
        {
            Note.GetComponent<Renderer>().sortingOrder = 5;
        }
            
        
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Z) && seen7 == true && seen8 == false)
        {
            Note.GetComponent<Renderer>().sortingOrder = 0;
            myText.text = "Before you could comprehend what you just read, a deer that looks high on cocaine charges towards you!";
            seen8 = true;
            StartFight.SetActive(true);
        }

        if (Input.GetKeyUp(KeyCode.Z) && seen6 == true && seen7 == false)
        {
            myText.text = "\"Kill it for me please? Thanks <3\"";
            seen7 = true;
        }

        if (Input.GetKeyUp(KeyCode.Z) && seen5 == true && seen6 == false)
        {
            myText.text = "\"There may or may not be a bear high on cocaine...\"";
            seen6 = true;
        }

        if (Input.GetKeyUp(KeyCode.Z) && seen4 == true && seen5 == false)
        {
            myText.text = "\"Yooooo whoever is reading this. Can you kindly do me a favor?\"";
            seen5 = true;
        }
        
        if (Input.GetKeyUp(KeyCode.Z) && seen3 == true && seen4 == false)
        {
            myText.text = "You see a note lying on the side, you pick it up and read it";
            seen4 = true;
            Spawn();
        }
        
        if (Input.GetKeyUp(KeyCode.Z) && seen2 == true && seen3 == false)
        {
            myText.text = "THATS F**KING COCAINE";
            seen3 = true;
        }
        if (Input.GetKeyUp(KeyCode.Z) && seen1 == true && seen2 == false) 
        {
            myText.text = "Wait a minute, thats not snow...";
            seen2 = true;
        }
        if (Input.GetKeyUp(KeyCode.Z) && seen1 == false) 
        {
            myText.text = "You notice a trail of snow randomly in the middle of the woods";
            Spawn();
            seen1 = true;
            
        }


    }
}
