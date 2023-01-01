using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCoche : MonoBehaviour
{
    private float speed = 0f;
    private float rotationSpeed = 40f;
    private float horizontalInput;

    private void Start()
    {
        StartCoroutine(empieza());
    }

    private IEnumerator empieza()
    {
        yield return new WaitForSeconds(3f);
        speed = 15f;
    }

    void Update()
    {
        Cursor.lockState = (Input.GetKey(KeyCode.Escape) ? CursorLockMode.None : CursorLockMode.Locked);
        
        horizontalInput = Input.GetAxis("Horizontal");
        
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        transform.Rotate(Vector3.up, Time.deltaTime * rotationSpeed * horizontalInput);

        /**
        if (horizontalInput != 0)
        {
            if (horizontalInput < 0)
            {
                //transform.Rotate(new Vector3(0, 0, 10));
                transform.rotation = new Quaternion(0, 0, 2, 0);
            }
            else
            {
                //transform.Rotate(new Vector3(0, 0, -10));
                transform.rotation = new Quaternion(0, 0, -2, 0);
            }
        }
        **/
    }
}
