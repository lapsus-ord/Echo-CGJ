using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    private Vector2 movement;

    public GameObject menuPause;
    private Boolean isInPause = false;

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        // Si on est dans le menu, on ne peut pas bouger
        isInPause = menuPause.activeSelf;
    }

    private void FixedUpdate()
    {
        if (!isInPause)
        {
            rb.MovePosition(rb.position + movement * (moveSpeed * Time.fixedDeltaTime));
        }
    }
}
