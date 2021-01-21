using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerprefsValue : MonoBehaviour
{
    void Awake()
    {
        PlayerPrefs.DeleteAll();
    }

    void Start()
    {
        PlayerPrefs.SetInt("valueHealth", 36);
        PlayerPrefs.SetFloat("posX", 1.5f);
        PlayerPrefs.SetFloat("posY", -0.2f);
        PlayerPrefs.SetInt("nbDonjons",0);
    }
}
