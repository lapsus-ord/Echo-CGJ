using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bouleDeFeu : MonoBehaviour
{
    public bool versDroite;
        void Update(){
            if (versDroite){
                transform.position = transform.position + new Vector3(5f * Time.deltaTime, 0, 0) ;
            } else {
                transform.position = transform.position + new Vector3(-5f * Time.deltaTime, 0, 0) ;
            }
        }
}
