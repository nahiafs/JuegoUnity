using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RondaDisparos : MonoBehaviour
{
    public int dianasTotales;
    static List<string> dianas;
    public GameObject muro;

    private GameObject enemigo4;
    private GameObject enemigo5;
    private GameObject enemigos;

    private bool segundaRonda = false;
    
    // Start is called before the first frame update
    void Start()
    {
        dianas = new List<string>();
        enemigo4 = Resources.Load("Enemigo4", typeof(GameObject)) as GameObject;
        enemigo5 = Resources.Load("Enemigo5", typeof(GameObject)) as GameObject;
        enemigos = GameObject.Find("Enemigos");
    }

    // Update is called once per frame
    void Update()
    {
        if (dianas.Count == dianasTotales && ! segundaRonda)
        {
            Instantiate(enemigo4, new Vector3(688, 390, -388), Quaternion.identity, enemigos.transform);
            Instantiate(enemigo5, new Vector3(696, 390, -388), Quaternion.identity, enemigos.transform);
            segundaRonda = true;
        }

        if (dianas.Count == 5)
        {
            Destroy(muro);
        }
    }

    public static void aniadirDiana(string diana)
    {
        dianas.Add(diana);
    }
}
