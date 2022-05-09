using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            // here we are using SceneManager to allow us to load our level1 scene once the player collides with our end pole
            SceneManager.LoadScene(0);
        }
    }
}
