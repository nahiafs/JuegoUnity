using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LuchaPersonaje : MonoBehaviour
{
    private Animator anim;
    private CharacterController controller;
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponentInChildren<Animator>();
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            anim.SetTrigger("golpeo");
            Vector3 mover = Quaternion.Euler(0, 1, 0) * Vector3.forward;
            controller.Move(mover.normalized * 1);
        }
    }
}
