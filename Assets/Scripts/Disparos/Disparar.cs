using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{
    public Arma arma;
    private GameObject camara;

    // Start is called before the first frame update
    void Start()
    {
        camara = GameObject.FindGameObjectWithTag("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        arma.apareceMira(camara.transform);
        
        if (Input.GetMouseButtonDown(0))
        {
            arma.disparar();
        }
    }
}
