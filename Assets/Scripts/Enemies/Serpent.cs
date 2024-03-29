﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Serpent : Enemy
{
    private Transform target;
    public float chaseRadius;
    public float attackRadius;

    float mx;
    float my;

    void Start()
    {
        target = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        checkDistance();
        mx = Input.GetAxisRaw("Horizontal");
        my = Input.GetAxisRaw("Vertical");

        if (mx < 0f)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        else if (mx > 0f)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
    }

    void checkDistance()
    {
        if (Vector3.Distance(target.position, transform.position) <= chaseRadius &&
            Vector3.Distance(target.position, transform.position) > attackRadius)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
        }
    }
}