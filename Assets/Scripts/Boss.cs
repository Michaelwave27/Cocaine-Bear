using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boss : MonoBehaviour
{
    public int health;
    public int defense;
    public int attack;
    public new string name;
    public int damage;
    public bool crit = false;
    public Boss(int health, int defense, int attack, string name)
    {
        this.health = health;
        this.defense = defense;
        this.attack = attack;
        this.name = name;
    }
        public void Attack(Character1 character1)
    {
        int crit = Random.Range(0, 15);
        int randomDamage = Random.Range(this.attack - 2, this.attack + 8);
        if (crit == 0)
        {
            this.crit = true;
            damage = (2 * randomDamage) - Character1.instance.defense;
            if (damage < 0)
            {
                damage = 0;
            }
            else
            {
                Character1.instance.health -= (2 * randomDamage) - Character1.instance.defense;
            }

        }
        else
        {
            damage = randomDamage - Character1.instance.defense;
            if (damage < 0)
            {
                damage = 0;
            }
            else
            {
                Character1.instance.health -= randomDamage - Character1.instance.defense;
            }
        }
            
    }
        
    
}
