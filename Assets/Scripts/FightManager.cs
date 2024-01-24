using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;

public class FightManager : MonoBehaviour
{
    public Character1 player;
    public Boss enemy;
    public GameObject textbox;
    public Text fightText;
    public GameObject textbox2;
    public Text ultimateText;
    public GameObject attack;
    public GameObject item;
    public GameObject ultimate;
    public GameObject hp;
    public VideoClip playeranimation;
    public VideoClip enemyanimation;
    public VideoClip ultimateanimation;
    bool turnover = false;
    int ultimatecount = 3;

    public VideoPlayer videoPlayer;
    public GameObject videoObject;

    public GameObject original;
    public GameObject finalAttack;
    public GameObject finalBearAttack;

    public void unClear()
    {
        attack.SetActive(true);
        item.SetActive(true);
        ultimate.SetActive(true);
        hp.SetActive(true);
        textbox2.SetActive(true);
    }
    public void PlayerAttack()
    {

        StartCoroutine(playerattack());
        ultimatecount -= 1;

    }

    public void PlayerAttackFinal()
    {
        StartCoroutine(playerattackFinal());
        ultimatecount -= 1;
    }

    public void UltimateFinal()
    {
        if (ultimatecount == 0)
        {
            StartCoroutine(ultimateattackFinal());
        }
        else
        {
            textbox.SetActive(true);
            fightText.text = "You can't use your ultimate yet!";
            turnover = true;
        }
    }
    public void Ultimate()
    {
        if(ultimatecount == 0)
        {
            StartCoroutine(ultimateattack());
        }
        else
        {
            textbox.SetActive(true);
            fightText.text = "You can't use your ultimate yet!";
            turnover = true;
        }
    }

    IEnumerator playerattackFinal()
    {
        original.SetActive(false);
        finalAttack.SetActive(true);

        yield return new WaitForSeconds(1);

        finalAttack.SetActive(false);
        original.SetActive(true);

        player.Attack(enemy);

        textbox.SetActive(true );

        if (Character1.instance.crit == true)
        {
            fightText.text = $"You struck {enemy.name} and crit for {Character1.instance.damage}!!!";
            Character1.instance.crit = false;
        }
        else
        {
            fightText.text = $"You struck {enemy.name} for {Character1.instance.damage}!!!";
        }

        yield return WaitForKeyPress(KeyCode.Z);

        if (textbox.activeInHierarchy == false)
        {
            original.SetActive(false);

            finalBearAttack.SetActive(true);

            yield return new WaitForSeconds(1);

            finalBearAttack.SetActive(false);

            original.SetActive(true);

            enemy.Attack(player);

            Debug.Log(player.health);

            textbox.SetActive(true);

            if (enemy.crit == true)
            {
                fightText.text = $"{enemy.name} attacks you and crits for {enemy.damage}!!!";
                enemy.crit = false;
            }
            else
            {
                fightText.text = $"{enemy.name} attacks you for {enemy.damage}!!!";
            }

            turnover = true;
        }
    }
    IEnumerator playerattack()
    {

        PlayAnimation(playeranimation);

        yield return new WaitForSeconds(2);

        StopAnimation();

        player.Attack(enemy);

        Debug.Log(enemy.health);

        textbox.SetActive(true);

        if (Character1.instance.crit == true)
        {
            fightText.text = $"You struck {enemy.name} and crit for {Character1.instance.damage}!!!";
            Character1.instance.crit = false;
        }
        else
        {
            fightText.text = $"You struck {enemy.name} for {Character1.instance.damage}!!!";
        }

        yield return WaitForKeyPress(KeyCode.Z);

        if (textbox.activeInHierarchy == false){


            PlayAnimation(enemyanimation);

            yield return new WaitForSeconds(2);

            StopAnimation();

            enemy.Attack(player);

            Debug.Log(player.health);

            textbox.SetActive(true);

            if(enemy.crit == true)
            {
                fightText.text = $"{enemy.name} attacks you and crits for {enemy.damage}!!!";
                enemy.crit = false;
            }
            else
            {
                fightText.text = $"{enemy.name} attacks you for {enemy.damage}!!!";
            }

            turnover = true;
        }
    }
    IEnumerator ultimateattackFinal()
    {
        PlayAnimation(ultimateanimation);

        yield return new WaitForSeconds(3);

        StopAnimation();

        player.Ultimate(enemy);

        Debug.Log(enemy.health);

        textbox.SetActive(true);

        fightText.text = $"You used your ultimate on {enemy.name} and dealt {Character1.instance.damage} damage!!!";

        yield return WaitForKeyPress(KeyCode.Z);

        if (textbox.activeInHierarchy == false)
        {

            original.SetActive(false);

            finalBearAttack.SetActive(true);

            yield return new WaitForSeconds(1);

            original.SetActive(true);

            finalBearAttack.SetActive(false);  
            
            enemy.Attack(player);

            Debug.Log(player.health);

            textbox.SetActive(true);

            if (enemy.crit == true)
            {
                fightText.text = $"{enemy.name} attacks you and crits for {enemy.damage}!!!";
                enemy.crit = false;
            }
            else
            {
                fightText.text = $"{enemy.name} attacks you for {enemy.damage}!!!";
            }

            ultimatecount = 3;

            turnover = true;
        }
    }
    IEnumerator ultimateattack()
    {

        PlayAnimation(ultimateanimation);

        yield return new WaitForSeconds(3);

        StopAnimation();

        player.Ultimate(enemy);

        Debug.Log(enemy.health);

        textbox.SetActive(true);

        fightText.text = $"You used your ultimate on {enemy.name} and dealt {Character1.instance.damage} damage!!!";
        
        yield return WaitForKeyPress(KeyCode.Z);

        if (textbox.activeInHierarchy == false)
        {

            PlayAnimation(enemyanimation);

            yield return new WaitForSeconds(2);

            StopAnimation();

            enemy.Attack(player);

            Debug.Log(player.health);

            textbox.SetActive(true);

            if (enemy.crit == true)
            {
                fightText.text = $"{enemy.name} attacks you and crits for {enemy.damage}!!!";
                enemy.crit = false;
            }
            else
            {
                fightText.text = $"{enemy.name} attacks you for {enemy.damage}!!!";
            }
            
            ultimatecount = 3;

            turnover = true;
        }
    }

