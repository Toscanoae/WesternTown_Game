using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager_Station : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("trigger"))
            SceneManager.LoadScene("saloon");

        if (collider.CompareTag("trigger2"))
            SceneManager.LoadScene("station");

        if (collider.CompareTag("trigger3"))
            SceneManager.LoadScene("store");
    }

}

