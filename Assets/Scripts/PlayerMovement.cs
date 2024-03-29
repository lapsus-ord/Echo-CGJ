﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5f;
    public GameObject player;
    public Rigidbody2D rb;
    public Animator animator;
    private Vector2 _movement;

    public GameObject menuPause;
    private Boolean _isInPause = false;

    void Start()
    {
        float posX = PlayerPrefs.GetFloat("posX");
        float posY = PlayerPrefs.GetFloat("posY");
        player.transform.position = new Vector3(posX, posY, 0.0f);
    }

    void Update()
    {
        _movement.x = Input.GetAxisRaw("Horizontal");
        _movement.y = Input.GetAxisRaw("Vertical");
        
        // Animation du personnage
        animator.SetFloat("Horizontal", _movement.x);
        animator.SetFloat("Vertical", _movement.y);
        animator.SetFloat("Speed", _movement.sqrMagnitude);

        // Modification de la variable lastDirection, pour lancer la bonne animation Idle (en fonction de notre orientation)
        if (_movement.x == 1)
        {
            animator.SetFloat("lastDirection", 4);
        } else if (_movement.x == -1)
        {
            animator.SetFloat("lastDirection", 3);
        } else if (_movement.y == 1)
        {
            animator.SetFloat("lastDirection", 1);
        }
        else if (_movement.y == -1)
        {
            animator.SetFloat("lastDirection", 2);
        }
        
        // Si on est dans le menu, on ne peut pas bouger
        _isInPause = menuPause.activeSelf;
    }

    private void FixedUpdate()
    {
        if (!_isInPause)
        {
            rb.MovePosition(rb.position + _movement * (moveSpeed * Time.fixedDeltaTime));
        }
        else if (_isInPause)
        {
            Cursor.SetCursor(null, Vector2.zero, CursorMode.ForceSoftware);
        }
    }
}
