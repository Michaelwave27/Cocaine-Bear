using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health;
    public int defense;
    public int money = 0;
    public int attack;
    public int maxHealth;
    public int damage;
    public int wins = 0;
    public bool crit = false; 
    public List<string> inventory;

        

    public Player(int health, int defense, int attack)
    {
        this.health = health;
        this.defense = defense;
        this.attack = attack;
        this.maxHealth = health;

    }

    public void Attack(Boss enemy)
    {
        int crit = Random.Range(0, 10);
        int randomDamage = Random.Range(Character1.instance.attack - 2, Character1.instance.attack + 3);
        if (crit == 9)
        {
            Character1.instance.crit = true;
            Character1.instance.damage = (2 * randomDamage) - enemy.defense;
            enemy.health -= (2 * randomDamage) - enemy.defense;
        }
        else
        {
            Character1.instance.damage = randomDamage - enemy.defense;
            enemy.health -= randomDamage - enemy.defense;
        }
            
    }

    public void Ultimate(Boss enemy)
    {
        int randomUltimateDamage = Random.Range(Character1.instance.attack * 2, Character1.instance.attack * 4);
        Character1.instance.damage = randomUltimateDamage - enemy.defense;
        enemy.health -= randomUltimateDamage - enemy.defense;

    }
}
