using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prueba6 : MonoBehaviour
{
    private static int numMonedas;
    private GameObject puerta;
    
    // Start is called before the first frame update
    void Start()
    {
        numMonedas = 0;
        puerta = GameObject.Find("Puerta");
    }

    private void Update()
    {
        if (numMonedas == 3)
        {
            puerta.transform.position = new Vector3(-10f, 161.25f, -159f);
        }
    }

    public static void sumaMoneda()
    {
        numMonedas++;
    }
}
