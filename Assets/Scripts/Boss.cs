using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class Boss : MonoBehaviour
{
    public GameObject sortie;
    public GameObject sortieTile;
    public GameObject Coffre0;
    public GameObject Coffre1;
    public AudioSource odio;
    public Enemy Slime1;
    public Enemy Slime2;
    public Enemy Slime3;
    public GameObject oeil;
    
    public GameObject winCanvas;
    public GameObject winningSound;
    public GameObject musiquesDonjon;

    // Start is called before the first frame update
    void Awake()
    {
        sortie = GameObject.Find("Sortie");
        sortieTile = GameObject.Find("Grid/fg2");
        sortie.SetActive(false);
        sortieTile.SetActive(false);
        odio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (Slime1.health <= 0 && Slime2.health <= 0 && Slime3.health <= 0)
        {
            oeil.gameObject.SetActive(false);
            musiquesDonjon.SetActive(false);
            winningSound.SetActive(true);
            // PlayerPrefs.SetInt("nbDonjons", PlayerPrefs.GetInt("nbDonjons") + 1);
            Coffre0.SetActive(true);
            Coffre1.SetActive(true);
            winCanvas.SetActive(true);
            Cursor.SetCursor(null, new Vector2(0.0f, 0.0f), CursorMode.ForceSoftware);
            Invoke("LoadMenu", 5.0f);
        }
    }

    void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }
}