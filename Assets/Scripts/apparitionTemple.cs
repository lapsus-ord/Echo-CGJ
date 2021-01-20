using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class apparitionTemple : MonoBehaviour {

    public int nbDuTemple;

    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("Rentré dans la zone !");
        if(other.CompareTag("Player") && !other.isTrigger && nbDuTemple == PlayerPrefs.GetInt("nbDonjons") + 1){
            Debug.Log("Temple activation");
            transform.GetChild(0).gameObject.SetActive(true);
        }
    }
}
