using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
        public int health;
        public int defense;
        public int money = 0;
        public int attack;

        

        public Player(int health, int defense, int attack)
        {
            this.health = health;
            this.defense = defense;
            this.attack = attack;
        }

        public void Attack(Boss enemy)
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
