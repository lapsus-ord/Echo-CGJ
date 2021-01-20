﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;

public class PlayerHealth : MonoBehaviour
{
    public GameObject gameOver;
    public AudioSource hurtSound;
    public Sprite[] healthSprite;
    public Image[] healthBar;

    private int _valueHealth = 18;

    // Mise à jour de la vie du perso 
    private void Update()
    {
        if (_valueHealth == 15)
        {
            healthBar[0].sprite = healthSprite[1];
            healthBar[1].sprite = healthSprite[2];
            healthBar[2].sprite = healthSprite[2];
        }
        else if (_valueHealth == 12)
        {
            healthBar[0].sprite = healthSprite[0];
            healthBar[1].sprite = healthSprite[2];
            healthBar[2].sprite = healthSprite[2];
        }
        else if (_valueHealth == 9)
        {
            healthBar[0].sprite = healthSprite[0];
            healthBar[1].sprite = healthSprite[1];
            healthBar[2].sprite = healthSprite[2];
        }
        else if (_valueHealth == 6)
        {
            healthBar[0].sprite = healthSprite[0];
            healthBar[1].sprite = healthSprite[0];
            healthBar[2].sprite = healthSprite[2];
        }
        else if (_valueHealth == 3)
        {
            healthBar[0].sprite = healthSprite[0];
            healthBar[1].sprite = healthSprite[0];
            healthBar[2].sprite = healthSprite[1];
        }
        else if (_valueHealth == 0)
        {
            healthBar[0].sprite = healthSprite[0];
            healthBar[1].sprite = healthSprite[0];
            healthBar[2].sprite = healthSprite[0];
            StartCoroutine("WaitForSeconds");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Snake"))
        {
            hurtSound.Play();
            _valueHealth -= 1;
        }
    }

    IEnumerator WaitForSeconds()
    {
        gameOver.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(0);
    }
}