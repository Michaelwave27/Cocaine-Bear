using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public class Character
    {
        public int health;
        public int defense;
        public int money = 0;
        public int attack;

        public Character(int health, int defense, int attack)
        {
            this.health = health;
            this.defense = defense;
            this.attack = attack;
        }

        public void Attack(Boss.Enemy enemy)
        {
            int crit = Random.Range(0, 10);
            if (crit == 9)
            {
                enemy.health -= (2 * this.attack) + enemy.defense;
            }
            else
            {
                enemy.health -= this.attack + enemy.defense;
            }
        }
    }
    public void Attack()
    {
        Character.Attack();
    }
    public void Character1()
    {
        Character character = new Character(100, 5, 8);
    }
    public void Character2()
    {
        Character character = new Character(150, 8, 5);
    }
    public void Character3()
    {
        Character character = new Character(100, 2, 12);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
