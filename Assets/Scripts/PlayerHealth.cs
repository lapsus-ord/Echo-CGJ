using System;
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

    private int _valueHealth;

    void Awake()
    {
        Debug.Log("Vie : " + PlayerPrefs.GetInt("valueHealth"));
        _valueHealth = PlayerPrefs.GetInt("valueHealth");
    }

    void Start()
    {
        Verification(_valueHealth, healthBar, healthSprite);
    }

    // Mise à jour de la vie du perso 
    private void Update()
    {
        Verification(_valueHealth, healthBar, healthSprite);
        PlayerPrefs.SetInt("valueHealth", _valueHealth);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Snake"))
        {
            hurtSound.Play();
            _valueHealth -= 3;
        } else if (other.CompareTag("Slime"))
        {
            hurtSound.Play();
            _valueHealth -= 5;
        } else if (other.CompareTag("feu")){
            hurtSound.Play();
            _valueHealth -= 10;
        }
    }

    void Verification(int value, Image[] healthBar, Sprite[] healthSprite)
    {
        if (_valueHealth == 30)
        {
            healthBar[0].sprite = healthSprite[1];
            healthBar[1].sprite = healthSprite[2];
            healthBar[2].sprite = healthSprite[2];
        }
        else if (_valueHealth == 24)
        {
            healthBar[0].sprite = healthSprite[0];
            healthBar[1].sprite = healthSprite[2];
            healthBar[2].sprite = healthSprite[2];
        }
        else if (_valueHealth == 18)
        {
            healthBar[0].sprite = healthSprite[0];
            healthBar[1].sprite = healthSprite[1];
            healthBar[2].sprite = healthSprite[2];
        }
        else if (_valueHealth == 12)
        {
            healthBar[0].sprite = healthSprite[0];
            healthBar[1].sprite = healthSprite[0];
            healthBar[2].sprite = healthSprite[2];
        }
        else if (_valueHealth == 6)
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

    IEnumerator WaitForSeconds()
    {
        gameOver.SetActive(true);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(0);
    }
}