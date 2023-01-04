using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
{
    private String escena;
    
    private void Start()
    {
        String escenaActual = SceneManager.GetActiveScene().name;
        int num = Int32.Parse(escenaActual.Substring(6)) + 1;
        escena = "Prueba" + num;
        
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Personaje")
        {
            SceneManager.LoadScene(escena);
        }
    }
}
