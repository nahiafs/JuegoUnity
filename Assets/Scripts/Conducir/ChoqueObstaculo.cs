using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoqueObstaculo : MonoBehaviour
{
    private GameObject personaje;

    private void Start()
    {
        personaje = GameObject.Find("Personaje");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Personaje")
        {
            personaje.transform.position = new Vector3(5, 1.5f, -90);
            personaje.transform.rotation = Quaternion.identity;
        }
    }
}
