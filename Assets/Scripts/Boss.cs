using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Player;

public class Boss : MonoBehaviour
{   public class Enemy
    {
        public int health;
        public int defense;
        public int attack;

        public Enemy(int health, int defense, int attack)
        {
            this.health = health;
            this.defense = defense;
            this.attack = attack;
        }
            public void Attack(Character character)
        {
            int crit = Random.Range(0, 15); 
            if (crit == 0)
            {
                character.health = (2 * this.attack) + character.defense;

            }
            else
            {
                character.health = this.attack + character.defense;
            }
            
        }
        
    }
    public void Deer()
    {
        Enemy enemy = new Enemy(60, 2, 8);
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
