using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonTraffic : MonoBehaviour
{

    private CharacterController controller;
    public Vector3 dir;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void FixedUpdate()
    {
        controller.Move(dir * Time.fixedDeltaTime);
    }
}
