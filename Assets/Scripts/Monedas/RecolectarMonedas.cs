using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecolectarMonedas : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Personaje")
        {
            Prueba6.sumaMoneda();
            Destroy(this.gameObject);
        }
    }
}
