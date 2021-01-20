using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public GameObject sortie;
    public GameObject sortieTile;
    public AudioSource odio;
    public bouleDeFeu boulasse;
    // Start is called before the first frame update
    void Awake()
    {
        sortie = GameObject.Find("Sortie");
        sortieTile = GameObject.Find("Grid/fg2");
        sortie.SetActive(false);
        sortieTile.SetActive(false);
        sonRun(odio);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void sonRun(AudioSource odio) {
        odio.PlayDelayed(0);
    }
}
