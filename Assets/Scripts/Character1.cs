using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character1 : Player 
{
    public static Character1 instance;
    public Character1(int health, int defense, int attack) : base(health, defense, attack)
    {
        this.maxHealth = health;

    }
    private void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

}
