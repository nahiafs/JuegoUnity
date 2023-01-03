using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{
    public Arma arma;
    private GameObject camara;

    private bool empieza = false;

    // Start is called before the first frame update
    void Start()
    {
        camara = GameObject.FindGameObjectWithTag("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        arma.apareceMira(camara.transform);
        
        if (Input.GetKeyDown(KeyCode.E))
        {
            empieza = true;
        }

        if (empieza)
        {
            if (Input.GetMouseButtonDown(0))
            {
                arma.disparar();
            }
        }
    }
}
