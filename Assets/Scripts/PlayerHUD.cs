using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHUD : MonoBehaviour
{
    public GameObject HUD;
    public GameObject menuPause;
    public GameObject carte;
    
    private void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            HUD.SetActive(!HUD.activeSelf);
            menuPause.SetActive(!HUD.activeSelf);
        }
        if (Input.GetButtonDown("Map"))
        {
            HUD.SetActive(!HUD.activeSelf);
            carte.SetActive(!HUD.activeSelf);
        }
    }
}
