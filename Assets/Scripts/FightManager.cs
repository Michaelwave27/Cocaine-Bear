using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightManager : MonoBehaviour
{
    public Player player;
    public Boss enemy;

    public void PlayerAttack()
    {
        player.Attack(enemy);

        Debug.Log(enemy.health);

        StartCoroutine(WaitForFunction());

        enemy.Attack(player);

        Debug.Log(player.health);


    }


    IEnumerator WaitForFunction()
    {
        yield return new WaitForSeconds(3);

    }
}
