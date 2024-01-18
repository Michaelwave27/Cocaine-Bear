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

    public void clear()
    {
       attack.SetActive(false);
       item.SetActive(false);
       ultimate.SetActive(false);
       hp.SetActive(false);

    }

    public void unClear()
    {
        attack.SetActive(true);
        item.SetActive(true);
        ultimate.SetActive(true);
        hp.SetActive(true);
    }
}
