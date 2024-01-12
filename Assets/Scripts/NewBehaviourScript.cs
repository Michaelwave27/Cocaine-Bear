using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class IntroStory : MonoBehaviour
{
    public Text myText;
    bool seen1 = false;
    bool seen2 = false;
    bool seen3 = false;
    // Start is called before the first frame update
    void Start()
    {
        myText.text = "You step foot into the forest and begin your adventure...";
    }

    // Update is called once per frame
    void Update()
    {
        
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
            seen1 = true;
        }


    }
}
