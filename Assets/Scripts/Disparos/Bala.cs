using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public float velocidadBala = 100f;

    public float vidaBala = 5f;
    private float deltaTime = 0f;
    private Rigidbody rigidBala;
    
    // Start is called before the first frame update
    void Start()
    {
        rigidBala = GetComponent<Rigidbody>();
        rigidBala.velocity = transform.forward * velocidadBala;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        deltaTime += Time.deltaTime;

        if (deltaTime >= vidaBala)
        {
            Destroy(this.gameObject);
        }
    }
}