    private void PlayAnimation(VideoClip animationClip)
    {
        videoObject.SetActive(true);

        videoPlayer.clip = animationClip;

        videoPlayer.Play();
    }

    private void StopAnimation()
    {
        if (videoPlayer.isPlaying)
        {
            videoPlayer.Stop();
        }

        videoObject.SetActive(false);
    }
    private IEnumerator WaitForKeyPress(KeyCode key) //Chat GPT
    {
        float timer = 0;
        while (!Input.GetKeyUp(key))
        {
            timer += Time.deltaTime;
            yield return null;
        }
    }

    private void Start()
    {
        textbox.SetActive(false);
        videoObject.SetActive(false);
        finalAttack.SetActive(false);
        finalBearAttack.SetActive(false);
    }

    private void Update()
    {
        if (textbox.activeInHierarchy == true)
        {
            if (Input.GetKeyUp(KeyCode.Z))
            {
                if (turnover == false)
                {
                    textbox.SetActive(false);
                }
                else
                {
                    textbox.SetActive(false);
                    unClear();
                    turnover = false;
                }
            }
        }
        
        if (enemy.health <= 0)
        {
            Character1.instance.wins += 1;
            if (Character1.instance.wins ==1)
            {
                SceneManager.LoadScene("Victory1", LoadSceneMode.Single);
            }
            if (Character1.instance.wins ==2) 
            {
                SceneManager.LoadScene("Victory2", LoadSceneMode.Single);
            }
            if (Character1.instance.wins == 3)
            {
                SceneManager.LoadScene("Victory3", LoadSceneMode.Single);
            }
        }
        
        if(ultimatecount < 0)
        {
            ultimatecount = 0;
        }
        ultimateText.text = $"Turns left: {ultimatecount}";
    }
}
