using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deer : Boss
{
    Deer deer = new Deer(60, 1, 4);

    public Deer(int health, int defense, int attack) : base(health, defense, attack)
    {
    }

    public void AttackPlayer(Player character)
    {
        deer.Attack(character);
    }
}
