using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHUD : MonoBehaviour
{
    public GameObject HUD;
    public GameObject menuPause;
    public GameObject carte;
    public GameObject croix1;
    public GameObject croix2;
    
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
            if (PlayerPrefs.GetInt("nbDonjons") == 0){
                croix1.SetActive(true);
                croix2.SetActive(false);
            } else if (PlayerPrefs.GetInt("nbDonjons") == 1){
                croix1.SetActive(false);
                croix2.SetActive(true);
            }
        }
    }
}
