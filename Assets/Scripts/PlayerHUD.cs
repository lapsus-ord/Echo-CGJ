using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHUD : MonoBehaviour
{
    public GameObject HUD;
    public GameObject menuPause;
    
    private void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            HUD.SetActive(!HUD.activeSelf);
            menuPause.SetActive(!HUD.activeSelf);
        }
    }
}
