using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float sceneDelay = 1f;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            // Invoke takes 2 parameters: ("name of method", delay)
            Invoke("ReloadScene", sceneDelay);
        }
    }

    void ReloadScene()
    {
         // here we are using SceneManager to allow us to load our level1 scene once the player collides with our end pole
            SceneManager.LoadScene(0);
    }
}
