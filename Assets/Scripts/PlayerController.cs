using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Windows;

public class PlayerController : MonoBehaviour
{
    CharacterController controller;
    public Vector3 dir;
    [SerializeField] public float JumpForce;
    [SerializeField] public float gravity;
    

    void Start() 
    {
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        { 
            if (controller.isGrounded)
                Jump();
        } 
    }

    void FixedUpdate()
    {
        controller.Move(dir * Time.fixedDeltaTime);
        dir.y += gravity * Time.fixedDeltaTime;
    }

    void Jump()
    {
        dir.y = JumpForce;
    }
}
