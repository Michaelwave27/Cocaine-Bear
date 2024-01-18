using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boss : MonoBehaviour
{
    public int health;
    public int defense;
    public int attack;

    public Boss(int health, int defense, int attack)
    {
        this.health = health;
        this.defense = defense;
        this.attack = attack;
    }
        public void Attack(Player character)
    {
        int crit = Random.Range(0, 15); 
        if (crit == 0)
        {
            character.health -= (2 * this.attack) + character.defense;

        }
        else
        {
            character.health -= this.attack + character.defense;
        }
            
    }
        
    
}
