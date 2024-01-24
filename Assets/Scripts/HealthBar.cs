using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;

    public void Update()
    {
        slider.maxValue = Character1.instance.maxHealth;
        slider.value = Character1.instance.health;
    }
}
