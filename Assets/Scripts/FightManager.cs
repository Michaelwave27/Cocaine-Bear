using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class FightManager : MonoBehaviour
{
    public Player player;
    public Boss enemy;
    public GameObject textbox;
    public Text fightText;
    public GameObject attack;
    public GameObject item;
    public GameObject ultimate;
    public GameObject hp;
    public VideoClip playeranimation;
    public VideoClip enemyanimation;
    public GameObject animationholder;
    bool turnover = false;

    public VideoPlayer videoPlayer;
    private Material originalMaterial;

    public void unClear()
    {
        attack.SetActive(true);
        item.SetActive(true);
        ultimate.SetActive(true);
        hp.SetActive(true);
    }
    public void PlayerAttack()
    {

        StartCoroutine(playerattack());

    }
    IEnumerator playerattack()
    {
        player.Attack(enemy);

        Debug.Log(enemy.health);

        Renderer videoRenderer = videoPlayer.GetComponentInChildren<Renderer>();

        originalMaterial = videoRenderer.material;
        PlayAnimation(playeranimation);

        yield return new WaitForSeconds(2);

        StopAnimation();
        ResetMaterial();

        textbox.SetActive(true);

        fightText.text = $"You struck {enemy.name}!!!";

        enemy.Attack(player);

        Debug.Log(player.health);

        yield return WaitForKeyPress(KeyCode.Z);

        if (textbox.activeInHierarchy == false){


            PlayAnimation(enemyanimation);

            yield return new WaitForSeconds(2);

            StopAnimation();
            ResetMaterial();

            textbox.SetActive(true);

            fightText.text = $"{enemy.name} attacks you!!!";

            turnover = true;
        }
    }

    private void PlayAnimation(VideoClip animationClip)
    {
  
        videoPlayer.clip = animationClip;

        videoPlayer.Play();
    }

    private void StopAnimation()
    {
        if (videoPlayer.isPlaying)
        {
            videoPlayer.Stop();
        }
    }

    private void ResetMaterial()
    {
        Renderer videoRenderer = videoPlayer.GetComponentInChildren<Renderer>();

        videoRenderer.material = originalMaterial;
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
    }
}
