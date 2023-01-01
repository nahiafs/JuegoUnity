using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MuerteParkour : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Personaje")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
