using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public Animator anim;
    private int vida = 3;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Personaje")
        {
            anim.Play("Enemigo");
            vida--;
        }

        if (vida == 0)
        {
            Destroy(this.gameObject);
        }
    }
}
