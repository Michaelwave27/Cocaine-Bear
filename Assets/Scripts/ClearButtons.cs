using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClearButtons : MonoBehaviour
{
    public GameObject attack;
    public GameObject item;
    public GameObject ultimate;
    public GameObject hp;
    public GameObject textBox;

    public void Clear()
    {
       attack.SetActive(false);
       item.SetActive(false);
       ultimate.SetActive(false);
       hp.SetActive(false);
       textBox.SetActive(false);   

    }
}
