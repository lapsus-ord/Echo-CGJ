using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerprefsValue : MonoBehaviour
{
    void Start()
    {
        PlayerPrefs.SetInt("valueHealth", 18);
        PlayerPrefs.SetFloat("posX", 1.5f);
        PlayerPrefs.SetFloat("posX", -0.2f);
    }
}
