﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Invoke("DestroyObject", 0.05f);
    }

    void DestroyObject()
    {
        Destroy(this.gameObject);
    }
}
