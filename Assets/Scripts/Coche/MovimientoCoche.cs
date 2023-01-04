using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCoche : MonoBehaviour
{
    private float speed = 15f;
    private float rotationSpeed = 40f;
    private float horizontalInput;
    private bool empieza = false;

    void Update()
    {
        Cursor.lockState = (Input.GetKey(KeyCode.Escape) ? CursorLockMode.None : CursorLockMode.Locked);
        
        if (Input.GetKeyDown(KeyCode.E))
        {
            empieza = true;
        }

        if (empieza)
        {
            horizontalInput = Input.GetAxis("Horizontal");
        
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            transform.Rotate(Vector3.up, Time.deltaTime * rotationSpeed * horizontalInput);
        }
    }
}
