using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
    public Transform puntoDisparar;
    public Transform bala;
    private Transform mira;

    private void Start()
    {
        mira = GetComponentInChildren<Canvas>().transform;
    }

    public void disparar()
    {
        Instantiate(bala, puntoDisparar.position, puntoDisparar.rotation);
    }

    public void apareceMira(Transform camara)
    {
        RaycastHit hit;

        if (Physics.Raycast(camara.position, camara.forward, out hit))
        {
            puntoDisparar.LookAt(hit.point);
        }
        else
        {
            Vector3 end = camara.position + camara.forward;
            puntoDisparar.LookAt(end);
        }
    }
}
