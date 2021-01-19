using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PorteTP : MonoBehaviour
{
    // Start is called before the first frame update
    public string SceneToLoad;
    public Vector2 playerPosition;
    public VectorValue playerStorage;

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player") && !other.isTrigger){
            playerStorage.initialValue = playerPosition;
            SceneManager.LoadScene(SceneToLoad);
        }
    }
}
