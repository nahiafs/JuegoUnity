using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using Random = UnityEngine.Random;

public class Prueba2 : MonoBehaviour
{
    private GameObject obstaculo;
    private GameObject obstaculo2;
    private GameObject obstaculo3;
    private GameObject obstaculo4;
    private GameObject obstaculo5;

    private GameObject puerta;
    
    private float[] zonas = {-14, -12, -10, -8, -6, -4, -2, 0, 2};

    private bool comenzado = false;
    
    // Start is called before the first frame update
    void Start()
    {
        obstaculo = Resources.Load("Laser", typeof(GameObject)) as GameObject;
        obstaculo2 = Resources.Load("Laser2", typeof(GameObject)) as GameObject;
        obstaculo3 = Resources.Load("Laser3", typeof(GameObject)) as GameObject;
        obstaculo4 = Resources.Load("Laser4", typeof(GameObject)) as GameObject;
        obstaculo5 = Resources.Load("Laser5", typeof(GameObject)) as GameObject;
        
        puerta = GameObject.Find("Puerta");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            juego();
        }
    }

    public void juego()
    {
        if (! comenzado)
        {
            comenzado = true;
            
            for (int i = 1; i <= 10; i++)
            {
                Invoke("generarObstaculos", i * 1.5f);
            }
        
            Invoke("aparecePuerta", 16f);
        }
    }

    public void generarObstaculos()
    {
        int random = Random.Range(1, 5);
        
        switch (random)
        {
            case 1:
                Instantiate(obstaculo, new Vector3(-6, obstaculo.transform.position.y, obstaculo.transform.position.z), obstaculo.transform.rotation);
                break;
            case 2:
                Instantiate(obstaculo3, new Vector3(-6, obstaculo3.transform.position.y, obstaculo3.transform.position.z), obstaculo3.transform.rotation);
                break;
            case 3:
                Instantiate(obstaculo4, new Vector3(-6, obstaculo4.transform.position.y, obstaculo4.transform.position.z), obstaculo4.transform.rotation);
                break;
            case 4:
                Instantiate(obstaculo5, new Vector3(-6, obstaculo5.transform.position.y, obstaculo5.transform.position.z), obstaculo5.transform.rotation);
                break;
        }
        
        for (int i = 0; i < Random.Range(2, 5); i++)
        {
            Instantiate(obstaculo2, new Vector3(zonas[Random.Range(0, zonas.Length)], obstaculo2.transform.position.y, obstaculo2.transform.position.z), obstaculo2.transform.rotation);
        }
    }

    public void aparecePuerta()
    {
        puerta.transform.position = new Vector3(-7.2f, 2f, 32.8f);
    }
}
