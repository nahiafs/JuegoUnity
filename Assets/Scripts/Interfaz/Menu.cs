using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Jugar()
    {
        SceneManager.LoadScene("Prueba1");
    }

    public void Salir()
    {
        Application.Quit();
    }

    public void Creditos()
    {
        SceneManager.LoadScene("Creditos");
    }

    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }
}
