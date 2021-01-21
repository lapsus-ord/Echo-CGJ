using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 20f;

    // public GameObject crosshair;
    private Vector3 target;

    // Update is called once per frame
    void Update()
    {
        target = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z));
        // crosshair.transform.position = new Vector2(target.x, target.y);

        Vector3 difference = target - firePoint.transform.position;
        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        
        if (Input.GetButtonDown("Fire1"))
        {
            float distance = difference.magnitude;
            Vector2 direction = difference / distance;
            direction.Normalize();
            fireBullet(direction, rotationZ);
        }
    }

    void fireBullet(Vector2 direction, float rotationZ)
    {
        GameObject b = Instantiate(bulletPrefab);
        b.transform.position = firePoint.transform.position;
        b.transform.rotation = quaternion.Euler(0.0f, 0.0f, rotationZ);

        b.GetComponent<Rigidbody2D>().velocity = direction * bulletSpeed;
    }
}
