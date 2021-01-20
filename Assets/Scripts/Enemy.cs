using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    public string enemy_name;
    public int baseAttack;
    public float moveSpeed;
    public AudioSource odio;

    void Start()
    {
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("balle"))
        {
            sonRun(odio);
            Debug.Log(this.health);
            this.health -= 1;
            if (this.health <= 0)
            {
                Death();
            }
        }
    }

    void Death()
    {
        this.gameObject.SetActive(false);
        Debug.Log("MOOOOOORT");
    }

    void sonRun(AudioSource odio)
    {
        odio.PlayDelayed(0);
    }
}