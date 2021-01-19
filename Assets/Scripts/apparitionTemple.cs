using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class apparitionTemple : MonoBehaviour {

    private nbTemplesFaits raccourcisParent;

    void Start() {
        raccourcisParent = gameObject.GetComponentInParent<nbTemplesFaits>();
    }

    private void OnTriggerEnter2D(Collider2D other) {

        if(other.CompareTag("Player") && !other.isTrigger && raccourcisParent.testNbTemples()){
            Debug.Log("Temple activation");
            transform.GetChild(raccourcisParent.NbFaits).gameObject.SetActive(true);
        }
    }
}
