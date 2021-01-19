using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nbTemplesFaits : MonoBehaviour
{
    public int NbFaits;
    public int NbRequis;
    void Start() {
        transform.GetChild(0).gameObject.SetActive(false);
    }

    void Update(){
        if (testNbTemples()){
            transform.GetChild(NbFaits).gameObject.SetActive(true);
        }
    }

    public bool testNbTemples(){
        if (NbFaits == NbRequis){
            return true;
        }
        return false;
    }
}
